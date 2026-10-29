using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    internal class ProveedorDatos
    {
        // Columnas que usan ListarProveedores y BuscarPorId (en el mismo orden que LeerProveedor)
        private const string columnas = "SELECT pr.idProveedor, pr.nombre, pr.registroSSN, pr.cuit, pr.tiposSeguro, pr.comision, " +
                                        "c.telefono, c.email, c.sitioWeb, d.calle, d.ciudad, d.provincia, pr.fechaAlta, pr.activo " +
                                        "FROM Proveedor pr " +
                                        "JOIN Direccion d ON d.idDireccion = pr.idDireccion " +
                                        "JOIN Contacto c ON c.idContacto = pr.idContacto ";

        // Lista para la grilla. Si "buscar" tiene texto, filtra por nombre, CUIT o registro SSN.
        public static List<Proveedor> ListarProveedores(string buscar)
        {
            List<Proveedor> lista = new List<Proveedor>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas +
                               "WHERE @buscar = '' " +
                               "OR pr.nombre LIKE '%' + @buscar + '%' " +
                               "OR REPLACE(pr.cuit, '-', '') LIKE REPLACE(@buscar, '-', '') + '%' " +
                               "OR pr.registroSSN LIKE @buscar + '%' " +
                               "ORDER BY pr.nombre";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@buscar", buscar);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerProveedor(leer));
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

        public static Proveedor BuscarPorId(int idProveedor)
        {
            Proveedor proveedor = null;

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE pr.idProveedor = @id";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idProveedor);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    proveedor = LeerProveedor(leer);
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

            return proveedor;
        }

        // Devuelve true si otra aseguradora (distinta de idActual) ya tiene ese CUIT. Para una nueva se pasa 0.
        public static bool ExisteCuit(string cuit, int idActual)
        {
            bool existe = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT COUNT(*) FROM Proveedor WHERE cuit = @cuit AND idProveedor <> @id";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@cuit", cuit);
                sql.Parameters.AddWithValue("@id", idActual);

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

        // Alta con sp_CrearProveedor. Devuelve el id nuevo, o 0 si no se pudo guardar.
        public static int CrearProveedor(Proveedor proveedor)
        {
            int id = 0;

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand("sp_CrearProveedor", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                CargarParametros(sql, proveedor);

                id = Convert.ToInt32(sql.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return id;
        }

        // Modificacion con sp_EditarProveedor
        public static bool EditarProveedor(Proveedor proveedor)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand("sp_EditarProveedor", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@idProveedor", proveedor.IdProveedor);
                CargarParametros(sql, proveedor);

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

        // Activa (true) o da de baja (false) a la aseguradora
        public static bool CambiarActivo(int idProveedor, bool activo)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Proveedor SET activo = @activo WHERE idProveedor = @id";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@activo", activo);
                sql.Parameters.AddWithValue("@id", idProveedor);

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

        // Parametros comunes de sp_CrearProveedor y sp_EditarProveedor
        private static void CargarParametros(SqlCommand sql, Proveedor proveedor)
        {
            sql.Parameters.AddWithValue("@nombre", proveedor.Nombre);
            sql.Parameters.AddWithValue("@registroSSN", proveedor.RegistroSSN);
            sql.Parameters.AddWithValue("@cuit", proveedor.Cuit);
            sql.Parameters.AddWithValue("@tiposSeguro", proveedor.TiposSeguro);
            sql.Parameters.AddWithValue("@comision", proveedor.Comision);
            sql.Parameters.AddWithValue("@calle", proveedor.Direccion);
            sql.Parameters.AddWithValue("@ciudad", proveedor.Ciudad);
            sql.Parameters.AddWithValue("@provincia", proveedor.Provincia);
            sql.Parameters.AddWithValue("@telefono", proveedor.Telefono);
            sql.Parameters.AddWithValue("@email", proveedor.Email);
            sql.Parameters.AddWithValue("@sitioWeb", proveedor.SitioWeb);
        }

        // Arma un Proveedor con la fila actual del lector
        private static Proveedor LeerProveedor(SqlDataReader leer)
        {
            Proveedor proveedor = new Proveedor()
            {
                IdProveedor = leer.GetInt32(0),
                Nombre = leer.GetString(1),
                RegistroSSN = leer.GetString(2),
                Cuit = leer.GetString(3),
                TiposSeguro = leer.IsDBNull(4) ? "" : leer.GetString(4),
                Comision = leer.GetDecimal(5),
                Telefono = leer.IsDBNull(6) ? "" : leer.GetString(6),
                Email = leer.IsDBNull(7) ? "" : leer.GetString(7),
                SitioWeb = leer.IsDBNull(8) ? "" : leer.GetString(8),
                Direccion = leer.GetString(9),
                Ciudad = leer.GetString(10),
                Provincia = leer.GetString(11),
                FechaAlta = leer.GetDateTime(12),
                Activo = leer.GetBoolean(13)
            };
            return proveedor;
        }
    }
}
