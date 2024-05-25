using CapaDatos;
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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarUsuarios()
        {
            clsD_Usuarios datosUsuario = new clsD_Usuarios();
            try
            {
                DataTable usuarios = datosUsuario.LeerUsuarios();
                dgvusuarios.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarUsuarios();
            dgvusuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvusuarios.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            foreach (DataGridViewRow row in dgvusuarios.Rows)
            {
                row.Height = 30;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (dgvusuarios.SelectedRows.Count > 0)
            {
                int usuarioID = Convert.ToInt32(dgvusuarios.SelectedRows[0].Cells["UsuarioID"].Value);
                string carnet = txtCarnet.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string correo = txtCorreo.Text;
                string programa = cboPrograma.Text;
                string actividad = cboActividad.Text;

                clsD_Usuarios datosUsuario = new clsD_Usuarios();
                bool resultado = datosUsuario.ActualizarUsuario(usuarioID, carnet, nombre, apellido, correo, programa, actividad);
                if (resultado)
                {
                    MessageBox.Show("Usuario actualizado con éxito.");
                    CargarUsuarios(); // Recargar los datos en el DataGridView
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvusuarios.SelectedRows.Count > 0)
            {
                int usuarioID = Convert.ToInt32(dgvusuarios.SelectedRows[0].Cells["UsuarioID"].Value);

                clsD_Usuarios datosUsuario = new clsD_Usuarios();
                bool resultado = datosUsuario.EliminarUsuario(usuarioID);
                if (resultado)
                {
                    MessageBox.Show("Usuario eliminado con éxito.");
                    CargarUsuarios(); // Recargar los datos en el DataGridView
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

        private void dgvusuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var W = Properties.Resources.Check_32.Width;
                var h = Properties.Resources.Check_32.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - W) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Check_32, new Rectangle(x, y, W, h));
                e.Handled = true;
            }
        }

        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que se haya hecho doble clic en una fila válida
            {
                DataGridViewRow selectedRow = dgvusuarios.Rows[e.RowIndex];
                txtCarnet.Text = selectedRow.Cells["Carnet"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = selectedRow.Cells["Apellido"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["Correo"].Value.ToString();
                cboPrograma.Text = selectedRow.Cells["Programa"].Value.ToString();
                cboActividad.Text = selectedRow.Cells["Actividad"].Value.ToString();
            }
        }
    }
}
