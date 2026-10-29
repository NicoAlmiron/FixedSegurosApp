using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FixedSegurosApp.Datos
{
    internal class EmpleadoDatos
    {
        // Columnas que usan ListarEmpleados y BuscarPorLegajo (en el mismo orden que LeerEmpleado)
        private const string columnas = "SELECT p.idPersona, p.nombre, p.apellido, p.dni, e.puesto, e.fechaIngreso, e.estado, p.estado " +
                                        "FROM Empleado e JOIN Persona p ON p.idPersona = e.idPersona ";

        // Lista para la grilla. Si "buscar" tiene texto, filtra por legajo, DNI o apellido.
        public static List<Empleado> ListarEmpleados(string buscar)
        {
            List<Empleado> lista = new List<Empleado>();

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas +
                               "WHERE @buscar = '' " +
                               "OR p.idPersona = TRY_CAST(@buscar AS INT) " +
                               "OR CAST(p.dni AS VARCHAR(10)) LIKE @buscar + '%' " +
                               "OR p.apellido LIKE '%' + @buscar + '%' " +
                               "ORDER BY p.idPersona";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@buscar", buscar);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    lista.Add(LeerEmpleado(leer));
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return lista;
        }

        // Devuelve null si el legajo no es de un empleado
        public static Empleado BuscarPorLegajo(int legajo)
        {
            Empleado empleado = null;

            Conexion conexion = new Conexion();

            try
            {
                string query = columnas + "WHERE p.idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@legajo", legajo);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    empleado = LeerEmpleado(leer);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return empleado;
        }

        // Guarda puesto y fecha de ingreso
        public static bool EditarEmpleado(Empleado empleado)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Empleado SET puesto = @puesto, fechaIngreso = @fechaIngreso WHERE idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@puesto", empleado.Puesto);
                sql.Parameters.AddWithValue("@fechaIngreso", empleado.FechaIngreso);
                sql.Parameters.AddWithValue("@legajo", empleado.Legajo);

                if (sql.ExecuteNonQuery() > 0)
                {
                    estado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // Por habilitar / Habilitado / Deshabilitado
        public static bool CambiarEstado(int legajo, string nuevoEstado)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Empleado SET estado = @estado WHERE idPersona = @legajo";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@estado", nuevoEstado);
                sql.Parameters.AddWithValue("@legajo", legajo);

                if (sql.ExecuteNonQuery() > 0)
                {
                    estado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }

        // Arma un Empleado con la fila actual del lector
        private static Empleado LeerEmpleado(SqlDataReader leer)
        {
            Empleado empleado = new Empleado()
            {
                Legajo = leer.GetInt32(0),
                Nombre = leer.GetString(1),
                Apellido = leer.GetString(2),
                Dni = leer.GetInt32(3),
                Puesto = leer.GetString(4),
                FechaIngreso = leer.GetDateTime(5),
                EstadoEmpleado = leer.GetString(6),
                Estado = leer.GetString(7)
            };
            return empleado;
        }
    }
}
