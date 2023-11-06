using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Modulos;
using TPCAI.Entidades.SubClasses;
using TPCAI.Almacenes;
using TPCAI.Modelos;

namespace TPCAI.Modelos
{
    public class ListadoVuelosModel
    {

        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaIda { get; set; }
        public DateTime FechaVuelta { get; set; }
        public int CantAdultos { get; set; }
        public int CantMenores { get; set; }
        public int CantInfantes { get; set; }
        public string Clase { get; set; }

        public List<Vuelo> VuelosFiltrados { get; private set; }

        public void BuscarVuelos()
        {
            // Realiza la búsqueda de vuelos y guarda los resultados en VuelosFiltrados.
            VuelosFiltrados = ProductosModulo.BusquedaVuelos(this);
        }
    }
}
