using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI.Entidades
{
    public class Tarifa
    {
        public string IdTarifaVuelos { get; set; }
        public string TipoPasajero { get; set; }
        public string Clase { get; set; }
        public int Disponibilidad { get; set; }
        public decimal Precio { get; set; }

    }
}
