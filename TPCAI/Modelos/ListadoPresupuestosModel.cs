using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades.SubClasses;
using TPCAI.Modulos;

namespace TPCAI.Modelos
{
    internal class ListadoPresupuestosModel
    {
        public void EliminarVueloDelPresupuesto(string vueloId)
        {
            ModuloPresupuestos.EliminarVueloDeActivo(vueloId);
        }

        public List<Vuelo> ObtenerVuelosPresupuesto()
        {
            var vuelosIds = ModuloPresupuestos.PresupuestoActivo.IdTarifaVuelo;
            var vuelos = new List<Vuelo>();
            foreach(var vueloId in vuelosIds)
            {                
                Vuelo vuelo = ProductosModulo.ObtenerVueloPorId(vueloId);
                vuelos.Add(vuelo);
            }

            return vuelos;
        }

        internal decimal ImporteTotalAlojamientos()
        {
            return 0M; //TODO: lo mismo que vuelos.
        }


        internal decimal ImporteTotalVuelos()
        {
            var vuelosIds = ModuloPresupuestos.PresupuestoActivo.IdTarifaVuelo;
            decimal importe = 0M;
            foreach (var vueloId in vuelosIds)
            {
                Vuelo vuelo = ProductosModulo.ObtenerVueloPorId(vueloId);
                importe += vuelo.Precio;
            }

            return importe;
        }

        internal string NombreCliente() => ModuloPresupuestos.PresupuestoActivo.Clientes.Nombre;
        internal long DniClilente() => ModuloPresupuestos.PresupuestoActivo.Clientes.DNI;
    }
}
