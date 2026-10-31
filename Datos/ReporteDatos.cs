using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Consultas de Reportes (solo lectura). @desde y @hasta limitan el período: @hasta es el día siguiente al último.
    internal class ReporteDatos
    {
        private const string hoy = "CAST(GETDATE() AS DATE)";

        // ================= Totales =================

        public static int ContarClientesActivos()
        {
            return Contar("SELECT COUNT(*) FROM Cliente c JOIN Persona p ON p.idPersona = c.idPersona WHERE p.estado = 'Activo'");
        }

        public static int ContarClientes()
        {
            return Contar("SELECT COUNT(*) FROM Cliente");
        }

        public static int ContarClientesNuevos(DateTime desde, DateTime hasta)
        {
            return Contar("SELECT COUNT(*) FROM Cliente c JOIN Persona p ON p.idPersona = c.idPersona " +
                          "WHERE p.fechaAlta >= @desde AND p.fechaAlta < @hasta", desde, hasta);
        }

        public static int ContarVehiculos()
        {
            return Contar("SELECT COUNT(*) FROM Vehiculo");
        }

        public static int ContarPolizasContratadas(DateTime desde, DateTime hasta)
        {
            return Contar("SELECT COUNT(*) FROM Poliza WHERE idCliente IS NOT NULL AND fechaInicio >= @desde AND fechaInicio < @hasta", desde, hasta);
        }

        public static int ContarPolizasDeBaja()
        {
            return Contar("SELECT COUNT(*) FROM Poliza WHERE idCliente IS NOT NULL AND estado = 'Baja'");
        }

        public static int ContarReclamos(DateTime desde, DateTime hasta)
        {
            return Contar("SELECT COUNT(*) FROM Siniestro WHERE fechaRegistro >= @desde AND fechaRegistro < @hasta", desde, hasta);
        }

        public static int ContarReclamosAprobados(DateTime desde, DateTime hasta)
        {
            return Contar("SELECT COUNT(*) FROM Siniestro WHERE estado = 'Aprobado' AND fechaRegistro >= @desde AND fechaRegistro < @hasta", desde, hasta);
        }

        public static int ContarReclamosRechazados(DateTime desde, DateTime hasta)
        {
            return Contar("SELECT COUNT(*) FROM Siniestro WHERE estado = 'Rechazado' AND fechaRegistro >= @desde AND fechaRegistro < @hasta", desde, hasta);
        }

        public static int ContarReclamosAtendidos(DateTime desde, DateTime hasta)
        {
            return Contar("SELECT COUNT(*) FROM Siniestro WHERE idEmpleado IS NOT NULL AND fechaRegistro >= @desde AND fechaRegistro < @hasta", desde, hasta);
        }

        public static int ContarEmpleadosHabilitados()
        {
            return Contar("SELECT COUNT(*) FROM Empleado e JOIN Persona p ON p.idPersona = e.idPersona " +
                          "WHERE e.estado = 'Habilitado' AND p.estado = 'Activo'");
        }

        public static int ContarUsuariosActivos()
        {
            return Contar("SELECT COUNT(*) FROM Persona WHERE estado = 'Activo'");
        }

        public static int ContarAcciones(DateTime desde, DateTime hasta)
        {
            return Contar("SELECT COUNT(*) FROM Accion WHERE fecha >= @desde AND fecha < @hasta", desde, hasta);
        }

        public static decimal SumarCobrado(DateTime desde, DateTime hasta)
        {
            return Sumar("SELECT SUM(monto) FROM Pago WHERE estadoPago = 1 AND fechaPago >= @desde AND fechaPago < @hasta", desde, hasta);
        }

        // Misma regla que Comisiones: % de la póliza sobre cada cuota cobrada en el período
        public static decimal SumarComision(DateTime desde, DateTime hasta)
        {
            return Sumar("SELECT SUM(pa.monto * po.comision / 100) FROM Pago pa " +
                         "JOIN Poliza po ON po.nroPoliza = pa.idPoliza " +
                         "WHERE pa.estadoPago = 1 AND pa.fechaPago >= @desde AND pa.fechaPago < @hasta", desde, hasta);
        }

        public static decimal SumarDeudaVencida()
        {
            return Sumar("SELECT SUM(monto) FROM Pago WHERE estadoPago = 0 AND fechaVencimiento < " + hoy, DateTime.Today, DateTime.Today);
        }

        public static decimal SumarMontoReclamado(DateTime desde, DateTime hasta)
        {
            return Sumar("SELECT SUM(montoReclamado) FROM Siniestro WHERE fechaRegistro >= @desde AND fechaRegistro < @hasta", desde, hasta);
        }

        // ================= Agrupados (Detalle, Cantidad, Monto) =================

        public static List<FilaReporte> CobradoPorMes(DateTime desde, DateTime hasta)
        {
            return Agrupar("SELECT RIGHT(mes, 2) + '/' + LEFT(mes, 4), cantidad, monto FROM (" +
                           "SELECT CONVERT(CHAR(7), fechaPago, 120) AS mes, COUNT(*) AS cantidad, SUM(monto) AS monto FROM Pago " +
                           "WHERE estadoPago = 1 AND fechaPago >= @desde AND fechaPago < @hasta " +
                           "GROUP BY CONVERT(CHAR(7), fechaPago, 120)) m ORDER BY mes", desde, hasta, true);
        }

        public static List<FilaReporte> CobradoPorMetodo(DateTime desde, DateTime hasta)
        {
            return Agrupar("SELECT metodoPago, COUNT(*), SUM(monto) FROM Pago " +
                           "WHERE estadoPago = 1 AND fechaPago >= @desde AND fechaPago < @hasta " +
                           "GROUP BY metodoPago ORDER BY SUM(monto) DESC", desde, hasta, true);
        }

        public static List<FilaReporte> PolizasPorEstado()
        {
            return Agrupar("SELECT estado, COUNT(*), 0 FROM (" +
                           "SELECT CASE WHEN estado = 'Baja' THEN 'Dadas de baja' " +
                           "WHEN fechaVencimiento < " + hoy + " THEN 'Vencidas' " +
                           "WHEN fechaVencimiento <= DATEADD(DAY, 30, " + hoy + ") THEN 'Por vencer' " +
                           "ELSE 'Vigentes' END AS estado " +
                           "FROM Poliza WHERE idCliente IS NOT NULL) e GROUP BY estado ORDER BY COUNT(*) DESC", DateTime.Today, DateTime.Today, false);
        }

        public static List<FilaReporte> PolizasPorCobertura()
        {
            return Agrupar("SELECT tipoCobertura, COUNT(*), 0 FROM Poliza WHERE idCliente IS NOT NULL AND estado = 'Vigente' " +
                           "GROUP BY tipoCobertura ORDER BY COUNT(*) DESC", DateTime.Today, DateTime.Today, false);
        }

        public static List<FilaReporte> PolizasPorAseguradora()
        {
            return Agrupar("SELECT pr.nombre, COUNT(*), 0 FROM Poliza po JOIN Proveedor pr ON pr.idProveedor = po.idProveedor " +
                           "WHERE po.idCliente IS NOT NULL AND po.estado = 'Vigente' " +
                           "GROUP BY pr.nombre ORDER BY COUNT(*) DESC", DateTime.Today, DateTime.Today, false);
        }

        public static List<FilaReporte> ReclamosPorEstado(DateTime desde, DateTime hasta)
        {
            return Agrupar("SELECT estado, COUNT(*), SUM(montoReclamado) FROM Siniestro " +
                           "WHERE fechaRegistro >= @desde AND fechaRegistro < @hasta " +
                           "GROUP BY estado ORDER BY COUNT(*) DESC", desde, hasta, true);
        }

        public static List<FilaReporte> ReclamosPorTipo(DateTime desde, DateTime hasta)
        {
            return Agrupar("SELECT tipoSiniestro, COUNT(*), SUM(montoReclamado) FROM Siniestro " +
                           "WHERE fechaRegistro >= @desde AND fechaRegistro < @hasta " +
                           "GROUP BY tipoSiniestro ORDER BY COUNT(*) DESC", desde, hasta, true);
        }

        public static List<FilaReporte> ClientesPorProvincia()
        {
            return Agrupar("SELECT d.provincia, COUNT(*), 0 FROM Cliente c " +
                           "JOIN Persona p ON p.idPersona = c.idPersona " +
                           "JOIN Direccion d ON d.idDireccion = p.idDireccion " +
                           "GROUP BY d.provincia ORDER BY COUNT(*) DESC", DateTime.Today, DateTime.Today, false);
        }

        public static List<FilaReporte> VehiculosPorTipo()
        {
            return Agrupar("SELECT tipoVehiculo, COUNT(*), 0 FROM Vehiculo GROUP BY tipoVehiculo ORDER BY COUNT(*) DESC", DateTime.Today, DateTime.Today, false);
        }

        public static List<FilaReporte> ReclamosPorEmpleado(DateTime desde, DateTime hasta)
        {
            return Agrupar("SELECT p.apellido + ', ' + p.nombre, COUNT(*), SUM(s.montoReclamado) FROM Siniestro s " +
                           "JOIN Empleado e ON e.idEmpleado = s.idEmpleado " +
                           "JOIN Persona p ON p.idPersona = e.idPersona " +
                           "WHERE s.fechaRegistro >= @desde AND s.fechaRegistro < @hasta " +
                           "GROUP BY p.apellido, p.nombre ORDER BY COUNT(*) DESC", desde, hasta, true);
        }

        public static List<FilaReporte> AccionesPorModulo(DateTime desde, DateTime hasta)
        {
            return Agrupar("SELECT modulo, COUNT(*), 0 FROM Accion WHERE fecha >= @desde AND fecha < @hasta " +
                           "GROUP BY modulo ORDER BY COUNT(*) DESC", desde, hasta, false);
        }

        // ================= Consultas =================

        private static int Contar(string query)
        {
            return Contar(query, DateTime.Today, DateTime.Today);
        }

        private static int Contar(string query, DateTime desde, DateTime hasta)
        {
            return Convert.ToInt32(Escalar(query, desde, hasta));
        }

        private static decimal Sumar(string query, DateTime desde, DateTime hasta)
        {
            return Escalar(query, desde, hasta);
        }

        // El resultado de una consulta de un solo valor. SUM sin filas devuelve NULL: vale 0.
        private static decimal Escalar(string query, DateTime desde, DateTime hasta)
        {
            decimal valor = 0;

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@desde", desde.Date);
                sql.Parameters.AddWithValue("@hasta", hasta.Date.AddDays(1));

                object resultado = sql.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    valor = Convert.ToDecimal(resultado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return valor;
        }

        private static List<FilaReporte> Agrupar(string query, DateTime desde, DateTime hasta, bool tieneMonto)
        {
            List<FilaReporte> lista = new List<FilaReporte>();

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@desde", desde.Date);
                sql.Parameters.AddWithValue("@hasta", hasta.Date.AddDays(1));

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    FilaReporte item = new FilaReporte()
                    {
                        Detalle = leer.IsDBNull(0) ? "Sin dato" : leer.GetString(0),
                        Cantidad = leer.GetInt32(1),
                        Monto = leer.IsDBNull(2) ? 0 : Convert.ToDecimal(leer.GetValue(2)),
                        TieneMonto = tieneMonto
                    };
                    lista.Add(item);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return lista;
        }
    }
}
