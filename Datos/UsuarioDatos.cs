using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Consultas de usuarios (Persona, con su dirección, contacto y perfil). Para leer uso la vista vw_Usuarios,
    // que ya me dice el perfil de cada persona. Todos los métodos siguen el mismo esquema: abro la conexión, armo el SqlCommand con parámetros (@...), leo o ejecuto, y en el finally cierro la conexión.
    internal class UsuarioDatos
    {
        // Busco al usuario por DNI y devuelvo también su hash y su sal guardados.
        // La contraseña no la comparo acá: para calcular el hash necesito primero la sal, y eso lo hace Negocio.
        // Si no existe nadie con ese DNI devuelvo null.
        public static Persona BuscarParaLogin(int dni, out string contrasenaHash, out string sal)
        {
            Persona usuario = null;
            contrasenaHash = "";
            sal = "";

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT legajo, nombre, apellido, dni, estado, perfil, estadoEmpleado, contrasena, sal " +
                               "FROM vw_Usuarios WHERE dni = @dni";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@dni", dni);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    usuario = new Persona()
                    {
                        Legajo = leer.GetInt32(0),
                        Nombre = leer.GetString(1),
                        Apellido = leer.GetString(2),
                        Dni = leer.GetInt32(3),
                        Estado = leer.GetString(4),
                        Perfil = leer.GetString(5),
                        EstadoEmpleado = leer.IsDBNull(6) ? "" : leer.GetString(6)
                    };
                    contrasenaHash = leer.GetString(7);
                    sal = leer.GetString(8);
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

            return usuario;
        }

        // Cuento cuántas personas hay registradas (de cualquier perfil).
        // Si no me puedo conectar devuelvo -1, así no confundo "sin conexión" con "base vacía".
        public static int ContarUsuarios()
        {
            int cantidad = -1;

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand("SELECT COUNT(*) FROM Persona", conexion.AbrirConexion());
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

        // true si otra persona (distinta de legajoActual) ya tiene ese DNI. Para un usuario nuevo paso 0
        public static bool ExisteDni(int dni, int legajoActual)
        {
            bool existe = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT COUNT(*) FROM Persona WHERE dni = @dni AND idPersona <> @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@dni", dni);
                sql.Parameters.AddWithValue("@legajo", legajoActual);

                if (Convert.ToInt32(sql.ExecuteScalar()) > 0)
                {
                    existe = true;
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

            return existe;
        }

        // Lista para la grilla. Si "buscar" tiene texto, filtro por legajo, DNI o apellido.
        // soloClientes: el empleado no ve a otros empleados ni a los administradores
        public static List<Persona> ListarUsuarios(string buscar, bool soloClientes)
        {
            List<Persona> lista = new List<Persona>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT legajo, nombre, apellido, dni, perfil, estado FROM vw_Usuarios " +
                               "WHERE (@soloClientes = 0 OR perfil = 'Cliente') " +
                               "AND (@buscar = '' " +
                               "OR legajo = TRY_CAST(@buscar AS INT) " +
                               "OR CAST(dni AS VARCHAR(10)) LIKE @buscar + '%' " +
                               "OR apellido LIKE '%' + @buscar + '%') " +
                               "ORDER BY legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@buscar", buscar);
                sql.Parameters.AddWithValue("@soloClientes", soloClientes);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Persona item = new Persona()
                    {
                        Legajo = leer.GetInt32(0),
                        Nombre = leer.GetString(1),
                        Apellido = leer.GetString(2),
                        Dni = leer.GetInt32(3),
                        Perfil = leer.GetString(4),
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

        // Traigo todos los datos de un usuario (Persona + Direccion + Contacto + perfil)
        public static Persona BuscarPorLegajo(int legajo)
        {
            Persona usuario = null;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT p.idPersona, p.nombre, p.apellido, p.dni, p.fechaNacimiento, " +
                               "d.calle, d.ciudad, d.provincia, c.telefono, c.email, " +
                               "p.fechaAlta, p.fechaBaja, p.estado, u.perfil, p.observacionBaja, a.matriculaAgente " +
                               "FROM Persona p " +
                               "JOIN Direccion d ON d.idDireccion = p.idDireccion " +
                               "JOIN Contacto c ON c.idContacto = p.idContacto " +
                               "JOIN vw_Usuarios u ON u.legajo = p.idPersona " +
                               "LEFT JOIN Administrador a ON a.idPersona = p.idPersona " +
                               "WHERE p.idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    usuario = new Persona()
                    {
                        Legajo = leer.GetInt32(0),
                        Nombre = leer.GetString(1),
                        Apellido = leer.GetString(2),
                        Dni = leer.GetInt32(3),
                        FechaNacimiento = leer.GetDateTime(4),
                        Direccion = leer.GetString(5),
                        Ciudad = leer.GetString(6),
                        Provincia = leer.GetString(7),
                        Telefono = leer.IsDBNull(8) ? "" : leer.GetString(8),
                        Email = leer.IsDBNull(9) ? "" : leer.GetString(9),
                        FechaAlta = leer.GetDateTime(10),
                        FechaBaja = leer.IsDBNull(11) ? (DateTime?)null : leer.GetDateTime(11),
                        Estado = leer.GetString(12),
                        Perfil = leer.GetString(13),
                        ObservacionBaja = leer.IsDBNull(14) ? "" : leer.GetString(14),
                        Matricula = leer.IsDBNull(15) ? "" : leer.GetString(15)
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

            return usuario;
        }

        // Alta de un usuario con el procedimiento sp_CrearUsuario (con usuario.Perfil sabe en qué tabla va).
        // Devuelvo el legajo nuevo, o 0 si no se pudo guardar
        public static int CrearUsuario(Persona usuario, string contrasenaHash, string sal)
        {
            int legajo = 0;

            Conexion conexion = new Conexion();

            try
            {
                legajo = CrearUsuario(conexion.AbrirConexion(), null, usuario, contrasenaHash, sal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return legajo;
        }

        // Lo mismo, pero con una conexión y transacción que ya vienen abiertas (lo usa el Alta en oficina)
        public static int CrearUsuario(SqlConnection con, SqlTransaction transaccion, Persona usuario, string contrasenaHash, string sal)
        {
            SqlCommand sql = new SqlCommand("sp_CrearUsuario", con, transaccion);
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@perfil", usuario.Perfil);
            sql.Parameters.AddWithValue("@nombre", usuario.Nombre);
            sql.Parameters.AddWithValue("@apellido", usuario.Apellido);
            sql.Parameters.AddWithValue("@contrasena", contrasenaHash);
            sql.Parameters.AddWithValue("@sal", sal);
            sql.Parameters.AddWithValue("@dni", usuario.Dni);
            sql.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            sql.Parameters.AddWithValue("@calle", usuario.Direccion);
            sql.Parameters.AddWithValue("@ciudad", usuario.Ciudad);
            sql.Parameters.AddWithValue("@provincia", usuario.Provincia);
            sql.Parameters.AddWithValue("@telefono", usuario.Telefono);
            sql.Parameters.AddWithValue("@email", usuario.Email);
            sql.Parameters.AddWithValue("@matricula", (object)usuario.Matricula ?? DBNull.Value);

            return Convert.ToInt32(sql.ExecuteScalar());
        }

        // Busco un cliente por DNI; null si no hay ningún cliente con ese DNI
        public static Persona BuscarClientePorDni(int dni)
        {
            int legajo = 0;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT legajo FROM vw_Usuarios WHERE dni = @dni AND perfil = 'Cliente'";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@dni", dni);

                object resultado = sql.ExecuteScalar();
                if (resultado != null)
                {
                    legajo = Convert.ToInt32(resultado);
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

            return legajo == 0 ? null : BuscarPorLegajo(legajo);
        }

        // Modifico los datos personales con sp_EditarUsuario (toca Persona, Direccion y Contacto juntas)
        public static bool EditarUsuario(Persona usuario)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand("sp_EditarUsuario", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@legajo", usuario.Legajo);
                sql.Parameters.AddWithValue("@nombre", usuario.Nombre);
                sql.Parameters.AddWithValue("@apellido", usuario.Apellido);
                sql.Parameters.AddWithValue("@dni", usuario.Dni);
                sql.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                sql.Parameters.AddWithValue("@calle", usuario.Direccion);
                sql.Parameters.AddWithValue("@ciudad", usuario.Ciudad);
                sql.Parameters.AddWithValue("@provincia", usuario.Provincia);
                sql.Parameters.AddWithValue("@telefono", usuario.Telefono);
                sql.Parameters.AddWithValue("@email", usuario.Email);
                sql.Parameters.AddWithValue("@matricula", (object)usuario.Matricula ?? DBNull.Value);

                sql.ExecuteNonQuery();
                estado = true;
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

        // Cambio entre Activo y Suspendido. No toca la fecha de baja
        public static bool CambiarEstado(int legajo, string nuevoEstado)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Persona SET estado = @estado WHERE idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@estado", nuevoEstado);
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

        // Baja definitiva: guardo el estado, la fecha de baja y el motivo
        public static bool DarDeBaja(int legajo, string motivo)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Persona SET estado = 'Baja', fechaBaja = GETDATE(), observacionBaja = @motivo " +
                               "WHERE idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@motivo", motivo);
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

        // Guardo el hash nuevo junto con su sal (cada vez que cambia la contraseña cambia también la sal)
        public static bool CambiarContrasena(int legajo, string contrasenaHash, string sal)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Persona SET contrasena = @contrasena, sal = @sal WHERE idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@contrasena", contrasenaHash);
                sql.Parameters.AddWithValue("@sal", sal);
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
    }
}
