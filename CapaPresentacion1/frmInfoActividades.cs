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
    public partial class frmInfoActividades : Form
    {
        public frmInfoActividades()
        {
            InitializeComponent();
        }

        private DataTable ObtenerActividadesConInstructores()
        {
            DataTable dtActividades = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["Cadena_Conexion"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                     SELECT a.Nombre AS Actividad, a.FechaInicio, a.FechaFin, a.Horario, 
                    i.Nombre + ' ' + i.Apellido AS Instructor
                    FROM Actividades a
                    INNER JOIN InstructorActividad ia ON a.ActividadID = ia.ActividadID
                    INNER JOIN Instructores i ON ia.InstructorID = i.InstructorID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtActividades);
                }
            }

            return dtActividades;
        }
        private void frmInfoActividades_Load(object sender, EventArgs e)
        {
            dgvInfoActividades.DataSource = ObtenerActividadesConInstructores();
            dgvInfoActividades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvInfoActividades.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
    }
}
