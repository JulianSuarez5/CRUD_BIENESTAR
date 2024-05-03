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
        private static frmAdministrador instancia = null;
        public static frmAdministrador Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmAdministrador();
            }
            return instancia;
        }
        public frmAdministrador()
        {
            InitializeComponent();
        }
    }
}
