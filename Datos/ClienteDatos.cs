using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Consultas del "Detalle del cliente". Todas buscan por el legajo (idPersona) del cliente.
    internal class ClienteDatos
    {
        public static string BuscarObservaciones(int legajo)
        {
            string observaciones = "";

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT observaciones FROM Cliente WHERE idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                object resultado = sql.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    observaciones = resultado.ToString();
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

            return observaciones;
        }

        public static bool GuardarObservaciones(int legajo, string observaciones)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Cliente SET observaciones = @observaciones WHERE idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@observaciones", observaciones == "" ? (object)DBNull.Value : observaciones);
                sql.Parameters.AddWithValue("@legajo", legajo);

                if (sql.ExecuteNonQuery() > 0)
                {
                    estado = true;
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

            return estado;
        }

        public static List<Poliza> ListarPolizas(int legajo)
        {
            List<Poliza> lista = new List<Poliza>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT po.nroPoliza, pr.nombre, v.dominio, po.tipoCobertura, po.fechaInicio, po.fechaVencimiento, po.estado " +
                               "FROM Poliza po " +
                               "JOIN Proveedor pr ON pr.idProveedor = po.idProveedor " +
                               "JOIN Cliente c ON c.idCliente = po.idCliente " +
                               "LEFT JOIN Vehiculo v ON v.idVehiculo = po.idVehiculo " +
                               "WHERE c.idPersona = @legajo ORDER BY po.nroPoliza DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Poliza item = new Poliza()
                    {
                        NroPoliza = leer.GetInt32(0),
                        Aseguradora = leer.GetString(1),
                        Dominio = leer.IsDBNull(2) ? "" : leer.GetString(2),
                        TipoCobertura = leer.GetString(3),
                        FechaInicio = leer.IsDBNull(4) ? (DateTime?)null : leer.GetDateTime(4),
                        FechaVencimiento = leer.IsDBNull(5) ? (DateTime?)null : leer.GetDateTime(5),
                        Estado = leer.GetString(6)
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

        public static List<Pago> ListarPagos(int legajo)
        {
            List<Pago> lista = new List<Pago>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT pa.idPago, pa.idPoliza, pa.cuota, pa.fechaVencimiento, pa.monto, pa.fechaPago, pa.metodoPago, pa.estadoPago " +
                               "FROM Pago pa " +
                               "JOIN Poliza po ON po.nroPoliza = pa.idPoliza " +
                               "JOIN Cliente c ON c.idCliente = po.idCliente " +
                               "WHERE c.idPersona = @legajo ORDER BY pa.fechaVencimiento DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Pago item = new Pago()
                    {
                        IdPago = leer.GetInt32(0),
                        NroPoliza = leer.GetInt32(1),
                        Cuota = leer.GetInt32(2),
                        FechaVencimiento = leer.GetDateTime(3),
                        Monto = leer.GetDecimal(4),
                        FechaPago = leer.IsDBNull(5) ? (DateTime?)null : leer.GetDateTime(5),
                        MetodoPago = leer.IsDBNull(6) ? "" : leer.GetString(6),
                        Pagada = leer.GetBoolean(7)
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

        public static List<Siniestro> ListarSiniestros(int legajo)
        {
            List<Siniestro> lista = new List<Siniestro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT s.idSiniestro, s.idPoliza, s.fechaOcurrencia, s.tipoSiniestro, s.montoReclamado, s.estado " +
                               "FROM Siniestro s " +
                               "JOIN Poliza po ON po.nroPoliza = s.idPoliza " +
                               "JOIN Cliente c ON c.idCliente = po.idCliente " +
                               "WHERE c.idPersona = @legajo ORDER BY s.idSiniestro DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Siniestro item = new Siniestro()
                    {
                        IdSiniestro = leer.GetInt32(0),
                        NroPoliza = leer.GetInt32(1),
                        FechaOcurrencia = leer.GetDateTime(2),
                        TipoSiniestro = leer.GetString(3),
                        MontoReclamado = leer.GetDecimal(4),
                        Estado = leer.GetString(5)
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
