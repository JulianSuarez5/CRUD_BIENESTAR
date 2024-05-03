using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class clsE_DetalleActividad
    {
        public string NombreActividad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Horario { get; set; }
        public string NombreInstructor { get; set; }
        public string TelefonoInstructor { get; set; }
        public string NombreLugar { get; set; }
        public string DireccionLugar { get; set; }
    }

}
