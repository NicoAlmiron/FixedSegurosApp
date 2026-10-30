using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    internal class ComisionDatos
    {
        // Columnas de las cuotas (en el mismo orden que LeerCuota)
        private const string columnasCuota = "SELECT pa.idPago, pa.idPoliza, pa.cuota, pa.fechaVencimiento, pa.monto, pa.fechaPago, " +
                                             "per.apellido + ', ' + per.nombre, pr.nombre, po.comision, pa.idArqueo " +
                                             "FROM Pago pa " +
                                             "JOIN Poliza po ON po.nroPoliza = pa.idPoliza " +
                                             "JOIN Proveedor pr ON pr.idProveedor = po.idProveedor " +
                                             "JOIN Cliente c ON c.idCliente = po.idCliente " +
                                             "JOIN Persona per ON per.idPersona = c.idPersona ";

        // Columnas de los arqueos (en el mismo orden que LeerArqueo)
        private const string columnasArqueo = "SELECT a.idArqueo, a.desde, a.hasta, a.fechaCalculo, p.apellido + ', ' + p.nombre, a.totalCobrado, a.totalComision " +
                                              "FROM Arqueo a " +
                                              "JOIN Persona p ON p.idPersona = a.idPersona ";

        // Cuotas pagadas en el rango, liquidadas o no (cuenta la fecha en que se pagó, no el vencimiento)
        public static List<Pago> ListarCuotasCobradas(DateTime desde, DateTime hasta)
        {
            List<Pago> lista = new List<Pago>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnasCuota +
                               "WHERE pa.estadoPago = 1 AND pa.fechaPago BETWEEN @desde AND @hasta " +
                               "ORDER BY pa.fechaPago, pa.idPago";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@desde", desde);
                sql.Parameters.AddWithValue("@hasta", hasta);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerCuota(leer));
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

        public static List<Pago> ListarCuotasDeArqueo(int idArqueo)
        {
            List<Pago> lista = new List<Pago>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnasCuota + "WHERE pa.idArqueo = @id ORDER BY pa.fechaPago, pa.idPago";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idArqueo);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerCuota(leer));
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

        public static List<Arqueo> ListarArqueos()
        {
            List<Arqueo> lista = new List<Arqueo>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnasArqueo + "ORDER BY a.desde DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerArqueo(leer));
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

        // Devuelve un arqueo que se cruce con el rango, o null si el rango está libre.
        // Dos rangos se cruzan si cada uno empieza antes de que termine el otro.
        public static Arqueo BuscarArqueoSolapado(DateTime desde, DateTime hasta)
        {
            Arqueo arqueo = null;

            Conexion conexion = new Conexion();

            try
            {
                string query = columnasArqueo + "WHERE a.desde <= @hasta AND a.hasta >= @desde";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@desde", desde);
                sql.Parameters.AddWithValue("@hasta", hasta);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    arqueo = LeerArqueo(leer);
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

            return arqueo;
        }

        // Guarda el arqueo y marca sus cuotas en una transacción: si algo falla no queda nada a medias.
        // "idArqueo IS NULL" asegura que una cuota nunca entre en dos arqueos.
        // Devuelve el id nuevo, o 0 si no se pudo guardar.
        public static int GuardarArqueo(Arqueo arqueo, int legajo)
        {
            int id = 0;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "INSERT INTO Arqueo (desde, hasta, idPersona, totalCobrado, totalComision) " +
                               "VALUES (@desde, @hasta, @legajo, @cobrado, @comision); " +
                               "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@desde", arqueo.Desde);
                sql.Parameters.AddWithValue("@hasta", arqueo.Hasta);
                sql.Parameters.AddWithValue("@legajo", legajo);
                sql.Parameters.AddWithValue("@cobrado", arqueo.TotalCobrado);
                sql.Parameters.AddWithValue("@comision", arqueo.TotalComision);

                id = Convert.ToInt32(sql.ExecuteScalar());

                query = "UPDATE Pago SET idArqueo = @id " +
                        "WHERE idArqueo IS NULL AND estadoPago = 1 AND fechaPago BETWEEN @desde AND @hasta";

                sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@id", id);
                sql.Parameters.AddWithValue("@desde", arqueo.Desde);
                sql.Parameters.AddWithValue("@hasta", arqueo.Hasta);
                sql.ExecuteNonQuery();

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

        private static Pago LeerCuota(SqlDataReader leer)
        {
            Pago cuota = new Pago()
            {
                IdPago = leer.GetInt32(0),
                NroPoliza = leer.GetInt32(1),
                Cuota = leer.GetInt32(2),
                FechaVencimiento = leer.GetDateTime(3),
                Monto = leer.GetDecimal(4),
                FechaPago = leer.GetDateTime(5),
                Pagada = true,
                Cliente = leer.GetString(6),
                Aseguradora = leer.GetString(7),
                PorcentajeComision = leer.GetDecimal(8),
                IdArqueo = leer.IsDBNull(9) ? 0 : leer.GetInt32(9)
            };
            return cuota;
        }

        private static Arqueo LeerArqueo(SqlDataReader leer)
        {
            Arqueo arqueo = new Arqueo()
            {
                IdArqueo = leer.GetInt32(0),
                Desde = leer.GetDateTime(1),
                Hasta = leer.GetDateTime(2),
                FechaCalculo = leer.GetDateTime(3),
                Usuario = leer.GetString(4),
                TotalCobrado = leer.GetDecimal(5),
                TotalComision = leer.GetDecimal(6)
            };
            return arqueo;
        }
    }
}
