using System;
using System.Data;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    internal class Conexion
    {
        // La cadena de conexión se lee de la variable de entorno FIXEDSEGUROS_BD,
        // así no queda escrita en el código. Si no existe, usa el SQL Server Express local.
        private string conString = Environment.GetEnvironmentVariable("FIXEDSEGUROS_BD")
                                   ?? "Server=localhost\\SQLEXPRESS;Database=fixedsegurosbd;Trusted_Connection=True;";
        private SqlConnection conx;

        public Conexion()
        {
            conx = new SqlConnection(conString);
        }

        public SqlConnection AbrirConexion()
        {
            if (conx.State == ConnectionState.Closed)
            {
                conx.Open();
            }
            return conx;
        }

        public void CerrarConexion()
        {
            if (conx.State == ConnectionState.Open)
            {
                conx.Close();
            }
        }

        // Devuelve true si se puede conectar al servidor
        public static bool ProbarConexion()
        {
            bool conectado = false;

            Conexion conexion = new Conexion();

            try
            {
                conexion.AbrirConexion();
                conectado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return conectado;
        }
    }
}
