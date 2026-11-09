using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    // Guardado del "Alta en oficina": cliente, vehículo con fotos y póliza, todo junto.
    // Uso los mismos métodos de UsuarioDatos, VehiculoDatos y PolizaDatos pero con una sola conexión y una sola transacción
    internal class AltaOficinaDatos
    {
        // Guardo todo el trámite en una sola transacción: si algo falla no queda nada a medias.
        // - cliente.Legajo = 0: creo el usuario. Si no, uso ese cliente.
        // - vehiculo.IdVehiculo = 0: creo el vehículo con sus fotos, ya aprobado por el empleado. Si no, uso ese vehículo.
        // Devuelvo el N° de la póliza nueva, o 0 si no se pudo guardar
        public static int Guardar(Persona cliente, string contrasenaHash, string sal, Vehiculo vehiculo, List<FotoVehiculo> fotos, int nroOfrecida, DateTime inicio, DateTime vencimiento, List<Pago> cuotas, int legajoEmpleado)
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
                    legajo = UsuarioDatos.CrearUsuario(con, transaccion, cliente, contrasenaHash, sal);
                }

                int idVehiculo = vehiculo.IdVehiculo;
                if (idVehiculo == 0)
                {
                    idVehiculo = VehiculoDatos.InsertarVehiculo(con, transaccion, vehiculo, legajo);
                    VehiculoDatos.GuardarFotos(con, transaccion, idVehiculo, fotos);
                    VehiculoDatos.CambiarRevision(con, transaccion, idVehiculo, "Aprobado", "", legajoEmpleado);
                }

                nro = PolizaDatos.InsertarAdquirida(con, transaccion, nroOfrecida, idVehiculo, legajo, inicio, vencimiento, cuotas);
                PolizaDatos.AsignarReferente(con, transaccion, nro, legajoEmpleado);

                transaccion.Commit();

                // recién acá confirmo todo; si hubo un error antes, el catch hace Rollback y cliente y vehículo quedan como estaban
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
