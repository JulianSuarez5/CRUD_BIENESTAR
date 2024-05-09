using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion1
{
    public partial class frmRegistro : Form
    {
        private static frmRegistro instancia = null;
        public static frmRegistro Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmRegistro();
            }
            return instancia;
        }
        /*private clsD_Usuarios datosUsuarios;
        private clsD_Actividades datosActividades;*/
        public frmRegistro()
        {
            InitializeComponent();
            /*datosUsuarios = new clsD_Usuarios();
            datosActividades = new clsD_Actividades();
            CargarActividades();*/
        }


        /*private void CargarActividades()
{
cboActividad.DataSource = datosActividades.LeerActividades();
cboActividad.DisplayMember = "Nombre";
cboActividad.ValueMember = "ActividadID";
}

private void btnRegistrar_Click(object sender, EventArgs e)
{
if (ValidarCampos())
{
string carnet = txtCarnet.Text.Trim();
string nombre = txtNombre.Text.Trim();
string apellido = txtApellido.Text.Trim();
string tipoUsuario = "Estudiante";
string correo = txtCorreo.Text.Trim();
int idActividad = Convert.ToInt32(cboActividad.SelectedValue);

bool resultado = datosUsuarios.CrearUsuario(carnet, nombre, apellido, tipoUsuario, correo);

if (resultado)
{
// Registrar la inscripción del estudiante en la actividad seleccionada
bool inscripcionExitosa = RegistrarInscripcionActividad(carnet, idActividad);

if (inscripcionExitosa)
{
MessageBox.Show("Registro exitoso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
LimpiarCampos();
}
else
{
MessageBox.Show("Error al registrar la inscripción en la actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
else
{
MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
private bool ValidarCampos()
{
if (string.IsNullOrWhiteSpace(txtCarnet.Text) ||
string.IsNullOrWhiteSpace(txtNombre.Text) ||
string.IsNullOrWhiteSpace(txtApellido.Text) ||
string.IsNullOrWhiteSpace(txtCorreo.Text) ||
cboActividad.SelectedValue == null)
{
MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
return false;
}

return true;
}
private bool RegistrarInscripcionActividad(string carnet, int idActividad)
{
// Lógica para registrar la inscripción del estudiante en la actividad seleccionada
// Puedes crear un método en la clase clsD_Inscripciones para realizar esta operación
return true; // Reemplaza con el valor adecuado según el resultado de la operación
}
private void LimpiarCampos()
{
txtCarnet.Clear();
txtNombre.Clear();
txtApellido.Clear();
txtCorreo.Clear();
cboActividad.SelectedIndex = -1;
}
}*/
    }
}
