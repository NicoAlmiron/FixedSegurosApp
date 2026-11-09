using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Consultas de Pagos (tabla Pago: una fila por cuota).
    // Todos los métodos siguen el mismo esquema: abro la conexión, armo el SqlCommand con parámetros (@...), leo o ejecuto, y en el finally cierro la conexión.
    internal class PagoDatos
    {
        // Las cuotas de una póliza. Pido también el legajo para asegurarme de que la póliza sea de ese cliente
        public static List<Pago> ListarCuotas(int nroPoliza, int legajoCliente)
        {
            List<Pago> lista = new List<Pago>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT pa.idPago, pa.idPoliza, pa.cuota, pa.fechaVencimiento, pa.monto, pa.fechaPago, pa.metodoPago, pa.estadoPago " +
                               "FROM Pago pa " +
                               "JOIN Poliza po ON po.nroPoliza = pa.idPoliza " +
                               "JOIN Cliente c ON c.idCliente = po.idCliente " +
                               "WHERE pa.idPoliza = @nro AND c.idPersona = @legajo " +
                               "ORDER BY pa.cuota";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@nro", nroPoliza);
                sql.Parameters.AddWithValue("@legajo", legajoCliente);

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

        // Marco la cuota como pagada con la fecha de hoy. No toco cuotas ya pagadas ni de otro cliente (está en el WHERE).
        // La fecha nunca es anterior a hoy: de eso depende que un arqueo cerrado no cambie
        public static bool RegistrarPago(int idPago, string metodoPago, int legajoCliente)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE pa SET pa.estadoPago = 1, pa.fechaPago = CAST(GETDATE() AS DATE), pa.metodoPago = @metodo " +
                               "FROM Pago pa " +
                               "JOIN Poliza po ON po.nroPoliza = pa.idPoliza " +
                               "JOIN Cliente c ON c.idCliente = po.idCliente " +
                               "WHERE pa.idPago = @id AND pa.estadoPago = 0 AND c.idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@metodo", metodoPago);
                sql.Parameters.AddWithValue("@id", idPago);
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
    }
}
