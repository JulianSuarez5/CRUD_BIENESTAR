using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion1
{
    public partial class Login : Form
    {
        public bool Autenticado { get; private set; } = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtdocumento.Text; 
            string contraseña = txtclave.Text; 

            if (AutenticarAdministrador(nombreUsuario, contraseña))
            {
                Autenticado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
        private bool AutenticarAdministrador(string nombreUsuario, string contraseña)
        {
            // Aquí deberías hashear la contraseña antes de compararla con la base de datos
            string contraseñaHasheada = HashContraseña(contraseña);

            string connectionString = ConfigurationManager.ConnectionStrings["Cadena_Conexion"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Administradores WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseñaHasheada);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private string HashContraseña(string contraseña)
        {
            // Implementa aquí tu lógica de hashing
            return contraseña; // Esto es solo un marcador de posición, no uses contraseñas en texto plano.
        }
    }
}
