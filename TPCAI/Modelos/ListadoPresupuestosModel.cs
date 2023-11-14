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
            List <Vuelo> vuelosPresupuesto = new List <Vuelo>();

            foreach (string vuelo in  ModuloPresupuestos.PresupuestoActivo.IdTarifaVuelo)
            {
                VuelosEnt vueloEntNuevo = ProductosModulo.ObtenerVueloPorId(vuelo);
                vuelosPresupuesto.Add(new Vuelo(
                                        vueloEntNuevo.Origen,
                                        vueloEntNuevo.Destino,
                                        vueloEntNuevo.FechaSalida,
                                        vueloEntNuevo.FechaArribo,
                                        vueloEntNuevo.Aerolinea,
                                        vueloEntNuevo.Tarifas[0].Precio,
                                        vueloEntNuevo.Tarifas[0].Clase,
                                        vueloEntNuevo.Tarifas[0].TipoPasajero,
                                        vueloEntNuevo.Tarifas[0].IdTarifaVuelos
                                    ));
            }

            return vuelosPresupuesto;
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
            CiudadesEnt ciudades = ProductosModulo.ciudades;
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

        internal string NombreCliente()
        {
            if (ModuloPresupuestos.PresupuestoActivo.Clientes != null)
            {
                return ModuloPresupuestos.PresupuestoActivo.Clientes.Nombre + " " + ModuloPresupuestos.PresupuestoActivo.Clientes.Apellido;
             }

            return "-";
        }

        internal string DniClilente()
        {
            if (ModuloPresupuestos.PresupuestoActivo.Clientes != null)
            {
                return ModuloPresupuestos.PresupuestoActivo.Clientes.DNI.ToString() ;
            }

            return "-";
        }
        public PresupuestosEnt ObtenerPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo;
        }
    }
}
