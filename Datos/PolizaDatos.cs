using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    internal class PolizaDatos
    {
        // Columnas que usan todas las consultas (en el mismo orden que LeerPoliza).
        // Cliente y vehículo van con LEFT JOIN porque una póliza ofrecida todavía no los tiene.
        private const string columnas = "SELECT po.nroPoliza, po.idProveedor, pr.nombre, pr.activo, po.tipoCobertura, po.tipoVehiculo, " +
                                        "po.adicionales, po.fechaInicio, po.fechaVencimiento, po.descuento, po.duracion, po.requisitos, " +
                                        "po.tipoPrima, po.prima, po.formaPago, po.franquicia, po.estado, " +
                                        "p.apellido + ', ' + p.nombre, v.dominio " +
                                        "FROM Poliza po " +
                                        "JOIN Proveedor pr ON pr.idProveedor = po.idProveedor " +
                                        "LEFT JOIN Cliente c ON c.idCliente = po.idCliente " +
                                        "LEFT JOIN Persona p ON p.idPersona = c.idPersona " +
                                        "LEFT JOIN Vehiculo v ON v.idVehiculo = po.idVehiculo ";

        // Todas las pólizas (Admin/Empleado). Busca por N° de póliza, DNI del cliente o dominio.
        public static List<Poliza> ListarPolizas(string buscar)
        {
            List<Poliza> lista = new List<Poliza>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas +
                               "WHERE @buscar = '' " +
                               "OR po.nroPoliza = TRY_CAST(@buscar AS INT) " +
                               "OR CAST(p.dni AS VARCHAR(10)) LIKE @buscar + '%' " +
                               "OR v.dominio LIKE '%' + @buscar + '%' " +
                               "ORDER BY po.nroPoliza DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@buscar", buscar);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerPoliza(leer));
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

        // Las pólizas de un cliente (vigentes y dadas de baja)
        public static List<Poliza> ListarPolizasDeCliente(int legajoCliente)
        {
            List<Poliza> lista = new List<Poliza>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE c.idPersona = @legajo ORDER BY po.nroPoliza DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerPoliza(leer));
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

        // Pólizas ofrecidas para un tipo de vehículo, solo de aseguradoras activas
        public static List<Poliza> ListarOfrecidas(string tipoVehiculo)
        {
            List<Poliza> lista = new List<Poliza>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas +
                               "WHERE po.estado = 'Ofrecida' AND pr.activo = 1 AND po.tipoVehiculo = @tipo " +
                               "ORDER BY po.prima";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@tipo", tipoVehiculo);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerPoliza(leer));
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

        public static Poliza BuscarPorNro(int nroPoliza)
        {
            Poliza poliza = null;

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE po.nroPoliza = @nro";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@nro", nroPoliza);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    poliza = LeerPoliza(leer);
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

            return poliza;
        }

        // Crea una póliza "Ofrecida". El referente es el empleado que la carga (si la carga el admin queda NULL).
        // Devuelve el N° de póliza nuevo, o 0 si no se pudo guardar.
        public static int CrearPoliza(Poliza poliza, int legajoReferente)
        {
            int nro = 0;

            Conexion conexion = new Conexion();

            try
            {
                string query = "INSERT INTO Poliza (tipoCobertura, tipoVehiculo, adicionales, fechaInicio, descuento, duracion, requisitos, " +
                               "referente, tipoPrima, prima, formaPago, franquicia, estado, idProveedor) " +
                               "VALUES (@cobertura, @tipoVehiculo, @adicionales, @inicio, @descuento, @duracion, @requisitos, " +
                               "(SELECT idEmpleado FROM Empleado WHERE idPersona = @legajo), " +
                               "@tipoPrima, @prima, @formaPago, @franquicia, 'Ofrecida', @idProveedor); " +
                               "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                CargarParametros(sql, poliza);
                sql.Parameters.AddWithValue("@legajo", legajoReferente);

                nro = Convert.ToInt32(sql.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return nro;
        }

        // Solo se modifican las pólizas ofrecidas (la condición está en el WHERE)
        public static bool EditarPoliza(Poliza poliza)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Poliza SET tipoCobertura = @cobertura, tipoVehiculo = @tipoVehiculo, adicionales = @adicionales, " +
                               "fechaInicio = @inicio, descuento = @descuento, duracion = @duracion, requisitos = @requisitos, " +
                               "tipoPrima = @tipoPrima, prima = @prima, formaPago = @formaPago, franquicia = @franquicia, " +
                               "idProveedor = @idProveedor " +
                               "WHERE nroPoliza = @nro AND estado = 'Ofrecida'";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                CargarParametros(sql, poliza);
                sql.Parameters.AddWithValue("@nro", poliza.NroPoliza);

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

        // Pasa la póliza a "Baja" y borra las cuotas que todavía no vencieron ni se pagaron
        // (las vencidas impagas quedan como deuda). Todo en una transacción.
        public static bool DarDeBaja(int nroPoliza)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "UPDATE Poliza SET estado = 'Baja' WHERE nroPoliza = @nro AND estado <> 'Baja'";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@nro", nroPoliza);

                if (sql.ExecuteNonQuery() > 0)
                {
                    query = "DELETE FROM Pago WHERE idPoliza = @nro AND estadoPago = 0 AND fechaVencimiento >= CAST(GETDATE() AS DATE)";

                    sql = new SqlCommand(query, con, transaccion);
                    sql.Parameters.AddWithValue("@nro", nroPoliza);
                    sql.ExecuteNonQuery();

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

        // El cliente adquiere una póliza ofrecida: se copia como "Vigente" con su cliente y vehículo,
        // y se guardan sus cuotas en Pago. Todo en una transacción. Devuelve el N° de la póliza nueva, o 0.
        public static int AdquirirPoliza(int nroOfrecida, int idVehiculo, int legajoCliente, DateTime inicio, DateTime vencimiento, List<Pago> cuotas)
        {
            int nro = 0;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                string query = "INSERT INTO Poliza (tipoCobertura, tipoVehiculo, adicionales, fechaInicio, fechaVencimiento, sumaAsegurada, " +
                               "descuento, duracion, requisitos, referente, tipoPrima, prima, formaPago, franquicia, estado, " +
                               "idCliente, idVehiculo, idProveedor) " +
                               "SELECT tipoCobertura, tipoVehiculo, adicionales, @inicio, @vencimiento, sumaAsegurada, " +
                               "descuento, duracion, requisitos, referente, tipoPrima, prima, formaPago, franquicia, 'Vigente', " +
                               "(SELECT idCliente FROM Cliente WHERE idPersona = @legajo), @idVehiculo, idProveedor " +
                               "FROM Poliza WHERE nroPoliza = @nro AND estado = 'Ofrecida'; " +
                               "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand sql = new SqlCommand(query, con, transaccion);
                sql.Parameters.AddWithValue("@inicio", inicio);
                sql.Parameters.AddWithValue("@vencimiento", vencimiento);
                sql.Parameters.AddWithValue("@legajo", legajoCliente);
                sql.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                sql.Parameters.AddWithValue("@nro", nroOfrecida);

                nro = Convert.ToInt32(sql.ExecuteScalar());

                foreach (Pago cuota in cuotas)
                {
                    query = "INSERT INTO Pago (cuota, fechaVencimiento, monto, idPoliza) VALUES (@cuota, @vencimiento, @monto, @nro)";

                    sql = new SqlCommand(query, con, transaccion);
                    sql.Parameters.AddWithValue("@cuota", cuota.Cuota);
                    sql.Parameters.AddWithValue("@vencimiento", cuota.FechaVencimiento);
                    sql.Parameters.AddWithValue("@monto", cuota.Monto);
                    sql.Parameters.AddWithValue("@nro", nro);
                    sql.ExecuteNonQuery();
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
                nro = 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return nro;
        }

        private static void CargarParametros(SqlCommand sql, Poliza poliza)
        {
            sql.Parameters.AddWithValue("@cobertura", poliza.TipoCobertura);
            sql.Parameters.AddWithValue("@tipoVehiculo", poliza.TipoVehiculo);
            sql.Parameters.AddWithValue("@adicionales", poliza.Adicionales == "" ? (object)DBNull.Value : poliza.Adicionales);
            sql.Parameters.AddWithValue("@inicio", poliza.FechaInicio.Value);
            sql.Parameters.AddWithValue("@descuento", poliza.Descuento);
            sql.Parameters.AddWithValue("@duracion", poliza.Duracion);
            sql.Parameters.AddWithValue("@requisitos", poliza.Requisitos == "" ? (object)DBNull.Value : poliza.Requisitos);
            sql.Parameters.AddWithValue("@tipoPrima", poliza.TipoPrima);
            sql.Parameters.AddWithValue("@prima", poliza.Prima);
            sql.Parameters.AddWithValue("@formaPago", poliza.FormaPago);
            sql.Parameters.AddWithValue("@franquicia", poliza.Franquicia);
            sql.Parameters.AddWithValue("@idProveedor", poliza.IdProveedor);
        }

        private static Poliza LeerPoliza(SqlDataReader leer)
        {
            Poliza poliza = new Poliza()
            {
                NroPoliza = leer.GetInt32(0),
                IdProveedor = leer.GetInt32(1),
                Aseguradora = leer.GetString(2),
                AseguradoraActiva = leer.GetBoolean(3),
                TipoCobertura = leer.GetString(4),
                TipoVehiculo = leer.GetString(5),
                Adicionales = leer.IsDBNull(6) ? "" : leer.GetString(6),
                FechaInicio = leer.IsDBNull(7) ? (DateTime?)null : leer.GetDateTime(7),
                FechaVencimiento = leer.IsDBNull(8) ? (DateTime?)null : leer.GetDateTime(8),
                Descuento = leer.GetDecimal(9),
                Duracion = leer.GetInt32(10),
                Requisitos = leer.IsDBNull(11) ? "" : leer.GetString(11),
                TipoPrima = leer.GetString(12),
                Prima = leer.GetDecimal(13),
                FormaPago = leer.GetString(14),
                Franquicia = leer.GetDecimal(15),
                Estado = leer.GetString(16),
                Cliente = leer.IsDBNull(17) ? "" : leer.GetString(17),
                Dominio = leer.IsDBNull(18) ? "" : leer.GetString(18)
            };
            return poliza;
        }
    }
}
