using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    internal class AltaOficinaDatos
    {
        // Guarda todo el trámite en una sola transacción: si algo falla no queda nada a medias.
        // - cliente.Legajo = 0: crea el usuario. Si no, usa ese cliente.
        // - vehiculo.IdVehiculo = 0: crea el vehículo con sus fotos, ya aprobado por el empleado. Si no, usa ese vehículo.
        // Devuelve el N° de la póliza nueva, o 0 si no se pudo guardar.
        public static int Guardar(Persona cliente, string contrasenaHash, Vehiculo vehiculo, List<FotoVehiculo> fotos, int nroOfrecida, DateTime inicio, DateTime vencimiento, List<Pago> cuotas, int legajoEmpleado)
        {
            int nro = 0;

            Conexion conexion = new Conexion();
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                transaccion = con.BeginTransaction();

                int legajo = cliente.Legajo;
                if (legajo == 0)
                {
                    legajo = UsuarioDatos.CrearUsuario(con, transaccion, cliente, contrasenaHash);
                }

                int idVehiculo = vehiculo.IdVehiculo;
                if (idVehiculo == 0)
                {
                    idVehiculo = VehiculoDatos.InsertarVehiculo(con, transaccion, vehiculo, legajo);
                    VehiculoDatos.GuardarFotos(con, transaccion, idVehiculo, fotos);
                    VehiculoDatos.CambiarRevision(con, transaccion, idVehiculo, "Aprobado", "", legajoEmpleado);
                }

                nro = PolizaDatos.InsertarAdquirida(con, transaccion, nroOfrecida, idVehiculo, legajo, inicio, vencimiento, cuotas);

                transaccion.Commit();

                // recién acá se confirma: si hubo un error, cliente y vehículo siguen como estaban
                cliente.Legajo = legajo;
                vehiculo.IdVehiculo = idVehiculo;
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
    }
}
