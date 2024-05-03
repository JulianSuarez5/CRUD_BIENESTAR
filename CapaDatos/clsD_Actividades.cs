using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class clsD_Actividades
    {
        public DataTable LeerActividades()
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = null;
            try
            {
                conexion = clsConexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("LeerActividades", conexion);
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
        public DataTable LeerActividadesConDetalle()
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = null;
            try
            {
                conexion = clsConexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("LeerActividadesConDetalle", conexion);
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

        public clsE_DetalleActividad ObtenerDetalleActividad(int idActividad)
        {
            clsE_DetalleActividad detalleActividad = new clsE_DetalleActividad();
            SqlConnection conexion = null;
            try
            {
                conexion = clsConexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ObtenerDetalleActividad", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdActividad", idActividad);
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    detalleActividad.NombreActividad = reader["NombreActividad"].ToString();
                    detalleActividad.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                    detalleActividad.FechaFin = Convert.ToDateTime(reader["FechaFin"]);
                    detalleActividad.Horario = reader["Horario"].ToString();
                    detalleActividad.NombreInstructor = reader["NombreInstructor"].ToString();
                    detalleActividad.TelefonoInstructor = reader["TelefonoInstructor"].ToString();
                    detalleActividad.NombreLugar = reader["NombreLugar"].ToString();
                    detalleActividad.DireccionLugar = reader["DireccionLugar"].ToString();
                }
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
            return detalleActividad;
        }
    }
}
