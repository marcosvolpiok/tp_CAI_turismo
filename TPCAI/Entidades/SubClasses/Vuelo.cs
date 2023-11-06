using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI.Entidades.SubClasses
{
    public class Vuelo
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaArribo { get; set; }
        public string Aerolinea { get; set; }
        public decimal Precio { get; set; }
        public string Clase { get; set; }
        public string TipoPasajero { get; set; }

        public Vuelo(string origen, string destino, DateTime fechaSalida, DateTime fechaArribo, string aerolinea, decimal precio, string clase, string tipoPasajero)
        {
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            FechaArribo = fechaArribo;
            Aerolinea = aerolinea;
            Precio = precio;
            Clase = clase;
            TipoPasajero = tipoPasajero;
        }
    }
}
