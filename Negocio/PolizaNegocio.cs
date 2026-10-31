using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    internal class PolizaNegocio
    {
        // ================= Admin / Empleado =================

        public static List<Poliza> ListarPolizas(string buscar)
        {
            return PolizaDatos.ListarPolizas(buscar.Trim());
        }

        public static Poliza BuscarPorNro(int nroPoliza)
        {
            return PolizaDatos.BuscarPorNro(nroPoliza);
        }

        // Si poliza.NroPoliza es 0 crea una póliza "Ofrecida"; si no, guarda los cambios (solo de una ofrecida).
        // Los montos llegan como texto ("45000", "$ 45.000", "10 %") y se validan acá.
        public static bool GuardarPoliza(Poliza poliza, string primaTexto, string descuentoTexto, string duracionTexto, string franquiciaTexto, string comisionTexto, out string mensaje)
        {
            mensaje = "";
            decimal prima;
            decimal descuento;
            int duracion;
            decimal franquicia;
            decimal comision;

            if (Sesion.UsuarioActual.Perfil == "Cliente")
            {
                mensaje = "Solo un empleado o administrador puede cargar pólizas.";
                return false;
            }

            if (poliza.IdProveedor == 0 || poliza.TipoCobertura == "" || poliza.TipoVehiculo == "" || poliza.TipoPrima == "" ||
                poliza.FormaPago == "" || primaTexto == "" || duracionTexto == "" || comisionTexto == "")
            {
                mensaje = "Complete aseguradora, cobertura, tipo de vehículo, tipo de prima, prima, forma de pago, duración y comisión.";
                return false;
            }

            if (!decimal.TryParse(LimpiarNumero(primaTexto), out prima) || prima <= 0)
            {
                mensaje = "La prima debe ser un monto mayor a 0.";
                return false;
            }
            poliza.Prima = prima;

            // descuento y franquicia pueden quedar vacíos (= 0)
            if (descuentoTexto == "")
            {
                descuento = 0;
            }
            else if (!decimal.TryParse(LimpiarPorcentaje(descuentoTexto), out descuento) || descuento < 0 || descuento >= 100)
            {
                mensaje = "El descuento debe ser un porcentaje entre 0 y 99.";
                return false;
            }
            poliza.Descuento = descuento;

            if (franquiciaTexto == "")
            {
                franquicia = 0;
            }
            else if (!decimal.TryParse(LimpiarNumero(franquiciaTexto), out franquicia) || franquicia < 0)
            {
                mensaje = "La franquicia debe ser un monto igual o mayor a 0.";
                return false;
            }
            poliza.Franquicia = franquicia;

            if (!decimal.TryParse(LimpiarPorcentaje(comisionTexto), out comision) || comision < 0 || comision > 100)
            {
                mensaje = "La comisión debe ser un porcentaje entre 0 y 100.";
                return false;
            }
            poliza.Comision = comision;

            if (!int.TryParse(duracionTexto, out duracion) || duracion < 1 || duracion > 60)
            {
                mensaje = "La duración debe ser de 1 a 60 meses.";
                return false;
            }
            poliza.Duracion = duracion;

            // la duración tiene que dar un número entero de cuotas (ej: prima Trimestral -> 3, 6, 9, 12... meses)
            if (poliza.Duracion % poliza.MesesPorCuota != 0)
            {
                mensaje = "Con prima " + poliza.TipoPrima + " la duración debe ser múltiplo de " + poliza.MesesPorCuota + " meses.";
                return false;
            }

            if (poliza.FechaInicio.Value.Date < DateTime.Today)
            {
                mensaje = "La fecha de inicio propuesta no puede ser anterior a hoy.";
                return false;
            }

            Proveedor aseguradora = ProveedorDatos.BuscarPorId(poliza.IdProveedor);
            if (aseguradora == null || !aseguradora.Activo)
            {
                mensaje = "La aseguradora está dada de baja: no puede ofrecer pólizas.";
                return false;
            }

            if (poliza.NroPoliza == 0)
            {
                poliza.NroPoliza = PolizaDatos.CrearPoliza(poliza, Sesion.UsuarioActual.Legajo);

                if (poliza.NroPoliza == 0)
                {
                    mensaje = "No se pudo guardar la póliza.";
                    return false;
                }

                Registrar("Creó póliza", "Póliza " + poliza.NroTexto);
            }
            else
            {
                if (!PolizaDatos.EditarPoliza(poliza))
                {
                    mensaje = "Solo se pueden modificar las pólizas ofrecidas (sin cliente).";
                    return false;
                }

                Registrar("Modificó póliza", "Póliza " + poliza.NroTexto);
            }

            return true;
        }

        // Una ofrecida dada de baja ya no se puede adquirir; una vigente pierde la cobertura
        // y se borran sus cuotas futuras sin pagar.
        public static bool DarDeBaja(Poliza poliza, out string mensaje)
        {
            mensaje = "";

            if (Sesion.UsuarioActual.Perfil == "Cliente")
            {
                mensaje = "Solo un empleado o administrador puede dar de baja pólizas.";
                return false;
            }

            if (poliza.Estado == "Baja")
            {
                mensaje = "La póliza ya está dada de baja.";
                return false;
            }

            if (!PolizaDatos.DarDeBaja(poliza.NroPoliza))
            {
                mensaje = "No se pudo dar de baja la póliza.";
                return false;
            }

            Registrar("Dio de baja", "Póliza " + poliza.NroTexto);
            return true;
        }

        // ================= Cliente =================

        public static List<Poliza> ListarMisPolizas()
        {
            return PolizaDatos.ListarPolizasDeCliente(Sesion.UsuarioActual.Legajo);
        }

        // Vehículos del cliente que pueden adquirir una póliza: aprobados y sin póliza vigente
        public static List<Vehiculo> ListarVehiculosAsegurables()
        {
            return ListarVehiculosAsegurables(Sesion.UsuarioActual.Legajo);
        }

        public static List<Vehiculo> ListarVehiculosAsegurables(int legajoCliente)
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            foreach (Vehiculo v in VehiculoDatos.ListarVehiculos(legajoCliente))
            {
                if (v.EstadoRevision == "Aprobado" && v.NroPoliza == 0)
                {
                    lista.Add(v);
                }
            }
            return lista;
        }

        // Pólizas ofrecidas que sirven para ese tipo de vehículo
        public static List<Poliza> ListarOfrecidas(string tipoVehiculo)
        {
            return PolizaDatos.ListarOfrecidas(tipoVehiculo);
        }

        // La póliza empieza en la fecha propuesta, o hoy si esa fecha ya pasó
        public static DateTime CalcularInicio(Poliza ofrecida)
        {
            if (ofrecida.FechaInicio != null && ofrecida.FechaInicio.Value > DateTime.Today)
            {
                return ofrecida.FechaInicio.Value;
            }
            return DateTime.Today;
        }

        // Texto con el detalle de una póliza ofrecida: lo muestran MisPolizas y AltaOficina
        public static string DescribirOferta(Poliza poliza)
        {
            DateTime inicio = CalcularInicio(poliza);

            return poliza.Aseguradora + " · " + poliza.TipoCobertura + "\n\n" +
                   "Prima " + poliza.TipoPrima.ToLower() + ": $ " + poliza.Prima.ToString("N2") +
                   (poliza.Descuento > 0 ? " (" + poliza.Descuento.ToString("0.##") + " % de descuento)" : "") + "\n" +
                   poliza.CantidadCuotas + " cuotas de $ " + poliza.MontoCuota.ToString("N2") + " · " + poliza.FormaPago + "\n" +
                   "Franquicia: $ " + poliza.Franquicia.ToString("N2") + "\n" +
                   "Vigencia: " + inicio.ToString("dd/MM/yyyy") + " al " + inicio.AddMonths(poliza.Duracion).ToString("dd/MM/yyyy") + " (" + poliza.Duracion + " meses)\n" +
                   (poliza.Adicionales != "" ? "Adicionales: " + poliza.Adicionales + "\n" : "") +
                   (poliza.Requisitos != "" ? "Requisitos: " + poliza.Requisitos : "");
        }

        // Arma las cuotas: la primera vence el día de inicio y las demás cada "MesesPorCuota" meses
        public static List<Pago> CalcularCuotas(Poliza poliza, DateTime inicio)
        {
            List<Pago> cuotas = new List<Pago>();

            for (int i = 0; i < poliza.CantidadCuotas; i++)
            {
                Pago cuota = new Pago()
                {
                    Cuota = i + 1,
                    FechaVencimiento = inicio.AddMonths(i * poliza.MesesPorCuota),
                    Monto = poliza.MontoCuota
                };
                cuotas.Add(cuota);
            }
            return cuotas;
        }

        // Verificación de requisitos: lo que tiene que cumplir un vehículo para contratar la póliza ofrecida
        public static bool VerificarRequisitos(Poliza ofrecida, Vehiculo vehiculo, out string mensaje)
        {
            mensaje = "";

            if (ofrecida == null || ofrecida.Estado != "Ofrecida")
            {
                mensaje = "La póliza elegida ya no está disponible.";
                return false;
            }

            if (!ofrecida.AseguradoraActiva)
            {
                mensaje = "La aseguradora de esa póliza está dada de baja.";
                return false;
            }

            if (vehiculo == null)
            {
                mensaje = "Seleccione uno de sus vehículos.";
                return false;
            }

            if (vehiculo.EstadoRevision != "Aprobado")
            {
                mensaje = "El vehículo " + vehiculo.Dominio + " todavía no fue aprobado por un empleado.";
                return false;
            }

            if (vehiculo.NroPoliza != 0)
            {
                mensaje = "El vehículo " + vehiculo.Dominio + " ya tiene la póliza vigente " + vehiculo.PolizaTexto + ".";
                return false;
            }

            if (!vehiculo.VtvVigente)
            {
                mensaje = "El vehículo " + vehiculo.Dominio + " tiene la VTV vencida. Actualícela antes de contratar una póliza.";
                return false;
            }

            if (vehiculo.TipoVehiculo != ofrecida.TipoVehiculo)
            {
                mensaje = "Esa póliza es para " + ofrecida.TipoVehiculo + " y su vehículo es " + vehiculo.TipoVehiculo + ".";
                return false;
            }

            return true;
        }

        // Alta de la póliza del cliente con sus cuotas
        public static bool Adquirir(int nroOfrecida, int idVehiculo, out int nroNueva, out string mensaje)
        {
            mensaje = "";
            nroNueva = 0;
            int legajo = Sesion.UsuarioActual.Legajo;

            if (Sesion.UsuarioActual.Perfil != "Cliente")
            {
                mensaje = "Solo un cliente puede adquirir pólizas.";
                return false;
            }

            Poliza ofrecida = PolizaDatos.BuscarPorNro(nroOfrecida);

            // BuscarPorId con el legajo asegura que el vehículo sea del cliente
            Vehiculo vehiculo = VehiculoDatos.BuscarPorId(idVehiculo, legajo);

            if (!VerificarRequisitos(ofrecida, vehiculo, out mensaje))
            {
                return false;
            }

            DateTime inicio = CalcularInicio(ofrecida);
            DateTime vencimiento = inicio.AddMonths(ofrecida.Duracion);
            List<Pago> cuotas = CalcularCuotas(ofrecida, inicio);

            nroNueva = PolizaDatos.AdquirirPoliza(nroOfrecida, idVehiculo, legajo, inicio, vencimiento, cuotas);
            if (nroNueva == 0)
            {
                mensaje = "No se pudo contratar la póliza.";
                return false;
            }

            Registrar("Adquirió póliza", "Póliza " + nroNueva.ToString("000000") + " · " + vehiculo.Dominio);
            return true;
        }

        // ================= Comunes =================

        private static void Registrar(string accion, string detalle)
        {
            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Pólizas", accion, detalle);
        }

        // Montos: saca "$" y los puntos de miles: "$ 45.000,50" -> "45000,50"
        public static string LimpiarNumero(string texto)
        {
            return texto.Replace("$", "").Replace(".", "").Trim();
        }

        // Porcentajes: saca "%" y acepta punto o coma decimal: "12.5 %" -> "12,5"
        private static string LimpiarPorcentaje(string texto)
        {
            return texto.Replace("%", "").Replace(".", ",").Trim();
        }
    }
}
