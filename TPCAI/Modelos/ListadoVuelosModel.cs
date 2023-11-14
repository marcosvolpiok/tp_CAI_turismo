using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Modulos;
using TPCAI.Entidades.SubClasses;
using TPCAI.Almacenes;
using TPCAI.Modelos;
using TPCAI.Modulos;

namespace TPCAI.Modelos
{
    internal class ListadoVuelosModel
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaIda { get; set; }
        public DateTime FechaVuelta { get; set; }
        public int CantAdultos { get; set; }
        public int CantMenores { get; set; }
        public int CantInfantes { get; set; }
        public string Clase { get; set; }

        public List<Vuelo> VuelosFiltrados { get; set; }

        public void BuscarVuelos()
        {
            // Realiza la búsqueda de vuelos y guarda los resultados en VuelosFiltrados.
            VuelosFiltrados = new List<Vuelo>();
            VuelosFiltrados = ProductosModulo.BusquedaVuelos(this);            
        }

        public void AgregarVueloAPresupuesto(string vueloId)
        {
            Vuelo vuelo = VuelosFiltrados.Find(v => v.IdTarifaVuelos == vueloId);
            if (vuelo != null)
            {
                ModuloPresupuestos.AgregarVueloAPresupuesto(vuelo);                
            }
        }


        public int PresupuestoActivo()
        {
            var presupuestoActivo = ModuloPresupuestos.ObtengoPresupuestoActivo();
            return presupuestoActivo;
        }
    }
}
