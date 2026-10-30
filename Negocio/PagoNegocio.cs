using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // El cliente paga sus cuotas desde la app; el empleado las cobra en la oficina (ahí se acepta efectivo)
    internal class PagoNegocio
    {
        public const string Efectivo = "Efectivo";

        // Métodos de pago que existen
        public static readonly string[] Metodos =
        {
            "Débito automático", "Tarjeta de crédito", "Transferencia bancaria", Efectivo
        };

        public static List<Poliza> ListarPolizasDe(int legajoCliente)
        {
            return PolizaDatos.ListarPolizasDeCliente(legajoCliente);
        }

        public static List<Pago> ListarCuotas(int nroPoliza, int legajoCliente)
        {
            return PagoDatos.ListarCuotas(nroPoliza, legajoCliente);
        }

        // Métodos que puede usar quien inició sesión para esa póliza. El efectivo solo se cobra en la oficina:
        // un cliente nunca lo ve, y si la póliza es solo en efectivo la lista queda vacía.
        public static List<string> MetodosDe(Poliza poliza)
        {
            List<string> lista = new List<string>();

            foreach (string metodo in Metodos)
            {
                bool loAceptaLaPoliza = poliza.FormaPago == "Todas las formas de pago" || poliza.FormaPago == metodo;
                bool estaHabilitado = metodo != Efectivo || Sesion.UsuarioActual.Perfil == "Empleado";

                if (loAceptaLaPoliza && estaHabilitado)
                {
                    lista.Add(metodo);
                }
            }
            return lista;
        }

        // La primera cuota sin pagar, o null si están todas pagadas.
        // Las cuotas se pagan en orden: esta es la única que se puede pagar.
        public static Pago ProximaCuota(List<Pago> cuotas)
        {
            foreach (Pago cuota in cuotas)
            {
                if (!cuota.Pagada)
                {
                    return cuota;
                }
            }
            return null;
        }

        // Verifica el pago y lo registra. El N° de operación es el idPago de la cuota.
        public static bool Pagar(Poliza poliza, int idPago, string metodoPago, int legajoCliente, out string mensaje)
        {
            mensaje = "";
            Persona usuario = Sesion.UsuarioActual;

            // el cliente paga lo suyo; el empleado cobra a cualquier cliente
            if (usuario.Perfil != "Empleado" && !(usuario.Perfil == "Cliente" && usuario.Legajo == legajoCliente))
            {
                mensaje = "Solo el cliente o un empleado pueden registrar el pago de una cuota.";
                return false;
            }

            if (!MetodosDe(poliza).Contains(metodoPago))
            {
                mensaje = "Seleccione un método de pago aceptado por la póliza.";
                return false;
            }

            // se vuelven a leer las cuotas: el legajo asegura que la póliza sea de ese cliente
            List<Pago> cuotas = ListarCuotas(poliza.NroPoliza, legajoCliente);
            Pago proxima = ProximaCuota(cuotas);

            if (proxima == null)
            {
                mensaje = "La póliza no tiene cuotas pendientes.";
                return false;
            }

            if (proxima.IdPago != idPago)
            {
                mensaje = "Las cuotas se pagan en orden: primero debe pagar la cuota " + proxima.Cuota + ".";
                return false;
            }

            if (!PagoDatos.RegistrarPago(idPago, metodoPago, legajoCliente))
            {
                mensaje = "No se pudo registrar el pago.";
                return false;
            }

            AccionDatos.RegistrarAccion(usuario.Legajo, "Pagos", "Registró pago", "Cuota " + proxima.Cuota + ", póliza " + poliza.NroTexto + " · " + metodoPago);
            return true;
        }
    }
}
