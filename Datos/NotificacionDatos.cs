using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    internal class NotificacionDatos
    {
        // Columnas que usan los listados (en el mismo orden que LeerNotificacion)
        private const string columnas = "SELECT n.idNotificacion, n.fechaEnvio, n.mensaje, n.tipo, n.leida, " +
                                        "ISNULL(n.nroPoliza, 0), p.apellido + ', ' + p.nombre, p.idPersona " +
                                        "FROM Notificacion n " +
                                        "JOIN Cliente c ON c.idCliente = n.idCliente " +
                                        "JOIN Persona p ON p.idPersona = c.idPersona ";

        // Crea los avisos que falten de pólizas por vencer y cuotas vencidas.
        // Si falla no pasa nada: se vuelve a intentar en el próximo inicio de sesión.
        public static void GenerarNotificaciones()
        {
            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand("sp_GenerarNotificaciones", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Los avisos de un cliente
        public static List<Notificacion> ListarDeCliente(int legajoCliente)
        {
            List<Notificacion> lista = new List<Notificacion>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE c.idPersona = @legajo ORDER BY n.idNotificacion DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerNotificacion(leer));
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

        // Los avisos de todos los clientes (empleado)
        public static List<Notificacion> ListarTodas()
        {
            List<Notificacion> lista = new List<Notificacion>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "ORDER BY n.idNotificacion DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerNotificacion(leer));
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

        // Lo que el empleado tiene para evaluar. No se guarda: al resolverlo deja de aparecer.
        public static List<Notificacion> ListarPendientes()
        {
            List<Notificacion> lista = new List<Notificacion>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT 'Siniestro por evaluar' AS tipo, " +
                               "'El expediente ' + RIGHT('000000' + CAST(s.idSiniestro AS VARCHAR(10)), 6) + ' espera la verificación.', " +
                               "s.fechaRegistro, p.apellido + ', ' + p.nombre, p.idPersona, s.idPoliza, s.idSiniestro " +
                               "FROM Siniestro s " +
                               "JOIN Poliza po ON po.nroPoliza = s.idPoliza " +
                               "JOIN Cliente c ON c.idCliente = po.idCliente " +
                               "JOIN Persona p ON p.idPersona = c.idPersona " +
                               "WHERE s.estado = 'Pendiente' " +
                               "UNION ALL " +
                               "SELECT 'Vehículo por evaluar', 'El vehículo ' + v.dominio + ' espera la revisión.', " +
                               "NULL, p.apellido + ', ' + p.nombre, p.idPersona, 0, 0 " +
                               "FROM Vehiculo v " +
                               "JOIN Cliente c ON c.idCliente = v.idCliente " +
                               "JOIN Persona p ON p.idPersona = c.idPersona " +
                               "WHERE v.estadoRevision = 'Pendiente' " +
                               "ORDER BY tipo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Notificacion item = new Notificacion()
                    {
                        Tipo = leer.GetString(0),
                        Mensaje = leer.GetString(1),
                        FechaEnvio = leer.IsDBNull(2) ? (DateTime?)null : leer.GetDateTime(2),
                        Cliente = leer.GetString(3),
                        LegajoCliente = leer.GetInt32(4),
                        NroPoliza = leer.GetInt32(5),
                        IdSiniestro = leer.GetInt32(6)
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

        // Crea un aviso para el cliente dueño de la póliza
        public static bool CrearNotificacion(int nroPoliza, string tipo, string mensaje)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "INSERT INTO Notificacion (idCliente, mensaje, tipo, nroPoliza) " +
                               "SELECT idCliente, @mensaje, @tipo, nroPoliza FROM Poliza " +
                               "WHERE nroPoliza = @nro AND idCliente IS NOT NULL";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@mensaje", mensaje);
                sql.Parameters.AddWithValue("@tipo", tipo);
                sql.Parameters.AddWithValue("@nro", nroPoliza);

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

        // El cliente solo puede marcar las suyas (la condición está en el WHERE)
        public static bool MarcarLeida(int idNotificacion, int legajoCliente)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE n SET n.leida = 1 " +
                               "FROM Notificacion n " +
                               "JOIN Cliente c ON c.idCliente = n.idCliente " +
                               "WHERE n.idNotificacion = @id AND c.idPersona = @legajo AND n.leida = 0";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idNotificacion);
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

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

        public static int ContarSinLeerCliente(int legajoCliente)
        {
            int cantidad = 0;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT COUNT(*) FROM Notificacion n " +
                               "JOIN Cliente c ON c.idCliente = n.idCliente " +
                               "WHERE c.idPersona = @legajo AND n.leida = 0";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

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

        public static int ContarPendientes()
        {
            int cantidad = 0;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT (SELECT COUNT(*) FROM Siniestro WHERE estado = 'Pendiente') + " +
                               "(SELECT COUNT(*) FROM Vehiculo WHERE estadoRevision = 'Pendiente')";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

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

        private static Notificacion LeerNotificacion(SqlDataReader leer)
        {
            Notificacion notificacion = new Notificacion()
            {
                IdNotificacion = leer.GetInt32(0),
                FechaEnvio = leer.GetDateTime(1),
                Mensaje = leer.GetString(2),
                Tipo = leer.GetString(3),
                Leida = leer.GetBoolean(4),
                NroPoliza = leer.GetInt32(5),
                Cliente = leer.GetString(6),
                LegajoCliente = leer.GetInt32(7)
            };
            return notificacion;
        }
    }
}
