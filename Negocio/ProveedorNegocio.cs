using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    internal class ProveedorNegocio
    {
        public static List<Proveedor> ListarProveedores(string buscar)
        {
            return ProveedorDatos.ListarProveedores(buscar.Trim());
        }

        public static Proveedor BuscarPorId(int idProveedor)
        {
            return ProveedorDatos.BuscarPorId(idProveedor);
        }

        // Si proveedor.IdProveedor es 0 la crea; si no, guarda los cambios.
        // La comision llega como texto ("12" o "12,5") y se valida aca.
        public static bool GuardarProveedor(Proveedor proveedor, string comisionTexto, out string mensaje)
        {
            mensaje = "";
            decimal comision;

            if (proveedor.Nombre == "" || proveedor.RegistroSSN == "" || proveedor.Cuit == "" || proveedor.TiposSeguro == "" ||
                proveedor.Telefono == "" || proveedor.Email == "" || comisionTexto == "" ||
                proveedor.Direccion == "" || proveedor.Provincia == "" || proveedor.Ciudad == "")
            {
                mensaje = "Complete todos los campos (el sitio web es opcional).";
                return false;
            }

            // CUIT: 11 números, con o sin guiones. Se guarda siempre como 30-12345678-9
            string cuitNumeros = proveedor.Cuit.Replace("-", "");
            if (cuitNumeros.Length != 11 || !SoloNumeros(cuitNumeros))
            {
                mensaje = "El CUIT debe tener 11 números (por ejemplo 30-12345678-9).";
                return false;
            }
            proveedor.Cuit = cuitNumeros.Substring(0, 2) + "-" + cuitNumeros.Substring(2, 8) + "-" + cuitNumeros.Substring(10, 1);

            if (!decimal.TryParse(comisionTexto.Replace("%", "").Trim(), out comision) || comision < 0 || comision > 100)
            {
                mensaje = "La comisión debe ser un número entre 0 y 100.";
                return false;
            }
            proveedor.Comision = comision;

            if (!SoloNumeros(proveedor.Telefono))
            {
                mensaje = "El teléfono debe contener solo números.";
                return false;
            }

            if (!proveedor.Email.Contains("@") || !proveedor.Email.Contains("."))
            {
                mensaje = "Ingrese un email válido.";
                return false;
            }

            if (ProveedorDatos.ExisteCuit(proveedor.Cuit, proveedor.IdProveedor))
            {
                mensaje = "Ya existe una aseguradora registrada con ese CUIT.";
                return false;
            }

            if (proveedor.IdProveedor == 0)
            {
                proveedor.IdProveedor = ProveedorDatos.CrearProveedor(proveedor);

                if (proveedor.IdProveedor == 0)
                {
                    mensaje = "No se pudo registrar la aseguradora.";
                    return false;
                }

                Registrar("Registró aseguradora", proveedor.Nombre);
            }
            else
            {
                if (!ProveedorDatos.EditarProveedor(proveedor))
                {
                    mensaje = "No se pudieron guardar los cambios.";
                    return false;
                }

                Registrar("Modificó aseguradora", proveedor.Nombre);
            }

            return true;
        }

        // Activa -> Inactiva (dar de baja) o Inactiva -> Activa (reactivar).
        // Una aseguradora inactiva no puede ofrecer pólizas nuevas.
        public static bool DarDeBajaOReactivar(Proveedor proveedor)
        {
            bool nuevoEstado = !proveedor.Activo;

            if (!ProveedorDatos.CambiarActivo(proveedor.IdProveedor, nuevoEstado))
            {
                return false;
            }

            Registrar(nuevoEstado ? "Reactivó aseguradora" : "Dio de baja aseguradora", proveedor.Nombre);
            return true;
        }

        private static void Registrar(string accion, string nombre)
        {
            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Proveedores", accion, nombre);
        }

        private static bool SoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
