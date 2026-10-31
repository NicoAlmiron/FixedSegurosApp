using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    internal class SiniestroNegocio
    {
        public const int MaximoFotos = 5;
        public const int MaximoFormularios = 3;

        public static readonly string[] Tipos =
        {
            "Choque", "Robo total", "Robo parcial", "Incendio", "Granizo", "Daño a terceros", "Otro"
        };

        public static readonly string[] Estados =
        {
            "Todos", "Pendiente", "En evaluación", "Aprobado", "Rechazado"
        };

        // ================= Cargar un reclamo (Cliente, o Empleado en la oficina) =================

        public static List<Siniestro> ListarReclamosDe(int legajoCliente)
        {
            return SiniestroDatos.ListarDeCliente(legajoCliente);
        }

        // Las pólizas del cliente que pueden recibir un reclamo nuevo.
        // Al corregir un reclamo (nroActual) se agrega su póliza aunque ya no esté vigente.
        public static List<Poliza> ListarPolizasParaReclamo(int legajoCliente, int nroActual)
        {
            List<Poliza> lista = new List<Poliza>();

            foreach (Poliza poliza in PolizaDatos.ListarPolizasDeCliente(legajoCliente))
            {
                if (EstaVigente(poliza) || poliza.NroPoliza == nroActual)
                {
                    lista.Add(poliza);
                }
            }

            return lista;
        }

        // El vehículo asegurado por la póliza, para mostrar el bien afectado
        public static Vehiculo BuscarVehiculoDe(Poliza poliza, int legajoCliente)
        {
            return VehiculoDatos.BuscarPorId(poliza.IdVehiculo, legajoCliente);
        }

        // Si siniestro.IdSiniestro es 0 inicia el reclamo; si no, guarda la corrección.
        // fotosNuevas y denunciaNueva vienen vacías si el cliente no eligió otras.
        // El cliente deja el reclamo Pendiente. El empleado lo carga con el cliente en la oficina y ya vio
        // la documentación, por eso pasa directo a En evaluación y queda como responsable.
        public static bool GuardarReclamo(Siniestro siniestro, int legajoCliente, string montoTexto, List<byte[]> fotosNuevas, byte[] denunciaNueva, out string mensaje)
        {
            Persona usuario = Sesion.UsuarioActual;
            bool esEmpleado = usuario.Perfil == "Empleado";
            bool esNuevo = siniestro.IdSiniestro == 0;

            // el cliente carga lo suyo; el empleado, el de cualquier cliente
            if (!esEmpleado && !(usuario.Perfil == "Cliente" && usuario.Legajo == legajoCliente))
            {
                mensaje = "Solo el cliente o un empleado pueden cargar un reclamo.";
                return false;
            }

            if (esEmpleado && !esNuevo)
            {
                mensaje = "Un reclamo ya iniciado solo lo corrige el cliente.";
                return false;
            }

            if (!ValidarDatos(siniestro, montoTexto, out mensaje))
            {
                return false;
            }

            Poliza poliza = BuscarPolizaDelCliente(siniestro.NroPoliza, legajoCliente);

            if (poliza == null)
            {
                mensaje = "Elija una de sus pólizas.";
                return false;
            }

            if (esNuevo && !EstaVigente(poliza))
            {
                mensaje = "Solo se puede iniciar un reclamo sobre una póliza vigente.";
                return false;
            }

            if (siniestro.FechaOcurrencia.Date > DateTime.Today)
            {
                mensaje = "La fecha del hecho no puede ser futura.";
                return false;
            }

            if (siniestro.FechaOcurrencia.Date < poliza.FechaInicio.Value.Date || siniestro.FechaOcurrencia.Date > poliza.FechaVencimiento.Value.Date)
            {
                mensaje = "La fecha del hecho debe estar dentro de la vigencia de la póliza (" +
                          poliza.FechaInicio.Value.ToString("dd/MM/yyyy") + " al " + poliza.FechaVencimiento.Value.ToString("dd/MM/yyyy") + ").";
                return false;
            }

            // si no eligió fotos o denuncia nuevas, valen las que ya están guardadas
            int cantidadFotos = fotosNuevas.Count > 0 ? fotosNuevas.Count : siniestro.CantidadFotos;
            bool tieneDenuncia = denunciaNueva != null || siniestro.CantidadDenuncias > 0;

            if (cantidadFotos < 1 || cantidadFotos > MaximoFotos)
            {
                mensaje = "Adjunte de 1 a " + MaximoFotos + " fotos del daño o del lugar del hecho.";
                return false;
            }

            if (!tieneDenuncia)
            {
                mensaje = "Adjunte la denuncia.";
                return false;
            }

            List<AdjuntoSiniestro> adjuntos = new List<AdjuntoSiniestro>();
            foreach (byte[] foto in fotosNuevas)
            {
                adjuntos.Add(new AdjuntoSiniestro() { Tipo = "Foto", Imagen = foto });
            }
            if (denunciaNueva != null)
            {
                adjuntos.Add(new AdjuntoSiniestro() { Tipo = "Denuncia", Imagen = denunciaNueva });
            }

            if (esNuevo)
            {
                siniestro.Estado = esEmpleado ? "En evaluación" : "Pendiente";
                siniestro.IdSiniestro = SiniestroDatos.CrearSiniestro(siniestro, adjuntos, esEmpleado ? usuario.Legajo : 0);

                if (siniestro.IdSiniestro == 0)
                {
                    mensaje = "No se pudo guardar el reclamo.";
                    return false;
                }

                AccionDatos.RegistrarAccion(usuario.Legajo, "Siniestros", "Inició reclamo", "Expediente " + siniestro.ExpedienteTexto);
                return true;
            }

            if (!SiniestroDatos.EditarSiniestro(siniestro, adjuntos, legajoCliente))
            {
                mensaje = "No se pudo guardar: el reclamo ya no está Pendiente.";
                return false;
            }

            AccionDatos.RegistrarAccion(usuario.Legajo, "Siniestros", "Modificó reclamo", "Expediente " + siniestro.ExpedienteTexto);
            return true;
        }

        // ================= Revisión del Empleado =================

        public static List<Siniestro> ListarSiniestros(string estado)
        {
            return SiniestroDatos.ListarSiniestros(estado);
        }

        // El formulario solo lo ven el empleado y el administrador
        public static List<AdjuntoSiniestro> ListarAdjuntos(int idSiniestro, string tipo)
        {
            if (tipo == "Formulario" && Sesion.UsuarioActual.Perfil == "Cliente")
            {
                return new List<AdjuntoSiniestro>();
            }

            return SiniestroDatos.ListarAdjuntos(idSiniestro, tipo);
        }

        // El empleado carga el formulario cuando el reclamo está En evaluación. Reemplaza al anterior.
        public static bool CargarFormulario(Siniestro siniestro, List<byte[]> fotos, out string mensaje)
        {
            mensaje = "";

            if (Sesion.UsuarioActual.Perfil != "Empleado")
            {
                mensaje = "Solo un empleado puede cargar el formulario.";
                return false;
            }

            if (fotos.Count < 1 || fotos.Count > MaximoFormularios)
            {
                mensaje = "El formulario lleva de 1 a " + MaximoFormularios + " fotos.";
                return false;
            }

            List<AdjuntoSiniestro> formulario = new List<AdjuntoSiniestro>();
            foreach (byte[] foto in fotos)
            {
                formulario.Add(new AdjuntoSiniestro() { Tipo = "Formulario", Imagen = foto });
            }

            if (!SiniestroDatos.GuardarFormulario(siniestro.IdSiniestro, formulario, Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudo guardar: el reclamo ya no está En evaluación.";
                return false;
            }

            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Siniestros", "Cargó formulario", "Expediente " + siniestro.ExpedienteTexto);
            return true;
        }

        public static bool GuardarObservaciones(Siniestro siniestro, string observaciones, out string mensaje)
        {
            if (!ValidarObservaciones(observaciones, out mensaje))
            {
                return false;
            }

            if (!SiniestroDatos.GuardarObservaciones(siniestro.IdSiniestro, observaciones.Trim(), Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudieron guardar las observaciones: el reclamo ya está resuelto.";
                return false;
            }

            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Siniestros", "Guardó observaciones", "Expediente " + siniestro.ExpedienteTexto);
            return true;
        }

        // Los tres controles de la guía son obligatorios para que el reclamo pase a la aseguradora
        public static bool PasarAEvaluacion(Siniestro siniestro, bool fotosLegibles, bool denunciaRecibida, bool polizaCoincide, string observaciones, out string mensaje)
        {
            if (!ValidarObservaciones(observaciones, out mensaje))
            {
                return false;
            }

            if (!fotosLegibles || !denunciaRecibida || !polizaCoincide)
            {
                mensaje = "Marque los tres controles de la documentación para pasar a evaluación.";
                return false;
            }

            if (!SiniestroDatos.PasarAEvaluacion(siniestro.IdSiniestro, observaciones.Trim(), Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudo pasar a evaluación: el reclamo ya no está Pendiente.";
                return false;
            }

            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Siniestros", "Verificó documentación", "Expediente " + siniestro.ExpedienteTexto);
            return true;
        }

        // La aseguradora aprobó el reclamo: solo desde En evaluación
        public static bool Aprobar(Siniestro siniestro, string observaciones, out string mensaje)
        {
            if (!ValidarObservaciones(observaciones, out mensaje))
            {
                return false;
            }

            if (siniestro.Estado != "En evaluación")
            {
                mensaje = "Solo se puede aprobar un reclamo en evaluación.";
                return false;
            }

            if (SiniestroDatos.ListarAdjuntos(siniestro.IdSiniestro, "Formulario").Count == 0)
            {
                mensaje = "Cargue el formulario para poder aprobar el reclamo.";
                return false;
            }

            return Resolver(siniestro, "Aprobado", "Aprobó reclamo", observaciones, out mensaje);
        }

        // Se rechaza con motivo obligatorio, en revisión (Pendiente) o por la aseguradora (En evaluación)
        public static bool Rechazar(Siniestro siniestro, string observaciones, out string mensaje)
        {
            if (!ValidarObservaciones(observaciones, out mensaje))
            {
                return false;
            }

            if (observaciones.Trim() == "")
            {
                mensaje = "Escriba el motivo del rechazo en las observaciones.";
                return false;
            }

            if (siniestro.EstaResuelto)
            {
                mensaje = "El reclamo ya está resuelto.";
                return false;
            }

            return Resolver(siniestro, "Rechazado", "Rechazó reclamo", observaciones, out mensaje);
        }

        private static bool Resolver(Siniestro siniestro, string resultado, string accion, string observaciones, out string mensaje)
        {
            mensaje = "";

            if (!SiniestroDatos.Resolver(siniestro.IdSiniestro, siniestro.Estado, resultado, observaciones.Trim(), Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudo guardar: el reclamo cambió de estado.";
                return false;
            }

            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Siniestros", accion, "Expediente " + siniestro.ExpedienteTexto);
            return true;
        }

        // ================= Validaciones =================

        private static bool ValidarDatos(Siniestro siniestro, string montoTexto, out string mensaje)
        {
            mensaje = "";

            siniestro.Ubicacion = siniestro.Ubicacion.Trim();
            siniestro.Descripcion = siniestro.Descripcion.Trim();

            if (Array.IndexOf(Tipos, siniestro.TipoSiniestro) < 0)
            {
                mensaje = "Elija el tipo de siniestro.";
            }
            else if (siniestro.Ubicacion == "" || siniestro.Ubicacion.Length > 100)
            {
                mensaje = "Ingrese la ubicación del hecho (hasta 100 caracteres).";
            }
            else if (siniestro.Descripcion == "" || siniestro.Descripcion.Length > 450)
            {
                mensaje = "Ingrese una descripción breve (hasta 450 caracteres).";
            }
            else
            {
                decimal monto;
                if (!decimal.TryParse(PolizaNegocio.LimpiarNumero(montoTexto), out monto) || monto <= 0)
                {
                    mensaje = "Ingrese el valor aproximado del daño.";
                }
                else
                {
                    siniestro.MontoReclamado = monto;
                }
            }

            return mensaje == "";
        }

        private static bool ValidarObservaciones(string observaciones, out string mensaje)
        {
            mensaje = "";

            if (observaciones.Trim().Length > 200)
            {
                mensaje = "Las observaciones pueden tener hasta 200 caracteres.";
                return false;
            }

            return true;
        }

        private static bool EstaVigente(Poliza poliza)
        {
            return poliza.EstadoMostrado == "Vigente" || poliza.EstadoMostrado == "Por vencer";
        }

        private static Poliza BuscarPolizaDelCliente(int nroPoliza, int legajo)
        {
            foreach (Poliza poliza in PolizaDatos.ListarPolizasDeCliente(legajo))
            {
                if (poliza.NroPoliza == nroPoliza)
                {
                    return poliza;
                }
            }

            return null;
        }
    }
}
