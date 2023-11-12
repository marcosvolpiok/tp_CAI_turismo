using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool validarPasajerosDeDataGridView(ListView listViewPasajeros)
        {
            string patternSololetras = "^[a-zA-ZáéíóúüñÁÉÍÓÚÜÑ ]+$";

            foreach (ListViewItem item in listViewPasajeros.Items)
            {
                //DNI: solo números
                //DNI: menor a 100.000.000
                //DNI: mayor a 999.999
                if (item.SubItems[2].Text == "" || item.SubItems[2].Text == null)
                {
                    MessageBox.Show("vacio - Documento ingresado inválido por favor volver a ingresar");

                    return false;
                }

                if (long.TryParse(item.SubItems[2].Text, out long resultDNI))
                {
                    if (resultDNI < 0)
                    {
                        MessageBox.Show("< 0 - Documento ingresado inválido por favor volver a ingresar");

                        return false;
                    }

                    if (resultDNI < 1000000)
                    {
                        MessageBox.Show("< 1000000 - Documento ingresado inválido por favor volver a ingresar");

                        return false;
                    }

                    if (resultDNI > 100000000)
                    {
                        MessageBox.Show(" > 100000000 - Documento ingresado inválido por favor volver a ingresar");

                        return false;
                    }
                }


                //Nombre: no vacío ni nulo
                //solo letras
                if (item.SubItems[0].Text == "" || item.SubItems[0].Text == null)
                {
                    MessageBox.Show("Nombre inválido porfavor volver a ingresar");

                    return false;
                }


                if (!Regex.IsMatch(item.SubItems[0].Text, patternSololetras))
                {
                    MessageBox.Show("Nombre - No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo.");

                    return false;
                }


                //Apellido: no vacío ni nulo
                //solo letras
                if (item.SubItems[1].Text == "" || item.SubItems[1].Text == null)
                {
                    MessageBox.Show("Apellido inválido porfavor volver a ingresar");

                    return false;
                }


                if (!Regex.IsMatch(item.SubItems[1].Text, patternSololetras))
                {
                    MessageBox.Show("Apellido No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo.");

                    return false;
                }

                //Nombre: solo letras, espacios

                //Apellido: solo letras, espacios

                //Fecha de nacimiento: inferior a este momento

                //Fecha de nacimiento: que concuerde con el total de máximos del producto
            }

            return true;
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
