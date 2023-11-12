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

            if (listViewPasajeros.Items.Count == 0)
            {
                MessageBox.Show("Ingrese los pasajeros");

                return false;
            }

            foreach (ListViewItem item in listViewPasajeros.Items)
            {
                //DNI: solo números
                //DNI: menor a 100.000.000
                //DNI: mayor a 999.999
                if (item.SubItems[2].Text == "" || item.SubItems[2].Text == null)
                {
                    MessageBox.Show("Documento ingresado inválido por favor volver a ingresar");

                    return false;
                }

                if (long.TryParse(item.SubItems[2].Text, out long resultDNI))
                {
                    if (resultDNI < 0)
                    {
                        MessageBox.Show("Documento ingresado inválido por favor volver a ingresar");

                        return false;
                    }

                    if (resultDNI < 1000000)
                    {
                        MessageBox.Show("Documento ingresado inválido por favor volver a ingresar");

                        return false;
                    }

                    if (resultDNI > 100000000)
                    {
                        MessageBox.Show("Documento ingresado inválido por favor volver a ingresar");

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
                    MessageBox.Show("No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo.");

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


                //Fecha de nacimiento: inferior a este momento
                if (item.SubItems[3].Text == "" || item.SubItems[3].Text == null)
                {
                    MessageBox.Show("Fecha de nacimiento inválida porfavor volver a ingresar");

                    return false;
                }

                if (DateTime.Parse(item.SubItems[3].Text) > DateTime.Now)
                {
                    MessageBox.Show("Fecha de nacimiento ingresada es posterior al día de la fecha. Por favor, ingrese nuevamente la fecha de nacimiento");

                    return false;
                }

                if ((item.SubItems[4].Text == "" || item.SubItems[4].Text == null) && (item.SubItems[5].Text == "" || item.SubItems[5].Text == null))
                {
                    MessageBox.Show("Debe seleccionar un producto para el pasajero");

                    return false;
                }

                /*
                //Fecha de nacimiento: que concuerde con el total de máximos del producto
                //Si es Hotel
                    //Recorre todo el listview
                        //Si es adulto, suma 1 a totalAdultos
                        //Si es menor, suma 1 a totalMenores
                        //Si es infante, suma 1 a total infantes
                    //Valida que cumpla con los máximos del producto


                //Si es vuelo
                    //Recorre el listview
                        //Si es adulto, suma 1 a totalAdultos
                        //Si es menor, suma 1 a totalMenores
                    //Valida que haya al menos 1 adulto cada 2 menores
                */


                if(item.SubItems[5].Text != "" && item.SubItems[5].Text != null){ //Es Alojamiento
                    int totalAdultos = 0;
                    int totalMenores = 0;
                    int totalInfantes = 0;

                    foreach (ListViewItem itemAlojamiento in listViewPasajeros.Items)
                    {
                        if(item.SubItems[5].Text == itemAlojamiento.SubItems[5].Text) {
                            int edad = calcularEdad(DateTime.Parse(itemAlojamiento.SubItems[3].Text));
                            if(edad >= 18)
                            {
                                totalAdultos++;
                            }else if (edad >= 2)
                            {
                                totalMenores++;
                            }
                            else
                            {
                                totalInfantes++;
                            }
                        }
                    }

                    //Obtener producto
                    Alojamiento habitacion = ProductosModulo.ObtenerAlojamientoPorIdHabitacionIndividual(int.Parse(item.SubItems[5].Text));

                    if (totalAdultos >  habitacion.Disponibilidad[0].Adultos)
                    {
                        MessageBox.Show("Cantidad de adultos excede el total permitido");

                        return false;
                    }

                    if (totalMenores > habitacion.Disponibilidad[0].Menores)
                    {
                        MessageBox.Show("Cantidad de menores excede el total permitido");

                        return false;
                    }

                    if (totalInfantes > habitacion.Disponibilidad[0].Infantes)
                    {
                        MessageBox.Show("Cantidad de infantes excede el total permitido");

                        return false;
                    }
                }

                if (item.SubItems[4].Text != "" && item.SubItems[4].Text != null)
                { //Es Vuelo
                    int totalAdultos = 0;
                    double totalMenores = 0;

                    foreach (ListViewItem itemAlojamiento in listViewPasajeros.Items)
                    {
                        if (item.SubItems[5].Text == itemAlojamiento.SubItems[5].Text)
                        {
                            int edad = calcularEdad(DateTime.Parse(itemAlojamiento.SubItems[3].Text));
                            if (edad >= 18)
                            {
                                totalAdultos++;
                            }
                            else
                            {
                                totalMenores++;
                            }
                        }
                    }

                    if(totalAdultos < (totalMenores/2))
                    {
                        MessageBox.Show("Debe haber al menos 1 adulto por cada 2 menores");

                        return false;
                    }
                }
            }

            return true;
        }

        private int calcularEdad(DateTime nacimiento)
        {
            DateTime currentDate = DateTime.Now;

            int edad = currentDate.Year - nacimiento.Year;

            if (nacimiento.Date > currentDate.AddYears(-edad))
            {
                edad--;
            }

            return edad;
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
