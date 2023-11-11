using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;
using TPCAI.Modulos;

namespace TPCAI.Modelos
{
    internal class ListadoPresupuestosModel
    {
        public void EliminarAlojamientoDelPresupuesto (int IDHabitacion)
        {
            ModuloPresupuestos.EliminarAlojamientoDeActivo(IDHabitacion);
        }
        public void EliminarVueloDelPresupuesto(string vueloId)
        {
            ModuloPresupuestos.EliminarVueloDeActivo(vueloId);
        }

        public List<Vuelo> ObtenerVuelosPresupuesto()
        {
            /*
             * TO DO: este código no compila.
             * Marcos lo comentó para poder probar esta pantalla con Alojamientos.
             * 
             * 
            var vuelosIds = ModuloPresupuestos.PresupuestoActivo.IdTarifaVuelo;
            var vuelos = new List<Vuelo>();
            foreach(var vueloId in vuelosIds)
            {                
                Vuelo vuelo = ProductosModulo.ObtenerVueloPorId(vueloId);
                vuelos.Add(vuelo);
            }

            return vuelos;
            */

            List<Vuelo> listaVuelos = new List<Vuelo>(); //TO DO: esto es para que compile. Mirar comentario de arriba
            return listaVuelos;
        }

        public List<Alojamiento> ObtenerAlojamientosPresupuesto()
        {
            List<int> alojamientosIds = ModuloPresupuestos.PresupuestoActivo.IDHabitacion;
            
            var alojamientosNuevos = new List<Alojamiento>();
            foreach (var alojamientoId in alojamientosIds)
            {
                List<Alojamiento> alojamientos = ProductosModulo.ObtenerAlojamientoPorIdHabitacion(alojamientoId);
                foreach (Alojamiento alojamiento in alojamientos)
                {
                    alojamientosNuevos.Add(alojamiento);
                }
                
            }

            return alojamientosNuevos;
        }

        internal decimal ImporteTotalAlojamientos()
        {
            return 0M; //TODO: lo mismo que vuelos.
        }


        internal decimal ImporteTotalVuelos()
        {
            /* TO DO: Comentado por Marcos para poder probar porque al abrir el formulario tira error
             * REVISAR
             * 
             * 
            var vuelosIds = ModuloPresupuestos.PresupuestoActivo.IdTarifaVuelo;
            decimal importe = 0M;
            foreach (var vueloId in vuelosIds)
            {
                Vuelo vuelo = ProductosModulo.ObtenerVueloPorId(vueloId);
                importe += vuelo.Precio;
            }

            return importe;
            */

            return 0;
        }

        public CiudadesDetailSubClass obtenerCiudadPorCodigo(string codigoCiudad)
        {
            CiudadesEnt ciudades = ProductosModulo.obtenerCiudades();
            foreach (CiudadesDetailSubClass ciudad in ciudades.Ciudades)
            {
                if (ciudad.CodigoISO == codigoCiudad)
                {
                    return ciudad;
                }
            }

            MessageBox.Show("Código de ciudad " + codigoCiudad + " no encontrado");
            CiudadesDetailSubClass ciudadVacia = new CiudadesDetailSubClass();
            ciudadVacia.Nombre = "-";
            return ciudadVacia;
        }

        internal string NombreCliente() => ModuloPresupuestos.PresupuestoActivo.Clientes.Nombre;
        internal long DniClilente() => ModuloPresupuestos.PresupuestoActivo.Clientes.DNI;
    }
}
