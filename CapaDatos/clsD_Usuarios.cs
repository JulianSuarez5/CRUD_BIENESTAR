using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Usuarios
    {
        public bool CrearUsuario(string carnet, string nombre, string apellido, string tipoUsuario, string correo)
        {
            bool resultado = false;
            SqlConnection conexion = null;
            try
            {
                conexion = clsConexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("CrearUsuario", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Carnet", carnet);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
                comando.Parameters.AddWithValue("@Correo", correo);
                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                throw ex;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }

        public DataTable LeerUsuarios()
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = null;
            try
            {
                conexion = clsConexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("LeerUsuarios", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                tabla.Load(reader);
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                throw ex;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return tabla;
        }

        public bool ActualizarUsuario(int usuarioID, string carnet, string nombre, string apellido, string tipoUsuario, string correo)
        {
            bool resultado = false;
            SqlConnection conexion = null;
            try
            {
                conexion = clsConexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ActualizarUsuario", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@UsuarioID", usuarioID);
                comando.Parameters.AddWithValue("@Carnet", carnet);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
                comando.Parameters.AddWithValue("@Correo", correo);
                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                throw ex;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }

        public bool EliminarUsuario(int usuarioID)
        {
            bool resultado = false;
            SqlConnection conexion = null;
            try
            {
                conexion = clsConexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("EliminarUsuario", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@UsuarioID", usuarioID);
                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                throw ex;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }
    }
}
