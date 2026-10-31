using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // El cliente ve sus avisos y, al abrirlos, quedan leídos.
    // El empleado ve lo que tiene para evaluar y, debajo, los avisos de los clientes (sin marcarlos).
    internal class NotificacionNegocio
    {
        // Se llama al iniciar sesión
        public static void GenerarAvisos()
        {
            NotificacionDatos.GenerarNotificaciones();
        }

        // Aviso de un reclamo: "El expediente 000033 " + texto
        public static void AvisarSiniestro(Siniestro siniestro, string texto)
        {
            NotificacionDatos.CrearNotificacion(siniestro.NroPoliza, "Siniestro", "El expediente " + siniestro.ExpedienteTexto + " " + texto);
        }

        public static string[] TiposDe(string perfil)
        {
            if (perfil == "Empleado")
            {
                return new string[] { "Todos", "Siniestro por evaluar", "Vehículo por evaluar", "Por vencer", "Cuota impaga", "Siniestro" };
            }

            return new string[] { "Todos", "Por vencer", "Cuota impaga", "Siniestro" };
        }

        // soloNuevas: al cliente le deja las no leídas; al empleado, lo pendiente
        public static List<Notificacion> Listar(string tipo, bool soloNuevas)
        {
            Persona usuario = Sesion.UsuarioActual;
            List<Notificacion> todas = new List<Notificacion>();

            if (usuario.Perfil == "Empleado")
            {
                todas.AddRange(NotificacionDatos.ListarPendientes());
                if (!soloNuevas)
                {
                    todas.AddRange(NotificacionDatos.ListarTodas());
                }
            }
            else
            {
                foreach (Notificacion notificacion in NotificacionDatos.ListarDeCliente(usuario.Legajo))
                {
                    if (!soloNuevas || !notificacion.Leida)
                    {
                        todas.Add(notificacion);
                    }
                }
            }

            List<Notificacion> lista = new List<Notificacion>();

            foreach (Notificacion notificacion in todas)
            {
                if (tipo == "Todos" || notificacion.Tipo == tipo)
                {
                    lista.Add(notificacion);
                }
            }

            return lista;
        }

        // Lo que se muestra en el menú: avisos sin leer del cliente o pendientes del empleado
        public static int ContarNuevas()
        {
            Persona usuario = Sesion.UsuarioActual;

            if (usuario.Perfil == "Empleado")
            {
                return NotificacionDatos.ContarPendientes();
            }

            return NotificacionDatos.ContarSinLeerCliente(usuario.Legajo);
        }

        // Solo cuenta lo que abre el cliente. Devuelve true si el aviso pasó a leído.
        // Abrir un aviso no queda en el historial de acciones.
        public static bool MarcarLeida(Notificacion notificacion)
        {
            Persona usuario = Sesion.UsuarioActual;

            if (usuario.Perfil != "Cliente" || notificacion.Leida)
            {
                return false;
            }

            if (!NotificacionDatos.MarcarLeida(notificacion.IdNotificacion, usuario.Legajo))
            {
                return false;
            }

            notificacion.Leida = true;
            return true;
        }
    }
}
