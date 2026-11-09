using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Consultas del historial de acciones (tabla Accion). Cada operación importante del sistema deja una fila acá.
    // Todos los métodos siguen el mismo esquema: abro la conexión, armo el SqlCommand con parámetros (@...), leo o ejecuto, y en el finally cierro la conexión.
    internal class AccionDatos
    {
        // Guardo una fila en el historial: quién, en qué módulo, qué hizo y un detalle. La fecha la pone la base
        public static bool RegistrarAccion(int idPersona, string modulo, string accion, string detalle)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "INSERT INTO Accion (idPersona, modulo, accion, detalle) VALUES (@idPersona, @modulo, @accion, @detalle)";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@idPersona", idPersona);
                sql.Parameters.AddWithValue("@modulo", modulo);
                sql.Parameters.AddWithValue("@accion", accion);
                sql.Parameters.AddWithValue("@detalle", detalle);

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

        // Traigo todo lo que hizo un usuario (para la pestaña Historial del detalle del cliente y del empleado)
        public static List<Accion> ListarAccionesDeUsuario(int legajo)
        {
            List<Accion> lista = new List<Accion>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT a.fecha, u.apellido + ', ' + u.nombre, u.perfil, a.modulo, a.accion, a.detalle " +
                               "FROM Accion a JOIN vw_Usuarios u ON u.legajo = a.idPersona " +
                               "WHERE a.idPersona = @legajo ORDER BY a.fecha DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Accion item = new Accion()
                    {
                        Fecha = leer.GetDateTime(0),
                        Usuario = leer.GetString(1),
                        Perfil = leer.GetString(2),
                        Modulo = leer.GetString(3),
                        Operacion = leer.GetString(4),
                        Detalle = leer.IsDBNull(5) ? "" : leer.GetString(5)
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

        // Historial con filtros. usuario = legajo o apellido ("" = todos), modulo = "Todos" o un módulo.
        // Al "hasta" le sumo un día para que entre todo el último día
        public static List<Accion> ListarAcciones(string usuario, string modulo, DateTime desde, DateTime hasta)
        {
            List<Accion> lista = new List<Accion>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT a.fecha, u.apellido + ', ' + u.nombre, u.perfil, a.modulo, a.accion, a.detalle " +
                               "FROM Accion a JOIN vw_Usuarios u ON u.legajo = a.idPersona " +
                               "WHERE a.fecha >= @desde AND a.fecha < @hasta " +
                               "AND (@modulo = 'Todos' OR a.modulo = @modulo) " +
                               "AND (@usuario = '' OR u.legajo = TRY_CAST(@usuario AS INT) OR u.apellido LIKE '%' + @usuario + '%') " +
                               "ORDER BY a.fecha DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@desde", desde.Date);
                sql.Parameters.AddWithValue("@hasta", hasta.Date.AddDays(1));   // incluye todo el dia "hasta"
                sql.Parameters.AddWithValue("@modulo", modulo);
                sql.Parameters.AddWithValue("@usuario", usuario);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Accion item = new Accion()
                    {
                        Fecha = leer.GetDateTime(0),
                        Usuario = leer.GetString(1),
                        Perfil = leer.GetString(2),
                        Modulo = leer.GetString(3),
                        Operacion = leer.GetString(4),
                        Detalle = leer.IsDBNull(5) ? "" : leer.GetString(5)
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
