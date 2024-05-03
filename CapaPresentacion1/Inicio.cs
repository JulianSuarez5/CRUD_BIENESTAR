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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void menumantenedor_Click(object sender, EventArgs e)
        {
            /*Login login = new Login();
            login.Show();*/
            frmAdministrador administracion = frmAdministrador.Ventana_Unica();
            administracion.MdiParent = this;
            administracion.Show();
            administracion.BringToFront();
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            frmRegistro registro = frmRegistro.Ventana_Unica();
            registro.MdiParent = this;
            registro.Show();
            registro.BringToFront();
        }

        private void menuInfoActividades_Click(object sender, EventArgs e)
        {
            frmInfoActividades infoActividades = new frmInfoActividades();
            infoActividades.MdiParent = this;
            infoActividades.Show();
            infoActividades.BringToFront();
        }
    }
}
