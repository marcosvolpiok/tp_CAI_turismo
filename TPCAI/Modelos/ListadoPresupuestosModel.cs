using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades.SubClasses;

namespace TPCAI.Modelos
{
    internal class ListadoPresupuestosModel
    {
        private List<Vuelo> vuelosDelPresupuesto = new List<Vuelo>();

        public void AgregarVueloAPresupuesto(Vuelo vuelo)
        {
            vuelosDelPresupuesto.Add(vuelo);
        }

        public void EliminarVueloDelPresupuesto(Vuelo vuelo)
        {
            vuelosDelPresupuesto.Remove(vuelo);
        }

        public List<Vuelo> ObtenerVuelosPresupuesto()
        {
            return vuelosDelPresupuesto;
        }
    }
}
