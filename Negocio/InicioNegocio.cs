using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // Resumen de la pantalla Inicio. Administrador y Empleado ven todo; el Cliente, solo lo suyo.
    internal class InicioNegocio
    {
        // Las cuatro tarjetas según el perfil
        public static List<TarjetaInicio> ListarTarjetas()
        {
            Persona usuario = Sesion.UsuarioActual;

            if (usuario.Perfil == "Cliente")
            {
                return TarjetasCliente(usuario.Legajo);
            }

            if (usuario.Perfil == "Empleado")
            {
                return TarjetasEmpleado();
            }

            return TarjetasAdministrador();
        }

        public static List<AlertaPoliza> ListarAlertas(int idProveedor)
        {
            Persona usuario = Sesion.UsuarioActual;
            return InicioDatos.ListarAlertas(usuario.Perfil == "Cliente" ? usuario.Legajo : 0, idProveedor);
        }

        private static List<TarjetaInicio> TarjetasAdministrador()
        {
            List<TarjetaInicio> lista = new List<TarjetaInicio>();
            int impagas = InicioDatos.ContarCuotasImpagas(0);

            lista.Add(Tarjeta("Pólizas vigentes", InicioDatos.ContarPolizasVigentes(0).ToString(), "Activas", false));
            lista.Add(Tarjeta("Vencen en 30 días", InicioDatos.ContarPorVencer(0).ToString(), "Por vencer", false));
            lista.Add(Tarjeta("Cuotas impagas", impagas.ToString(), "Impagas", impagas > 0));
            lista.Add(Tarjeta("Aseguradoras habilitadas", InicioDatos.ContarAseguradoras().ToString(), "Registradas", false));

            return lista;
        }

        private static List<TarjetaInicio> TarjetasEmpleado()
        {
            List<TarjetaInicio> lista = new List<TarjetaInicio>();
            int impagas = InicioDatos.ContarCuotasImpagas(0);

            lista.Add(Tarjeta("Siniestros por evaluar", InicioDatos.ContarSiniestrosPendientes().ToString(), "Por verificar", false));
            lista.Add(Tarjeta("Vehículos por evaluar", InicioDatos.ContarVehiculosPendientes().ToString(), "Por revisar", false));
            lista.Add(Tarjeta("Vencen en 30 días", InicioDatos.ContarPorVencer(0).ToString(), "Por vencer", false));
            lista.Add(Tarjeta("Cuotas impagas", impagas.ToString(), "Impagas", impagas > 0));

            return lista;
        }

        private static List<TarjetaInicio> TarjetasCliente(int legajo)
        {
            List<TarjetaInicio> lista = new List<TarjetaInicio>();
            int impagas = InicioDatos.ContarCuotasImpagas(legajo);
            Pago proxima = InicioDatos.BuscarProximaCuota(legajo);

            lista.Add(Tarjeta("Pólizas vigentes", InicioDatos.ContarPolizasVigentes(legajo).ToString(), "Activas", false));

            if (proxima != null)
            {
                lista.Add(Tarjeta("Próxima cuota", "$ " + proxima.Monto.ToString("N0"), "Vence el " + proxima.FechaVencimiento.ToString("dd/MM/yyyy"), false));
            }
            else
            {
                lista.Add(Tarjeta("Próxima cuota", "-", "Sin cuotas pendientes", false));
            }

            lista.Add(Tarjeta("Cuotas impagas", impagas.ToString(), "Vencidas", impagas > 0));
            lista.Add(Tarjeta("Reclamos abiertos", InicioDatos.ContarReclamosAbiertos(legajo).ToString(), "Pendientes o en evaluación", false));

            return lista;
        }

        private static TarjetaInicio Tarjeta(string titulo, string valor, string detalle, bool alerta)
        {
            return new TarjetaInicio() { Titulo = titulo, Valor = valor, Detalle = detalle, Alerta = alerta };
        }
    }
}
