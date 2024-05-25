using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion1
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Recoger los valores de los TextBox y ComboBox
            string carnet = txtCarnet.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string TipoUsuario = cboTipoUsuario.SelectedItem.ToString(); 
            string correo = txtCorreo.Text;
            string programa = cboPrograma.SelectedItem.ToString(); 
            string actividad = cboActividad.SelectedItem.ToString(); 

            // Crear una instancia de clsD_Usuarios
            clsD_Usuarios datosUsuario = new clsD_Usuarios();

            try
            {
                // Intentar crear el usuario con los nuevos parámetros
                bool resultado = datosUsuario.CrearUsuario(carnet, nombre, apellido, correo, programa, actividad, TipoUsuario);

                if (resultado)
                {
                    MessageBox.Show("Usuario registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
