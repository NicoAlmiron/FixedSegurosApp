using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // Cálculo de comisiones (solo Administrador): cuánto ganó la empresa sobre las cuotas cobradas de un rango de meses.
    // Un arqueo guardado es definitivo: sus cuotas quedan marcadas y su rango ya no se puede volver a usar.
    internal class ComisionNegocio
    {
        public static List<Arqueo> ListarArqueos()
        {
            return ComisionDatos.ListarArqueos();
        }

        public static List<Pago> ListarCuotasDeArqueo(int idArqueo)
        {
            return ComisionDatos.ListarCuotasDeArqueo(idArqueo);
        }

        // Solo muestra el resultado: no guarda ni marca nada
        public static bool Calcular(DateTime desdeMes, DateTime hastaMes, out List<Pago> cuotas, out string mensaje)
        {
            cuotas = new List<Pago>();

            if (!ValidarRango(desdeMes, hastaMes, out mensaje))
            {
                return false;
            }

            cuotas = ComisionDatos.ListarCuotasCobradas(PrimerDia(desdeMes), UltimoDia(hastaMes));
            return true;
        }

        // Suma solo lo que todavía no se liquidó
        public static decimal TotalCobrado(List<Pago> cuotas)
        {
            decimal total = 0;
            foreach (Pago cuota in cuotas)
            {
                if (cuota.IdArqueo == 0)
                {
                    total += cuota.Monto;
                }
            }
            return total;
        }

        public static decimal TotalComision(List<Pago> cuotas)
        {
            decimal total = 0;
            foreach (Pago cuota in cuotas)
            {
                if (cuota.IdArqueo == 0)
                {
                    total += cuota.Comision;
                }
            }
            return total;
        }

        public static bool GuardarArqueo(DateTime desdeMes, DateTime hastaMes, out string mensaje)
        {
            if (!ValidarRango(desdeMes, hastaMes, out mensaje))
            {
                return false;
            }

            DateTime desde = PrimerDia(desdeMes);
            DateTime hasta = UltimoDia(hastaMes);

            // con el mes sin terminar todavía pueden entrar pagos que quedarían afuera del arqueo
            if (hasta >= DateTime.Today)
            {
                mensaje = "Solo se pueden cerrar meses ya terminados.";
                return false;
            }

            Arqueo solapado = ComisionDatos.BuscarArqueoSolapado(desde, hasta);
            if (solapado != null)
            {
                mensaje = "El rango se cruza con el arqueo " + solapado.NroTexto + " (" + solapado.Periodo + "). Elija meses que no estén cerrados.";
                return false;
            }

            List<Pago> cuotas = ComisionDatos.ListarCuotasCobradas(desde, hasta);
            if (TotalCobrado(cuotas) == 0)
            {
                mensaje = "No hay cuotas cobradas sin liquidar en ese rango.";
                return false;
            }

            Arqueo arqueo = new Arqueo()
            {
                Desde = desde,
                Hasta = hasta,
                TotalCobrado = TotalCobrado(cuotas),
                TotalComision = TotalComision(cuotas)
            };

            arqueo.IdArqueo = ComisionDatos.GuardarArqueo(arqueo, Sesion.UsuarioActual.Legajo);
            if (arqueo.IdArqueo == 0)
            {
                mensaje = "No se pudo guardar el arqueo.";
                return false;
            }

            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Pólizas", "Calculó comisión",
                "Arqueo " + arqueo.NroTexto + " · " + arqueo.Periodo + " · $ " + arqueo.TotalComision.ToString("N2"));
            return true;
        }

        private static bool ValidarRango(DateTime desdeMes, DateTime hastaMes, out string mensaje)
        {
            mensaje = "";

            if (Sesion.UsuarioActual.Perfil != "Administrador")
            {
                mensaje = "Solo el administrador puede calcular comisiones.";
                return false;
            }

            if (PrimerDia(desdeMes) > PrimerDia(hastaMes))
            {
                mensaje = "El mes \"Desde\" no puede ser posterior al mes \"Hasta\".";
                return false;
            }

            return true;
        }

        private static DateTime PrimerDia(DateTime mes)
        {
            return new DateTime(mes.Year, mes.Month, 1);
        }

        private static DateTime UltimoDia(DateTime mes)
        {
            return PrimerDia(mes).AddMonths(1).AddDays(-1);
        }
    }
}
