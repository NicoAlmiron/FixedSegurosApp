using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // Arma cada pestaña de Reportes. "Hoy" es una foto del momento; lo demás depende del período elegido.
    internal class ReporteNegocio
    {
        private const string Hoy = "Hoy";
        private const string EnPeriodo = "En el período";

        public static bool ValidarPeriodo(DateTime desde, DateTime hasta, out string mensaje)
        {
            mensaje = "";

            if (desde.Date > hasta.Date)
            {
                mensaje = "La fecha Desde no puede ser posterior a la fecha Hasta.";
                return false;
            }

            return true;
        }

        // El orden es el de las pestañas de la pantalla
        public static ReporteSeccion ArmarSeccion(int indice, DateTime desde, DateTime hasta)
        {
            switch (indice)
            {
                case 1:
                    return Polizas(desde, hasta);
                case 2:
                    return Cobranzas(desde, hasta);
                case 3:
                    return Siniestros(desde, hasta);
                case 4:
                    return ClientesYVehiculos(desde, hasta);
                case 5:
                    return Personal(desde, hasta);
                default:
                    return General(desde, hasta);
            }
        }

        private static ReporteSeccion General(DateTime desde, DateTime hasta)
        {
            ReporteSeccion seccion = Seccion("General");

            seccion.Tarjetas.Add(Tarjeta("Clientes activos", ReporteDatos.ContarClientesActivos().ToString(), Hoy, false));
            seccion.Tarjetas.Add(Tarjeta("Pólizas vigentes", InicioDatos.ContarPolizasVigentes(0).ToString(), Hoy, false));
            seccion.Tarjetas.Add(Tarjeta("Cobrado", Plata(ReporteDatos.SumarCobrado(desde, hasta)), EnPeriodo, false));
            seccion.Tarjetas.Add(Tarjeta("Comisión", Plata(ReporteDatos.SumarComision(desde, hasta)), EnPeriodo, false));

            seccion.Grafico1 = Grafico("Cobrado por mes", ReporteDatos.CobradoPorMes(desde, hasta), true, true);
            seccion.Grafico2 = Grafico("Pólizas por estado (hoy)", ReporteDatos.PolizasPorEstado(), false, false);
            return seccion;
        }

        private static ReporteSeccion Polizas(DateTime desde, DateTime hasta)
        {
            ReporteSeccion seccion = Seccion("Pólizas");

            seccion.Tarjetas.Add(Tarjeta("Contratadas", ReporteDatos.ContarPolizasContratadas(desde, hasta).ToString(), "Inicio en el período", false));
            seccion.Tarjetas.Add(Tarjeta("Vigentes", InicioDatos.ContarPolizasVigentes(0).ToString(), Hoy, false));
            seccion.Tarjetas.Add(Tarjeta("Vencen en 30 días", InicioDatos.ContarPorVencer(0).ToString(), Hoy, false));
            seccion.Tarjetas.Add(Tarjeta("Dadas de baja", ReporteDatos.ContarPolizasDeBaja().ToString(), "Histórico", false));

            seccion.Grafico1 = Grafico("Vigentes por cobertura (hoy)", ReporteDatos.PolizasPorCobertura(), false, false);
            seccion.Grafico2 = Grafico("Vigentes por aseguradora (hoy)", ReporteDatos.PolizasPorAseguradora(), false, false);
            return seccion;
        }

        private static ReporteSeccion Cobranzas(DateTime desde, DateTime hasta)
        {
            ReporteSeccion seccion = Seccion("Cobranzas");
            int impagas = InicioDatos.ContarCuotasImpagas(0);

            seccion.Tarjetas.Add(Tarjeta("Cobrado", Plata(ReporteDatos.SumarCobrado(desde, hasta)), EnPeriodo, false));
            seccion.Tarjetas.Add(Tarjeta("Comisión", Plata(ReporteDatos.SumarComision(desde, hasta)), EnPeriodo, false));
            seccion.Tarjetas.Add(Tarjeta("Cuotas impagas", impagas.ToString(), Hoy, impagas > 0));
            seccion.Tarjetas.Add(Tarjeta("Deuda vencida", Plata(ReporteDatos.SumarDeudaVencida()), Hoy, impagas > 0));

            seccion.Grafico1 = Grafico("Cobrado por mes", ReporteDatos.CobradoPorMes(desde, hasta), true, true);
            seccion.Grafico2 = Grafico("Cobrado por método de pago", ReporteDatos.CobradoPorMetodo(desde, hasta), true, false);
            return seccion;
        }

        private static ReporteSeccion Siniestros(DateTime desde, DateTime hasta)
        {
            ReporteSeccion seccion = Seccion("Siniestros");

            int aprobados = ReporteDatos.ContarReclamosAprobados(desde, hasta);
            int rechazados = ReporteDatos.ContarReclamosRechazados(desde, hasta);
            int resueltos = aprobados + rechazados;
            string porcentaje = resueltos == 0 ? "-" : (aprobados * 100 / resueltos) + " %";

            seccion.Tarjetas.Add(Tarjeta("Reclamos", ReporteDatos.ContarReclamos(desde, hasta).ToString(), EnPeriodo, false));
            seccion.Tarjetas.Add(Tarjeta("Abiertos", InicioDatos.ContarReclamosAbiertos(0).ToString(), Hoy, false));
            seccion.Tarjetas.Add(Tarjeta("Monto reclamado", Plata(ReporteDatos.SumarMontoReclamado(desde, hasta)), EnPeriodo, false));
            seccion.Tarjetas.Add(Tarjeta("Aprobados", porcentaje, "De los resueltos en el período", false));

            seccion.Grafico1 = Grafico("Reclamos por estado", ReporteDatos.ReclamosPorEstado(desde, hasta), false, false);
            seccion.Grafico2 = Grafico("Reclamos por tipo", ReporteDatos.ReclamosPorTipo(desde, hasta), false, false);
            return seccion;
        }

        private static ReporteSeccion ClientesYVehiculos(DateTime desde, DateTime hasta)
        {
            ReporteSeccion seccion = Seccion("Clientes y vehículos");

            seccion.Tarjetas.Add(Tarjeta("Clientes", ReporteDatos.ContarClientes().ToString(), Hoy, false));
            seccion.Tarjetas.Add(Tarjeta("Clientes nuevos", ReporteDatos.ContarClientesNuevos(desde, hasta).ToString(), EnPeriodo, false));
            seccion.Tarjetas.Add(Tarjeta("Vehículos", ReporteDatos.ContarVehiculos().ToString(), Hoy, false));
            seccion.Tarjetas.Add(Tarjeta("Vehículos por revisar", InicioDatos.ContarVehiculosPendientes().ToString(), Hoy, false));

            seccion.Grafico1 = Grafico("Clientes por provincia (hoy)", ReporteDatos.ClientesPorProvincia(), false, false);
            seccion.Grafico2 = Grafico("Vehículos por tipo (hoy)", ReporteDatos.VehiculosPorTipo(), false, false);
            return seccion;
        }

        private static ReporteSeccion Personal(DateTime desde, DateTime hasta)
        {
            ReporteSeccion seccion = Seccion("Personal");

            seccion.Tarjetas.Add(Tarjeta("Empleados habilitados", ReporteDatos.ContarEmpleadosHabilitados().ToString(), Hoy, false));
            seccion.Tarjetas.Add(Tarjeta("Reclamos atendidos", ReporteDatos.ContarReclamosAtendidos(desde, hasta).ToString(), EnPeriodo, false));
            seccion.Tarjetas.Add(Tarjeta("Acciones registradas", ReporteDatos.ContarAcciones(desde, hasta).ToString(), EnPeriodo, false));
            seccion.Tarjetas.Add(Tarjeta("Usuarios activos", ReporteDatos.ContarUsuariosActivos().ToString(), Hoy, false));

            seccion.Grafico1 = Grafico("Reclamos por empleado", ReporteDatos.ReclamosPorEmpleado(desde, hasta), false, false);
            seccion.Grafico2 = Grafico("Acciones por módulo", ReporteDatos.AccionesPorModulo(desde, hasta), false, false);
            return seccion;
        }

        private static ReporteSeccion Seccion(string titulo)
        {
            return new ReporteSeccion() { Titulo = titulo, Tarjetas = new List<TarjetaInicio>() };
        }

        private static TarjetaInicio Tarjeta(string titulo, string valor, string detalle, bool alerta)
        {
            return new TarjetaInicio() { Titulo = titulo, Valor = valor, Detalle = detalle, Alerta = alerta };
        }

        private static GraficoReporte Grafico(string titulo, List<FilaReporte> filas, bool porMonto, bool vertical)
        {
            foreach (FilaReporte fila in filas)
            {
                fila.Grupo = titulo;
            }

            return new GraficoReporte() { Titulo = titulo, Filas = filas, PorMonto = porMonto, Vertical = vertical };
        }

        private static string Plata(decimal monto)
        {
            return "$ " + monto.ToString("N0");
        }
    }
}
