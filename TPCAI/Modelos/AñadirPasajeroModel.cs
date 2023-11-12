using System;
using System.Collections.Concurrent;
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
    internal class AñadirPasajeroModel
    {
        public PresupuestosEnt ObtenerPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo;
        }

        public void GuardarPasajeros(List<Pasajero> pasajeros)
        {
                ModuloReservas.guardarPasajeroAPresupuestoActivo(pasajeros);
        }

        public ConcurrentDictionary<int, List<Pasajero>> ObtenerPasajerosPresupuestos()
        {
            return ModuloReservas.diccionarioPresupuestoPasajero;
        }

        public string ObtenerHabitacionNombre(int IDHabitacion)
        {
            Alojamiento habitacion = ProductosModulo.ObtenerAlojamientoPorIdHabitacionIndividual(IDHabitacion);
            if (habitacion != null)
            {
                string nombreHabitacion = "Hotel: " + habitacion.Nombre + ", Habitación: " + habitacion.Disponibilidad[0].Nombre;

                return nombreHabitacion;
            }
            return null;
        }

        public string ObtenerVueloNombre(string IDVuelo)
        {
            VuelosEnt vuelo = ProductosModulo.ObtenerVueloPorId(IDVuelo);
            if (vuelo != null)
            {
                string nombreVuelo = "Vuelo: "+ vuelo.Origen + "-" + vuelo.Destino +", Aerolinea: " + vuelo.Aerolinea + ", Clase: " + vuelo.Tarifas[0].Clase + ", Tipo Pasajero: " + vuelo.Tarifas[0].TipoPasajero;

                return nombreVuelo;
            }
            return null;
        }
    }
}
