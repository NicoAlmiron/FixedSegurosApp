using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Consultas de la pantalla Inicio. Con legajo = 0 cuentan todo; con un legajo, solo lo de ese cliente.
    internal class InicioDatos
    {
        private const string deCliente = "(@legajo = 0 OR c.idPersona = @legajo)";

        public static int ContarPolizasVigentes(int legajo)
        {
            return Contar("SELECT COUNT(*) FROM Poliza po JOIN Cliente c ON c.idCliente = po.idCliente " +
                          "WHERE po.estado = 'Vigente' AND po.fechaVencimiento >= CAST(GETDATE() AS DATE) AND " + deCliente, legajo);
        }

        public static int ContarPorVencer(int legajo)
        {
            return Contar("SELECT COUNT(*) FROM Poliza po JOIN Cliente c ON c.idCliente = po.idCliente " +
                          "WHERE po.estado = 'Vigente' AND po.fechaVencimiento >= CAST(GETDATE() AS DATE) " +
                          "AND po.fechaVencimiento <= DATEADD(DAY, 30, CAST(GETDATE() AS DATE)) AND " + deCliente, legajo);
        }

        public static int ContarCuotasImpagas(int legajo)
        {
            return Contar("SELECT COUNT(*) FROM Pago pa " +
                          "JOIN Poliza po ON po.nroPoliza = pa.idPoliza " +
                          "JOIN Cliente c ON c.idCliente = po.idCliente " +
                          "WHERE pa.estadoPago = 0 AND pa.fechaVencimiento < CAST(GETDATE() AS DATE) AND " + deCliente, legajo);
        }

        public static int ContarAseguradoras()
        {
            return Contar("SELECT COUNT(*) FROM Proveedor WHERE activo = 1", 0);
        }

        public static int ContarSiniestrosPendientes()
        {
            return Contar("SELECT COUNT(*) FROM Siniestro WHERE estado = 'Pendiente'", 0);
        }

        public static int ContarVehiculosPendientes()
        {
            return Contar("SELECT COUNT(*) FROM Vehiculo WHERE estadoRevision = 'Pendiente'", 0);
        }

        public static int ContarReclamosAbiertos(int legajo)
        {
            return Contar("SELECT COUNT(*) FROM Siniestro s " +
                          "JOIN Poliza po ON po.nroPoliza = s.idPoliza " +
                          "JOIN Cliente c ON c.idCliente = po.idCliente " +
                          "WHERE s.estado NOT IN ('Aprobado', 'Rechazado') AND " + deCliente, legajo);
        }

        // La primera cuota sin pagar del cliente, o null si no debe ninguna
        public static Pago BuscarProximaCuota(int legajo)
        {
            Pago cuota = null;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT TOP 1 pa.monto, pa.fechaVencimiento FROM Pago pa " +
                               "JOIN Poliza po ON po.nroPoliza = pa.idPoliza " +
                               "JOIN Cliente c ON c.idCliente = po.idCliente " +
                               "WHERE pa.estadoPago = 0 AND c.idPersona = @legajo " +
                               "ORDER BY pa.fechaVencimiento";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    cuota = new Pago()
                    {
                        Monto = leer.GetDecimal(0),
                        FechaVencimiento = leer.GetDateTime(1)
                    };
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

            return cuota;
        }

        // Pólizas vigentes que vencen en 30 días o menos, o con cuotas vencidas sin pagar.
        // Las dadas de baja también entran si deben cuotas. idProveedor = 0 trae todas las aseguradoras.
        public static List<AlertaPoliza> ListarAlertas(int legajo, int idProveedor)
        {
            List<AlertaPoliza> lista = new List<AlertaPoliza>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM (" +
                               "SELECT po.nroPoliza, p.apellido + ', ' + p.nombre AS cliente, v.dominio, pr.nombre AS aseguradora, po.fechaVencimiento, " +
                               "(SELECT COUNT(*) FROM Pago WHERE idPoliza = po.nroPoliza AND estadoPago = 0 " +
                               "AND fechaVencimiento < CAST(GETDATE() AS DATE)) AS cuotasVencidas " +
                               "FROM Poliza po " +
                               "JOIN Cliente c ON c.idCliente = po.idCliente " +
                               "JOIN Persona p ON p.idPersona = c.idPersona " +
                               "JOIN Vehiculo v ON v.idVehiculo = po.idVehiculo " +
                               "JOIN Proveedor pr ON pr.idProveedor = po.idProveedor " +
                               "WHERE " + deCliente + " AND (@proveedor = 0 OR po.idProveedor = @proveedor) " +
                               "AND (po.estado = 'Vigente' OR po.estado = 'Baja')" +
                               ") a " +
                               "WHERE a.cuotasVencidas > 0 OR a.fechaVencimiento BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(DAY, 30, CAST(GETDATE() AS DATE)) " +
                               "ORDER BY a.fechaVencimiento";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);
                sql.Parameters.AddWithValue("@proveedor", idProveedor);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    AlertaPoliza item = new AlertaPoliza()
                    {
                        NroPoliza = leer.GetInt32(0),
                        Cliente = leer.GetString(1),
                        Dominio = leer.GetString(2),
                        Aseguradora = leer.GetString(3),
                        Vence = leer.GetDateTime(4),
                        CuotasVencidas = leer.GetInt32(5)
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

        private static int Contar(string query, int legajo)
        {
            int cantidad = 0;

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                cantidad = Convert.ToInt32(sql.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return cantidad;
        }
    }
}
