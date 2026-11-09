using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // Reglas de Proveedores (aseguradoras), solo el administrador.
    // Negocio valida lo que llega de la pantalla, aplica las reglas, llama a Datos y registra la acción en el historial. No escribe SQL.
    internal class ProveedorNegocio
    {
        // Lista para la grilla con el texto de búsqueda
        public static List<Proveedor> ListarProveedores(string buscar)
        {
            return ProveedorDatos.ListarProveedores(buscar.Trim());
        }

        // Una aseguradora por id
        public static Proveedor BuscarPorId(int idProveedor)
        {
            return ProveedorDatos.BuscarPorId(idProveedor);
        }

        // Si proveedor.IdProveedor es 0 la creo; si no, guardo los cambios. Antes valido todos los datos
        public static bool GuardarProveedor(Proveedor proveedor, out string mensaje)
        {
            mensaje = "";

            if (proveedor.Nombre == "" || proveedor.RegistroSSN == "" || proveedor.Cuit == "" || proveedor.TiposSeguro == "" ||
                proveedor.Telefono == "" || proveedor.Email == "" ||
                proveedor.Direccion == "" || proveedor.Provincia == "" || proveedor.Ciudad == "")
            {
                mensaje = "Complete todos los campos (el sitio web es opcional).";
                return false;
            }

            // CUIT: 11 números, con o sin guiones. Lo guardo siempre como 30-12345678-9
            string cuitNumeros = proveedor.Cuit.Replace("-", "");
            if (cuitNumeros.Length != 11 || !SoloNumeros(cuitNumeros))
            {
                mensaje = "El CUIT debe tener 11 números (por ejemplo 30-12345678-9).";
                return false;
            }
            proveedor.Cuit = cuitNumeros.Substring(0, 2) + "-" + cuitNumeros.Substring(2, 8) + "-" + cuitNumeros.Substring(10, 1);

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
        // Una aseguradora inactiva no puede ofrecer pólizas nuevas
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

        // Dejo la acción en el historial, en el módulo Proveedores
        private static void Registrar(string accion, string nombre)
        {
            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Proveedores", accion, nombre);
        }

        // true si el texto tiene solo dígitos
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
