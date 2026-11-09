using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Consultas de vehículos y sus fotos. Reciben el legajo del cliente: así cada cliente solo ve y modifica SUS vehículos.
    // Empleados y administradores usan las mismas consultas pasando el legajo del cliente que están mirando.
    // Todos los métodos siguen el mismo esquema: abro la conexión, armo el SqlCommand con parámetros (@...), leo o ejecuto, y en el finally cierro la conexión.
    internal class VehiculoDatos
    {
        // Condición SQL de "servicio suspendido" para el vehículo (alias v): la misma regla que Vehiculo.ServicioSuspendido
        public const string Suspendido = "(v.vigenciaVtv < CAST(GETDATE() AS DATE) AND (v.fechaEnvioVtv IS NULL OR CAST(v.fechaEnvioVtv AS DATE) > v.vigenciaVtv))";

        // Nombre de la foto de la VTV nueva, que espera la revisión de un empleado
        public const string FotoVtvNueva = "VTV nueva";

        // Columnas que usan ListarVehiculos y BuscarPorId (mismo orden que LeerVehiculo)
        private const string columnas = "SELECT v.idVehiculo, v.dominio, v.marca, v.modelo, v.anio, v.tipoVehiculo, v.vigenciaVtv, " +
                                        "v.numeroChasis, v.numeroMotor, " +
                                        "ISNULL((SELECT TOP 1 nroPoliza FROM Poliza WHERE idVehiculo = v.idVehiculo AND estado = 'Vigente'), 0), " +
                                        "v.estadoRevision, v.observacionRevision, r.apellido + ', ' + r.nombre, v.fechaRevision, " +
                                        "v.vigenciaVtvNueva, v.fechaEnvioVtv, v.observacionVtv " +
                                        "FROM Vehiculo v " +
                                        "JOIN Cliente c ON c.idCliente = v.idCliente " +
                                        "LEFT JOIN Persona r ON r.idPersona = v.idRevisor ";

        // Los vehículos de un cliente
        public static List<Vehiculo> ListarVehiculos(int legajoCliente)
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE c.idPersona = @legajo ORDER BY v.dominio";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerVehiculo(leer));
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

        // Busco un vehículo; null si no existe o no es de ese cliente
        public static Vehiculo BuscarPorId(int idVehiculo, int legajoCliente)
        {
            Vehiculo vehiculo = null;

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE v.idVehiculo = @id AND c.idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idVehiculo);
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    vehiculo = LeerVehiculo(leer);
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

            return vehiculo;
        }

        // Las fotos de un vehículo. Las pido aparte porque pesan: solo cuando se elige un vehículo
        public static List<FotoVehiculo> ListarFotos(int idVehiculo)
        {
            List<FotoVehiculo> lista = new List<FotoVehiculo>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT posicion, imagen FROM FotoVehiculo WHERE idVehiculo = @id";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idVehiculo);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    FotoVehiculo foto = new FotoVehiculo()
                    {
                        Posicion = leer.GetString(0),
                        Imagen = (byte[])leer["imagen"]
                    };
                    lista.Add(foto);
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

        // true si otro vehículo (distinto de idActual) ya tiene ese dominio. Para uno nuevo paso 0
        public static bool ExisteDominio(string dominio, int idActual)
        {
            bool existe = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT COUNT(*) FROM Vehiculo WHERE dominio = @dominio AND idVehiculo <> @id";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@dominio", dominio);
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

        // Guardo el vehículo (queda Pendiente de revisión) y sus fotos en una transacción:
        // si algo falla no se guarda nada. Devuelvo el id nuevo, o 0 si no se pudo guardar
        public static int CrearVehiculo(Vehiculo vehiculo, List<FotoVehiculo> fotos, int legajoCliente)
        {
            int id = 0;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                id = InsertarVehiculo(con, transaccion, vehiculo, legajoCliente);

                GuardarFotos(con, transaccion, id, fotos);

                transaccion.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
                id = 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return id;
        }

        // Inserto el vehículo (Pendiente) con una conexión y transacción que ya vienen abiertas. Devuelvo el id nuevo
        public static int InsertarVehiculo(SqlConnection con, SqlTransaction transaccion, Vehiculo vehiculo, int legajoCliente)
        {
            string query = "INSERT INTO Vehiculo (dominio, marca, modelo, anio, tipoVehiculo, vigenciaVtv, numeroChasis, numeroMotor, idCliente) " +
                           "VALUES (@dominio, @marca, @modelo, @anio, @tipo, @vigencia, @chasis, @motor, " +
                           "(SELECT idCliente FROM Cliente WHERE idPersona = @legajo)); " +
                           "SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand sql = new SqlCommand(query, con, transaccion);
            CargarParametros(sql, vehiculo);
            sql.Parameters.AddWithValue("@legajo", legajoCliente);

            return Convert.ToInt32(sql.ExecuteScalar());
        }

        // Modifico el vehículo y reemplazo sus fotos; vuelve a quedar Pendiente de revisión.
        // No toco vehículos aprobados (la condición está en el WHERE)
        public static bool EditarVehiculo(Vehiculo vehiculo, List<FotoVehiculo> fotos, int legajoCliente)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "UPDATE Vehiculo SET dominio = @dominio, marca = @marca, modelo = @modelo, anio = @anio, " +
                               "tipoVehiculo = @tipo, vigenciaVtv = @vigencia, numeroChasis = @chasis, numeroMotor = @motor, " +
                               "estadoRevision = 'Pendiente', observacionRevision = NULL, idRevisor = NULL, fechaRevision = NULL " +
                               "WHERE idVehiculo = @id AND estadoRevision <> 'Aprobado' " +
                               "AND idCliente = (SELECT idCliente FROM Cliente WHERE idPersona = @legajo)";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                CargarParametros(sql, vehiculo);
                sql.Parameters.AddWithValue("@id", vehiculo.IdVehiculo);
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                if (sql.ExecuteNonQuery() > 0)
                {
                    SqlCommand borrar = new SqlCommand("DELETE FROM FotoVehiculo WHERE idVehiculo = @id", con, transaccion);
                    borrar.Parameters.AddWithValue("@id", vehiculo.IdVehiculo);
                    borrar.ExecuteNonQuery();

                    GuardarFotos(con, transaccion, vehiculo.IdVehiculo, fotos);

                    transaccion.Commit();
                    estado = true;
                }
                else
                {
                    transaccion.Rollback();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // Borro las fotos y el vehículo, en una transacción
        public static bool EliminarVehiculo(int idVehiculo, int legajoCliente)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "DELETE FROM FotoVehiculo WHERE idVehiculo = " +
                               "(SELECT v.idVehiculo FROM Vehiculo v JOIN Cliente c ON c.idCliente = v.idCliente " +
                               " WHERE v.idVehiculo = @id AND c.idPersona = @legajo); " +
                               "DELETE FROM Vehiculo " +
                               "WHERE idVehiculo = @id AND idCliente = (SELECT idCliente FROM Cliente WHERE idPersona = @legajo)";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@id", idVehiculo);
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                if (sql.ExecuteNonQuery() > 0)
                {
                    transaccion.Commit();
                    estado = true;
                }
                else
                {
                    transaccion.Rollback();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // Aprobado o Rechazado por un empleado o administrador. Solo reviso los que están Pendientes
        public static bool CambiarRevision(int idVehiculo, string estadoRevision, string observacion, int legajoRevisor)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                estado = CambiarRevision(conexion.AbrirConexion(), null, idVehiculo, estadoRevision, observacion, legajoRevisor);
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

        // Lo mismo, con una conexión y transacción que ya vienen abiertas (lo usa el Alta en oficina)
        public static bool CambiarRevision(SqlConnection con, SqlTransaction transaccion, int idVehiculo, string estadoRevision, string observacion, int legajoRevisor)
        {
            string query = "UPDATE Vehiculo SET estadoRevision = @estado, observacionRevision = @observacion, " +
                           "idRevisor = @revisor, fechaRevision = GETDATE() " +
                           "WHERE idVehiculo = @id AND estadoRevision = 'Pendiente'";

            SqlCommand sql = new SqlCommand(query, con, transaccion);
            sql.Parameters.AddWithValue("@estado", estadoRevision);
            sql.Parameters.AddWithValue("@observacion", observacion == "" ? (object)DBNull.Value : observacion);
            sql.Parameters.AddWithValue("@revisor", legajoRevisor);
            sql.Parameters.AddWithValue("@id", idVehiculo);

            return sql.ExecuteNonQuery() > 0;
        }

        // true si el vehículo figura en alguna póliza (vigente o no): en ese caso no se puede eliminar
        public static bool TienePolizas(int idVehiculo)
        {
            bool tiene = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT COUNT(*) FROM Poliza WHERE idVehiculo = @id";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idVehiculo);

                if (Convert.ToInt32(sql.ExecuteScalar()) > 0)
                {
                    tiene = true;
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

            return tiene;
        }

        // El cliente manda la VTV renovada: la vigencia y la foto quedan aparte hasta que un empleado las revise.
        // Solo vehículos aprobados y sin otra renovación en espera (la condición está en el WHERE)
        public static bool EnviarVtv(int idVehiculo, DateTime vigencia, byte[] foto, int legajoCliente)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "UPDATE Vehiculo SET vigenciaVtvNueva = @vigencia, fechaEnvioVtv = GETDATE(), observacionVtv = NULL " +
                               "WHERE idVehiculo = @id AND estadoRevision = 'Aprobado' AND vigenciaVtvNueva IS NULL " +
                               "AND idCliente = (SELECT idCliente FROM Cliente WHERE idPersona = @legajo)";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@vigencia", vigencia);
                sql.Parameters.AddWithValue("@id", idVehiculo);
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                if (sql.ExecuteNonQuery() > 0)
                {
                    List<FotoVehiculo> fotos = new List<FotoVehiculo>();
                    fotos.Add(new FotoVehiculo() { Posicion = FotoVtvNueva, Imagen = foto });
                    GuardarFotos(con, transaccion, idVehiculo, fotos);

                    transaccion.Commit();
                    estado = true;
                }
                else
                {
                    transaccion.Rollback();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // La renovación aprobada pasa a ser la VTV del vehículo: la foto nueva reemplaza a la anterior
        public static bool AprobarVtv(int idVehiculo, int legajoRevisor)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "UPDATE Vehiculo SET vigenciaVtv = vigenciaVtvNueva, vigenciaVtvNueva = NULL, fechaEnvioVtv = NULL, " +
                               "observacionVtv = NULL, idRevisor = @revisor, fechaRevision = GETDATE() " +
                               "WHERE idVehiculo = @id AND vigenciaVtvNueva IS NOT NULL";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@revisor", legajoRevisor);
                sql.Parameters.AddWithValue("@id", idVehiculo);

                if (sql.ExecuteNonQuery() > 0)
                {
                    query = "DELETE FROM FotoVehiculo WHERE idVehiculo = @id AND posicion = 'VTV'; " +
                            "UPDATE FotoVehiculo SET posicion = 'VTV' WHERE idVehiculo = @id AND posicion = @nueva";

                    sql = new SqlCommand(query, con, transaccion);
                    sql.Parameters.AddWithValue("@id", idVehiculo);
                    sql.Parameters.AddWithValue("@nueva", FotoVtvNueva);
                    sql.ExecuteNonQuery();

                    transaccion.Commit();
                    estado = true;
                }
                else
                {
                    transaccion.Rollback();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // La renovación rechazada se descarta y queda el motivo para que lo vea el cliente
        public static bool RechazarVtv(int idVehiculo, string motivo, int legajoRevisor)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "UPDATE Vehiculo SET vigenciaVtvNueva = NULL, fechaEnvioVtv = NULL, observacionVtv = @motivo, " +
                               "idRevisor = @revisor, fechaRevision = GETDATE() " +
                               "WHERE idVehiculo = @id AND vigenciaVtvNueva IS NOT NULL";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@motivo", motivo);
                sql.Parameters.AddWithValue("@revisor", legajoRevisor);
                sql.Parameters.AddWithValue("@id", idVehiculo);

                if (sql.ExecuteNonQuery() > 0)
                {
                    sql = new SqlCommand("DELETE FROM FotoVehiculo WHERE idVehiculo = @id AND posicion = @nueva", con, transaccion);
                    sql.Parameters.AddWithValue("@id", idVehiculo);
                    sql.Parameters.AddWithValue("@nueva", FotoVtvNueva);
                    sql.ExecuteNonQuery();

                    transaccion.Commit();
                    estado = true;
                }
                else
                {
                    transaccion.Rollback();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // Inserto cada foto con la misma conexión y transacción del vehículo. El tamaño -1 del parámetro significa VARBINARY(MAX)
        public static void GuardarFotos(SqlConnection con, SqlTransaction transaccion, int idVehiculo, List<FotoVehiculo> fotos)
        {
            foreach (FotoVehiculo foto in fotos)
            {
                SqlCommand sql = new SqlCommand("INSERT INTO FotoVehiculo (idVehiculo, posicion, imagen) VALUES (@id, @posicion, @imagen)", con, transaccion);
                sql.Parameters.AddWithValue("@id", idVehiculo);
                sql.Parameters.AddWithValue("@posicion", foto.Posicion);
                sql.Parameters.Add("@imagen", SqlDbType.VarBinary, -1).Value = foto.Imagen;   // -1 = VARBINARY(MAX)
                sql.ExecuteNonQuery();
            }
        }

        // Parámetros comunes del alta y la modificación del vehículo
        private static void CargarParametros(SqlCommand sql, Vehiculo vehiculo)
        {
            sql.Parameters.AddWithValue("@dominio", vehiculo.Dominio);
            sql.Parameters.AddWithValue("@marca", vehiculo.Marca);
            sql.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
            sql.Parameters.AddWithValue("@anio", vehiculo.Anio);
            sql.Parameters.AddWithValue("@tipo", vehiculo.TipoVehiculo);
            sql.Parameters.AddWithValue("@vigencia", vehiculo.VigenciaVtv);
            sql.Parameters.AddWithValue("@chasis", vehiculo.NumeroChasis);
            sql.Parameters.AddWithValue("@motor", vehiculo.NumeroMotor);
        }

        // Armo un Vehiculo con la fila que estoy leyendo
        private static Vehiculo LeerVehiculo(SqlDataReader leer)
        {
            Vehiculo vehiculo = new Vehiculo()
            {
                IdVehiculo = leer.GetInt32(0),
                Dominio = leer.GetString(1),
                Marca = leer.GetString(2),
                Modelo = leer.GetString(3),
                Anio = leer.GetInt32(4),
                TipoVehiculo = leer.GetString(5),
                VigenciaVtv = leer.GetDateTime(6),
                NumeroChasis = leer.IsDBNull(7) ? "" : leer.GetString(7),
                NumeroMotor = leer.IsDBNull(8) ? "" : leer.GetString(8),
                NroPoliza = leer.GetInt32(9),
                EstadoRevision = leer.GetString(10),
                ObservacionRevision = leer.IsDBNull(11) ? "" : leer.GetString(11),
                Revisor = leer.IsDBNull(12) ? "" : leer.GetString(12),
                FechaRevision = leer.IsDBNull(13) ? (DateTime?)null : leer.GetDateTime(13),
                VigenciaVtvNueva = leer.IsDBNull(14) ? (DateTime?)null : leer.GetDateTime(14),
                FechaEnvioVtv = leer.IsDBNull(15) ? (DateTime?)null : leer.GetDateTime(15),
                ObservacionVtv = leer.IsDBNull(16) ? "" : leer.GetString(16)
            };
            return vehiculo;
        }
    }
}
