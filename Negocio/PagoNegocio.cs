using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // Reglas de Pagos. El cliente ve las pantallas de pago (todavía simuladas);
    // el empleado cobra en la oficina, y solo el efectivo registra el pago
    internal class PagoNegocio
    {
        // Lo guardo como constante para no escribir el texto a mano en cada lugar
        public const string Efectivo = "Efectivo";

        // Los métodos de pago que existen
        public static readonly string[] Metodos =
        {
            "Débito automático", "Tarjeta de crédito", "Transferencia bancaria", Efectivo
        };

        // Las pólizas del cliente, para el combo de Pagos
        public static List<Poliza> ListarPolizasDe(int legajoCliente)
        {
            return PolizaDatos.ListarPolizasDeCliente(legajoCliente);
        }

        // Las cuotas de la póliza elegida
        public static List<Pago> ListarCuotas(int nroPoliza, int legajoCliente)
        {
            return PagoDatos.ListarCuotas(nroPoliza, legajoCliente);
        }

        // Los métodos que puede usar quien inició sesión para esa póliza. El efectivo solo se cobra en la oficina:
        // un cliente nunca lo ve, y si la póliza es solo en efectivo la lista queda vacía
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
        // Las cuotas se pagan en orden: esta es la única que se puede pagar
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

        // Controlo el pago y lo registro. El N° de operación es el idPago de la cuota
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

            // vuelvo a leer las cuotas de la base: con el legajo me aseguro de que la póliza sea de ese cliente
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

        // Cobro en la oficina: el empleado escribe lo que le dio el cliente, y tiene que alcanzar para la cuota
        public static bool CobrarEnEfectivo(Poliza poliza, Pago cuota, decimal recibido, int legajoCliente, out string mensaje)
        {
            mensaje = "";

            if (Sesion.UsuarioActual.Perfil != "Empleado")
            {
                mensaje = "Solo un empleado puede cobrar en efectivo.";
                return false;
            }

            if (recibido < cuota.Monto)
            {
                mensaje = "El monto recibido no alcanza para pagar la cuota.";
                return false;
            }

            return Pagar(poliza, cuota.IdPago, Efectivo, legajoCliente, out mensaje);
        }
    }
}
