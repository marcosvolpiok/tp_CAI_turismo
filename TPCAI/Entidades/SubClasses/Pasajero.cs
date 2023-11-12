using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPCAI.Entidades.SubClasses
{
    public class Pasajero
    {
        public int CodigoPasajero { get; set; }
        public string IdTarifaVuelos { get; set; }
        public int IdHabitacion { get; set; }
        public string NombrePasajero { get; set; }
        public string ApellidoPasajero { get; set; }
        public long Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoPasajero { get; set; }
    }

}
