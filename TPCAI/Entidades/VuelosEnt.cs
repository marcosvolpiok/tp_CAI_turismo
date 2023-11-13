using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI.Entidades
{
    public class VuelosEnt
    {
        public string CodigoVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaArribo { get; set; }
        public int TiempoVuelo { get; set; }
        public string Aerolinea { get; set; }
        public string IdVuelo { get; set; }
        public List<Tarifa> Tarifas { get; set; }
    }
}
