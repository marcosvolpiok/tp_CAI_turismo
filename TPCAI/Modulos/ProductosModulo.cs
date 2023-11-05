using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI;

namespace TPCAI
{
    class ProductosModulo
    {
        public static List<AlojamientosEnt> Alojamientos = AlojamientoAlmacen.alojamientos;

        public static List<AlojamientosEnt> ObtenerAlojamientos(
            )
        {
            return Alojamientos;
        }
        public static List<AlojamientosEnt> ObtenerAlojamientosFiltrados(
            string destino,
            string fechaIngreso,
            string fechaEgreso,
            int cantidadAdultos,
            int cantidadMenores,
            int cantidadInfantes,
            int calificacion)
        {
            List<AlojamientosEnt> alojamientosFiltrados = new List<AlojamientosEnt>();
            bool flag1PuntoParaFiltrado;
            bool flag2PuntoParaFiltrado;
            bool flagSalirBucleDeDisponibilidad;
            bool flag3PuntoParaFiltradoRangoFechas;
            DateTime dateTimeFechaIngreso = DateTime.Parse(fechaIngreso);
            DateTime dateTimeFechaEgreso = DateTime.Parse(fechaEgreso);

            foreach (var alojamiento in Alojamientos)
            {
                //MessageBox.Show("adentro de modulo");

                flag1PuntoParaFiltrado = false;
                flag2PuntoParaFiltrado = false;
                flagSalirBucleDeDisponibilidad = false;
                flag3PuntoParaFiltradoRangoFechas = false;


                if (
                    alojamiento.CodigoCiudad == destino &&
                    alojamiento.Calificacion == calificacion
                    )
                {
                    flag1PuntoParaFiltrado = true;
                }





                foreach (var disponibilidad in alojamiento.Disponibilidad)
                {
                    if (flagSalirBucleDeDisponibilidad == true)
                    {
                        break;
                    }

                    if (flag1PuntoParaFiltrado &&
                        disponibilidad.Adultos >= cantidadAdultos &&
                        disponibilidad.Menores >= cantidadMenores &&
                        disponibilidad.Infantes >= cantidadInfantes
                        )
                    {
                        flag2PuntoParaFiltrado = true;
                    }
                    //}



                    //recorro fechas
                    //recorro disponibilidades
                    //si disponibilidad está dentro de fecha
                    //evalúo si tiene stock
                    //si tiene stock la marco como ok
                    //marco flag de que entró a este if
                    //si no tiene stock
                    //no marco el flag
                    //sale del bucle



                    for (DateTime date = dateTimeFechaIngreso; date <= dateTimeFechaEgreso; date = date.AddDays(1))
                    {
                        flag3PuntoParaFiltradoRangoFechas = false;
                        flagSalirBucleDeDisponibilidad = false;

                        //foreach (var disponibilidad in alojamiento.Disponibilidad)
                        //{
                        foreach (var habitacion in disponibilidad.Habitaciones)
                        {
                            /*
                            if (flagSalirBucleDeDisponibilidad == true) {
                                break;
                            }
                            */

                            if (VerificarSiEstaFechaEstáDentroDelRango(habitacion.FechaHabitacionHotel, dateTimeFechaIngreso, dateTimeFechaEgreso))
                            {
                                if (habitacion.Cantidad > 0)
                                {
                                    flag3PuntoParaFiltradoRangoFechas = true;
                                    //break;
                                }
                                else
                                {
                                    //MessageBox.Show("sale del bucle - fehca que no esta en la db: " + habitacion.FechaHabitacionHotel);

                                    flag3PuntoParaFiltradoRangoFechas = false;
                                    flagSalirBucleDeDisponibilidad = true;
                                    break;
                                }
                            }
                        }
                    }
                }


                if (flag1PuntoParaFiltrado && flag2PuntoParaFiltrado && flag3PuntoParaFiltradoRangoFechas == true && flagSalirBucleDeDisponibilidad == false)
                {
                    alojamientosFiltrados.Add(alojamiento);
                }
            }
            return alojamientosFiltrados;
        }

        private static bool VerificarSiEstaFechaEstáDentroDelRango(DateTime fechaEnCuestion, DateTime rangoInit, DateTime rangoEnd)
        {
            for (DateTime date = rangoInit; date <= rangoEnd; date = date.AddDays(1))
            {
                if (
                    fechaEnCuestion == date
                )
                { //Esta fecha está dentro del rango
                    return true;
                }
            }

            return false;
        }
    }
}
