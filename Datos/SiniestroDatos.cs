using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Consultas de Siniestros (reclamos) y sus adjuntos.
    // Cada cambio pide en el WHERE el estado esperado: si otro usuario ya movió el reclamo, no piso nada.
    // Todos los métodos siguen el mismo esquema: abro la conexión, armo el SqlCommand con parámetros (@...), leo o ejecuto, y en el finally cierro la conexión.
    internal class SiniestroDatos
    {
        // Columnas que usan las consultas (mismo orden que LeerSiniestro).
        // Los adjuntos solo los cuento: los bytes los pido aparte con ListarAdjuntos porque pesan
        private const string columnas = "SELECT s.idSiniestro, s.idPoliza, s.fechaOcurrencia, s.fechaRegistro, s.tipoSiniestro, s.ubicacion, " +
                                        "s.descripcion, s.observaciones, s.resultado, s.estado, s.fechaResolucion, s.montoReclamado, " +
                                        "p.apellido + ', ' + p.nombre, v.dominio, r.apellido + ', ' + r.nombre, " +
                                        "(SELECT COUNT(*) FROM AdjuntoSiniestro WHERE idSiniestro = s.idSiniestro AND tipo = 'Foto'), " +
                                        "(SELECT COUNT(*) FROM AdjuntoSiniestro WHERE idSiniestro = s.idSiniestro AND tipo = 'Denuncia'), " +
                                        "(SELECT COUNT(*) FROM AdjuntoSiniestro WHERE idSiniestro = s.idSiniestro AND tipo = 'Formulario') " +
                                        "FROM Siniestro s " +
                                        "JOIN Poliza po ON po.nroPoliza = s.idPoliza " +
                                        "JOIN Cliente c ON c.idCliente = po.idCliente " +
                                        "JOIN Persona p ON p.idPersona = c.idPersona " +
                                        "LEFT JOIN Vehiculo v ON v.idVehiculo = po.idVehiculo " +
                                        "LEFT JOIN Empleado e ON e.idEmpleado = s.idEmpleado " +
                                        "LEFT JOIN Persona r ON r.idPersona = e.idPersona ";

        // Todos los reclamos (empleado). Con estado "Todos" no filtro
        public static List<Siniestro> ListarSiniestros(string estado)
        {
            List<Siniestro> lista = new List<Siniestro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE @estado = 'Todos' OR s.estado = @estado ORDER BY s.idSiniestro DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@estado", estado);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerSiniestro(leer));
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

        // Los reclamos de un cliente
        public static List<Siniestro> ListarDeCliente(int legajoCliente)
        {
            List<Siniestro> lista = new List<Siniestro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE c.idPersona = @legajo ORDER BY s.idSiniestro DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerSiniestro(leer));
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

        // Los reclamos que tiene a cargo un empleado (el último que actuó)
        public static List<Siniestro> ListarDeEmpleado(int legajoEmpleado)
        {
            List<Siniestro> lista = new List<Siniestro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE e.idPersona = @legajo ORDER BY s.idSiniestro DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajoEmpleado);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerSiniestro(leer));
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

        // Las fotos, la denuncia o el formulario de un reclamo, según el tipo
        public static List<AdjuntoSiniestro> ListarAdjuntos(int idSiniestro, string tipo)
        {
            List<AdjuntoSiniestro> lista = new List<AdjuntoSiniestro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT tipo, imagen FROM AdjuntoSiniestro WHERE idSiniestro = @id AND tipo = @tipo ORDER BY idAdjunto";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idSiniestro);
                sql.Parameters.AddWithValue("@tipo", tipo);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    AdjuntoSiniestro adjunto = new AdjuntoSiniestro()
                    {
                        Tipo = leer.GetString(0),
                        Imagen = (byte[])leer["imagen"]
                    };
                    lista.Add(adjunto);
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

        // Guardo el reclamo y sus adjuntos en una transacción. Si lo cargó un empleado, queda como responsable
        // (legajoEmpleado = 0 si lo cargó el cliente). Devuelvo el N° de expediente, o 0 si no se pudo guardar
        public static int CrearSiniestro(Siniestro siniestro, List<AdjuntoSiniestro> adjuntos, int legajoEmpleado)
        {
            int id = 0;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "INSERT INTO Siniestro (fechaOcurrencia, tipoSiniestro, ubicacion, descripcion, montoReclamado, idPoliza, estado, idEmpleado) " +
                               "VALUES (@fecha, @tipo, @ubicacion, @descripcion, @monto, @nro, @estado, " +
                               "(SELECT idEmpleado FROM Empleado WHERE idPersona = @legajoEmpleado)); " +
                               "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                CargarParametros(sql, siniestro);
                sql.Parameters.AddWithValue("@nro", siniestro.NroPoliza);
                sql.Parameters.AddWithValue("@estado", siniestro.Estado);
                sql.Parameters.AddWithValue("@legajoEmpleado", legajoEmpleado);

                id = Convert.ToInt32(sql.ExecuteScalar());

                GuardarAdjuntos(con, transaccion, id, adjuntos);

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

        // El cliente corrige su reclamo mientras está Pendiente. Los adjuntos nuevos reemplazan a los de su tipo;
        // el tipo que no viene en la lista queda como estaba
        public static bool EditarSiniestro(Siniestro siniestro, List<AdjuntoSiniestro> adjuntosNuevos, int legajoCliente)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "UPDATE Siniestro SET fechaOcurrencia = @fecha, tipoSiniestro = @tipo, ubicacion = @ubicacion, " +
                               "descripcion = @descripcion, montoReclamado = @monto " +
                               "WHERE idSiniestro = @id AND estado = 'Pendiente' AND idPoliza IN " +
                               "(SELECT po.nroPoliza FROM Poliza po JOIN Cliente c ON c.idCliente = po.idCliente WHERE c.idPersona = @legajo)";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                CargarParametros(sql, siniestro);
                sql.Parameters.AddWithValue("@id", siniestro.IdSiniestro);
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                if (sql.ExecuteNonQuery() > 0)
                {
                    foreach (string tipo in new string[] { "Foto", "Denuncia" })
                    {
                        if (adjuntosNuevos.Exists(a => a.Tipo == tipo))
                        {
                            SqlCommand borrar = new SqlCommand("DELETE FROM AdjuntoSiniestro WHERE idSiniestro = @id AND tipo = @tipo", con, transaccion);
                            borrar.Parameters.AddWithValue("@id", siniestro.IdSiniestro);
                            borrar.Parameters.AddWithValue("@tipo", tipo);
                            borrar.ExecuteNonQuery();
                        }
                    }

                    GuardarAdjuntos(con, transaccion, siniestro.IdSiniestro, adjuntosNuevos);
                    estado = true;
                }

                transaccion.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
                estado = false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // Guardo las observaciones del empleado; el que actúa queda como responsable. Un reclamo resuelto ya no cambia
        public static bool GuardarObservaciones(int idSiniestro, string observaciones, int legajoEmpleado)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Siniestro SET observaciones = @observaciones, " +
                               "idEmpleado = (SELECT idEmpleado FROM Empleado WHERE idPersona = @legajo) " +
                               "WHERE idSiniestro = @id AND estado NOT IN ('Aprobado', 'Rechazado')";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@observaciones", observaciones);
                sql.Parameters.AddWithValue("@legajo", legajoEmpleado);
                sql.Parameters.AddWithValue("@id", idSiniestro);

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

        // La documentación está verificada: el reclamo pasa de Pendiente a En evaluación
        public static bool PasarAEvaluacion(int idSiniestro, string observaciones, int legajoEmpleado)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Siniestro SET estado = 'En evaluación', observaciones = @observaciones, " +
                               "idEmpleado = (SELECT idEmpleado FROM Empleado WHERE idPersona = @legajo) " +
                               "WHERE idSiniestro = @id AND estado = 'Pendiente'";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@observaciones", observaciones);
                sql.Parameters.AddWithValue("@legajo", legajoEmpleado);
                sql.Parameters.AddWithValue("@id", idSiniestro);

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

        // Guardo el formulario de un reclamo En evaluación: las fotos nuevas reemplazan a las anteriores
        public static bool GuardarFormulario(int idSiniestro, List<AdjuntoSiniestro> formulario, int legajoEmpleado)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "UPDATE Siniestro SET idEmpleado = (SELECT idEmpleado FROM Empleado WHERE idPersona = @legajo) " +
                               "WHERE idSiniestro = @id AND estado = 'En evaluación'";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@legajo", legajoEmpleado);
                sql.Parameters.AddWithValue("@id", idSiniestro);

                if (sql.ExecuteNonQuery() > 0)
                {
                    SqlCommand borrar = new SqlCommand("DELETE FROM AdjuntoSiniestro WHERE idSiniestro = @id AND tipo = 'Formulario'", con, transaccion);
                    borrar.Parameters.AddWithValue("@id", idSiniestro);
                    borrar.ExecuteNonQuery();

                    GuardarAdjuntos(con, transaccion, idSiniestro, formulario);
                    estado = true;
                }

                transaccion.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
                estado = false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // Registro el resultado final (Aprobado o Rechazado), solo si el reclamo sigue en estadoActual
        public static bool Resolver(int idSiniestro, string estadoActual, string resultado, string observaciones, decimal monto, int legajoEmpleado)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Siniestro SET estado = @resultado, resultado = @resultado, fechaResolucion = GETDATE(), " +
                               "observaciones = @observaciones, montoReclamado = @monto, " +
                               "idEmpleado = (SELECT idEmpleado FROM Empleado WHERE idPersona = @legajo) " +
                               "WHERE idSiniestro = @id AND estado = @estadoActual";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@resultado", resultado);
                sql.Parameters.AddWithValue("@observaciones", observaciones);
                sql.Parameters.AddWithValue("@monto", monto);
                sql.Parameters.AddWithValue("@legajo", legajoEmpleado);
                sql.Parameters.AddWithValue("@id", idSiniestro);
                sql.Parameters.AddWithValue("@estadoActual", estadoActual);

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

        // Inserto cada adjunto con la misma conexión y transacción del reclamo
        private static void GuardarAdjuntos(SqlConnection con, SqlTransaction transaccion, int idSiniestro, List<AdjuntoSiniestro> adjuntos)
        {
            foreach (AdjuntoSiniestro adjunto in adjuntos)
            {
                string query = "INSERT INTO AdjuntoSiniestro (idSiniestro, tipo, imagen) VALUES (@id, @tipo, @imagen)";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@id", idSiniestro);
                sql.Parameters.AddWithValue("@tipo", adjunto.Tipo);
                sql.Parameters.Add("@imagen", SqlDbType.VarBinary, -1).Value = adjunto.Imagen;
                sql.ExecuteNonQuery();
            }
        }

        // Parámetros comunes del alta y la modificación del reclamo
        private static void CargarParametros(SqlCommand sql, Siniestro siniestro)
        {
            sql.Parameters.AddWithValue("@fecha", siniestro.FechaOcurrencia);
            sql.Parameters.AddWithValue("@tipo", siniestro.TipoSiniestro);
            sql.Parameters.AddWithValue("@ubicacion", siniestro.Ubicacion);
            sql.Parameters.AddWithValue("@descripcion", siniestro.Descripcion);
            sql.Parameters.AddWithValue("@monto", siniestro.MontoReclamado);
        }

        // Armo un Siniestro con la fila que estoy leyendo
        private static Siniestro LeerSiniestro(SqlDataReader leer)
        {
            Siniestro siniestro = new Siniestro()
            {
                IdSiniestro = leer.GetInt32(0),
                NroPoliza = leer.GetInt32(1),
                FechaOcurrencia = leer.GetDateTime(2),
                FechaRegistro = leer.GetDateTime(3),
                TipoSiniestro = leer.GetString(4),
                Ubicacion = leer.GetString(5),
                Descripcion = leer.GetString(6),
                Observaciones = leer.IsDBNull(7) ? "" : leer.GetString(7),
                Resultado = leer.IsDBNull(8) ? "" : leer.GetString(8),
                Estado = leer.GetString(9),
                FechaResolucion = leer.IsDBNull(10) ? (DateTime?)null : leer.GetDateTime(10),
                MontoReclamado = leer.GetDecimal(11),
                Cliente = leer.GetString(12),
                Dominio = leer.IsDBNull(13) ? "" : leer.GetString(13),
                EmpleadoResponsable = leer.IsDBNull(14) ? "" : leer.GetString(14),
                CantidadFotos = leer.GetInt32(15),
                CantidadDenuncias = leer.GetInt32(16),
                CantidadFormularios = leer.GetInt32(17)
            };
            return siniestro;
        }
    }
}
