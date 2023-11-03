using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI.Entidades
{
    class VueloEnt
    {
        public long ID { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraArribo { get; set; }
        public string Aerolinea { get; set; }
        public double Precio { get; set; }
        public string ClaseVuelo { get; set; }
        public string TipoPasajero { get; set; }

    }
}
