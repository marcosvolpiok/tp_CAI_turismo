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
            string cantidadAdultos, //--------
            string cantidadMenores,
            string cantidadInfantes,
            string calificacion)
        {
            List<AlojamientosEnt> alojamientosFiltrados = new List<AlojamientosEnt>();
            bool flag1PuntoParaFiltrado;
            bool flag2PuntoParaFiltrado;
            bool flagSalirBucleDeDisponibilidad;
            bool flag3PuntoParaFiltradoRangoFechas;
            DateTime dateTimeFechaIngreso = DateTime.Parse(fechaIngreso);
            DateTime dateTimeFechaEgreso = DateTime.Parse(fechaEgreso);

            int intCantidadAdultos = int.Parse(cantidadAdultos);

            int intCantidadMenores;
            if (cantidadMenores != "")
            {
                intCantidadMenores = int.Parse(cantidadMenores);
            }
            else {
                intCantidadMenores = 0;
            }

            int intCantidadInfantes;
            if (cantidadInfantes != "")
            {
                intCantidadInfantes = int.Parse(cantidadInfantes);
            }
            else
            {
                intCantidadInfantes = 0;
            }

            int intCalificacion;
            if (calificacion != "") {
                intCalificacion = int.Parse(calificacion);
            }
            else
            {
                intCalificacion = 0;
            }

            foreach (var alojamiento in Alojamientos)
            {
                flag1PuntoParaFiltrado = false;
                flag2PuntoParaFiltrado = false;
                flagSalirBucleDeDisponibilidad = false;
                flag3PuntoParaFiltradoRangoFechas = false;

                if (
                    alojamiento.CodigoCiudad == destino &&
                    (calificacion == "" || (calificacion != "" && alojamiento.Calificacion == intCalificacion))
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
                        disponibilidad.Adultos >= intCantidadAdultos &&
                        (cantidadMenores=="" || (cantidadMenores!="" && disponibilidad.Menores >= intCantidadMenores)) &&
                        (cantidadInfantes=="" || (cantidadInfantes!="" && disponibilidad.Infantes >= intCantidadInfantes))
                        )
                    {
                        flag2PuntoParaFiltrado = true;
                    }

                    for (DateTime date = dateTimeFechaIngreso; date <= dateTimeFechaEgreso; date = date.AddDays(1))
                    {
                        flag3PuntoParaFiltradoRangoFechas = false;
                        flagSalirBucleDeDisponibilidad = false;

                        foreach (var habitacion in disponibilidad.Habitaciones)
                        {
                            if (VerificarSiEstaFechaEstáDentroDelRango(habitacion.FechaHabitacionHotel, dateTimeFechaIngreso, dateTimeFechaEgreso))
                            {
                                if (habitacion.Cantidad > 0)
                                {
                                    flag3PuntoParaFiltradoRangoFechas = true;
                                }
                                else
                                {
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
