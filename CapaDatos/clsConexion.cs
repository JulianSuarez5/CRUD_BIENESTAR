using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsConexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;

        private static clsConexion Con = null;

        private clsConexion()
        {
            this.Base = "Bienestar";
            this.Servidor = "Velez77\\SQLEXPRESS";
            this.Usuario = "JuanJose";
            this.Clave = "Juan2005";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                           "; Database=" + this.Base +
                                           ";User Id=" + this.Usuario +
                                           "; Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static clsConexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new clsConexion();
            }
            return Con;
        }
    }
}
