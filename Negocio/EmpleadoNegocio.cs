using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    internal class EmpleadoNegocio
    {
        public static List<Empleado> ListarEmpleados(string buscar)
        {
            return EmpleadoDatos.ListarEmpleados(buscar.Trim());
        }

        public static Empleado BuscarPorLegajo(int legajo)
        {
            return EmpleadoDatos.BuscarPorLegajo(legajo);
        }

        // Guarda puesto y fecha de ingreso
        public static bool GuardarEmpleado(Empleado empleado, out string mensaje)
        {
            if (!PuedeModificar(empleado.Legajo, out mensaje))
            {
                return false;
            }

            if (empleado.Puesto == "")
            {
                mensaje = "Seleccione el puesto del empleado.";
                return false;
            }

            if (empleado.FechaIngreso > DateTime.Today)
            {
                mensaje = "La fecha de ingreso no puede ser posterior a hoy.";
                return false;
            }

            if (!EmpleadoDatos.EditarEmpleado(empleado))
            {
                mensaje = "No se pudieron guardar los cambios.";
                return false;
            }

            Registrar("Modificó empleado", empleado.Legajo);
            return true;
        }

        // Por habilitar o Deshabilitado -> Habilitado. Necesita tener un puesto asignado.
        public static bool Habilitar(int legajo, out string mensaje)
        {
            if (!PuedeModificar(legajo, out mensaje))
            {
                return false;
            }

            Empleado actual = EmpleadoDatos.BuscarPorLegajo(legajo);

            if (actual.EstadoEmpleado == "Habilitado")
            {
                mensaje = "El empleado ya está habilitado.";
                return false;
            }

            if (actual.Puesto == "Sin asignar")
            {
                mensaje = "Asigne un puesto y guarde los cambios antes de habilitar al empleado.";
                return false;
            }

            EmpleadoDatos.CambiarEstado(legajo, "Habilitado");
            Registrar("Habilitó empleado", legajo);
            return true;
        }

        // Habilitado -> Deshabilitado
        public static bool Deshabilitar(int legajo, out string mensaje)
        {
            if (!PuedeModificar(legajo, out mensaje))
            {
                return false;
            }

            Empleado actual = EmpleadoDatos.BuscarPorLegajo(legajo);

            if (actual.EstadoEmpleado != "Habilitado")
            {
                mensaje = "Solo se puede deshabilitar un empleado que está habilitado.";
                return false;
            }

            EmpleadoDatos.CambiarEstado(legajo, "Deshabilitado");
            Registrar("Deshabilitó empleado", legajo);
            return true;
        }

        // Un empleado dado de baja (en Usuarios) ya no se puede modificar
        private static bool PuedeModificar(int legajo, out string mensaje)
        {
            mensaje = "";

            Empleado actual = EmpleadoDatos.BuscarPorLegajo(legajo);

            if (actual == null)
            {
                mensaje = "No se encontró el empleado.";
                return false;
            }

            if (actual.Estado == "Baja")
            {
                mensaje = "El empleado fue dado de baja y no se puede modificar.";
                return false;
            }

            return true;
        }

        private static void Registrar(string accion, int legajo)
        {
            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Empleados", accion, "Legajo " + legajo.ToString("0000"));
        }
    }
}
