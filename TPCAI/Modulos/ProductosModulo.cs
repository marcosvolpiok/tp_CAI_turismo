using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI;
using TPCAI.Almacenes;
using TPCAI.Entidades.SubClasses;
using TPCAI.Entidades;
using TPCAI.Modelos;

namespace TPCAI
{
    public static class ProductosModulo
    {
        public static List<Alojamiento> ObtenerAlojamientos(
            )
        {
            List<Alojamiento> alojamientosEncontrados = new List<Alojamiento>();
            List<AlojamientosEnt> alojamientos = AlojamientoAlmacen.alojamientos;

            foreach (AlojamientosEnt alojamiento in alojamientos)
            {
                alojamientosEncontrados.Add(new Alojamiento(
                    alojamiento.CodigoHotel,
                    alojamiento.Nombre,
                    alojamiento.CodigoCiudad,
                    alojamiento.Direccion,
                    alojamiento.Calificacion,
                    alojamiento.Disponibilidad
                    ));
            }
            return alojamientosEncontrados;
        }

        public static List<Alojamiento> ObtenerAlojamientosFiltrados(
            ListadoAlojamientosModelo alojamientosModel
            )
        {
            // Creo una lista para almacenar los alojamientos filtrados
            List<Alojamiento> alojamientosFiltrados = new List<Alojamiento>();

            // Obtengo los vuelos desde el Almacén de Alojamientos.
            List<AlojamientosEnt> alojamientos = AlojamientoAlmacen.alojamientos;

            bool flag1PuntoParaFiltrado;
            bool flag2PuntoParaFiltrado;
            bool flagSalirBucleDeDisponibilidad;
            bool flag3PuntoParaFiltradoRangoFechas;
            DateTime dateTimeFechaIngreso = DateTime.Parse(alojamientosModel.fechaIngreso);
            DateTime dateTimeFechaEgreso = DateTime.Parse(alojamientosModel.fechaEgreso);

            int intCantidadAdultos = int.Parse(alojamientosModel.cantidadAdultos);

            int intCantidadMenores;
            if (alojamientosModel.cantidadMenores != "")
            {
                intCantidadMenores = int.Parse(alojamientosModel.cantidadMenores);
            }
            else {
                intCantidadMenores = 0;
            }

            int intCantidadInfantes;
            if (alojamientosModel.cantidadInfantes != "")
            {
                intCantidadInfantes = int.Parse(alojamientosModel.cantidadInfantes);
            }
            else
            {
                intCantidadInfantes = 0;
            }

            int intCalificacion;
            if (alojamientosModel.calificacion != "") {
                intCalificacion = int.Parse(alojamientosModel.calificacion);
            }
            else
            {
                intCalificacion = 0;
            }

            foreach (var alojamiento in AlojamientoAlmacen.Alojamientos)
            {
                flag1PuntoParaFiltrado = false;
                flag2PuntoParaFiltrado = false;
                flagSalirBucleDeDisponibilidad = false;
                flag3PuntoParaFiltradoRangoFechas = false;

                if (
                    alojamiento.CodigoCiudad == alojamientosModel.destino &&
                    (alojamientosModel.calificacion == "" || (alojamientosModel.calificacion != "" && alojamiento.Calificacion == intCalificacion))
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
                        (alojamientosModel.cantidadMenores == "" || (alojamientosModel.cantidadMenores != "" && disponibilidad.Menores >= intCantidadMenores)) &&
                        (alojamientosModel.cantidadInfantes == "" || (alojamientosModel.cantidadInfantes != "" && disponibilidad.Infantes >= intCantidadInfantes))
                        )
                    {
                        flag2PuntoParaFiltrado = true;
                    }

                    for (DateTime date = dateTimeFechaIngreso; date <= dateTimeFechaEgreso; date = date.AddDays(1))
                    {
                        if (flagSalirBucleDeDisponibilidad == true)
                        {
                            break;
                        }

                        flag3PuntoParaFiltradoRangoFechas = false;
                        flagSalirBucleDeDisponibilidad = false;

                        foreach (var habitacion in disponibilidad.Habitaciones)
                        {
                            if (habitacion.FechaHabitacionHotel == date && 
                                VerificarSiEstaFechaEstáDentroDelRango(habitacion.FechaHabitacionHotel, dateTimeFechaIngreso, dateTimeFechaEgreso))
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

                        if (flag3PuntoParaFiltradoRangoFechas == false) {
                            flag3PuntoParaFiltradoRangoFechas = false;
                            flagSalirBucleDeDisponibilidad = true;
                            break;
                        }
                    }
                }

                if (flag1PuntoParaFiltrado && flag2PuntoParaFiltrado && flag3PuntoParaFiltradoRangoFechas == true && flagSalirBucleDeDisponibilidad == false)
                {
                    alojamientosFiltrados.Add(new Alojamiento(
                                        alojamiento.CodigoHotel,
                                        alojamiento.Nombre,
                                        alojamiento.CodigoCiudad,
                                        alojamiento.Direccion,
                                        alojamiento.Calificacion,
                                        alojamiento.Disponibilidad
                                    ));
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


        // BUSQUEDA VUELOS
        internal static List<Vuelo> BusquedaVuelos(ListadoVuelosModel vuelosModel)
        {


            // Creo una lista para almacenar los vuelos filtrados
            List<Vuelo> vuelosEncontrados = new List<Vuelo>();

            // Obtengo los vuelos desde el AlmacenVuelos.
            List<VuelosEnt> vuelos = AlmacenVuelos.vuelos;


            foreach (var vueloEnt in vuelos)
            {
                if (vueloEnt.Origen == vuelosModel.Origen &&
                    vueloEnt.Destino == vuelosModel.Destino &&
                    vueloEnt.FechaSalida.Date == vuelosModel.FechaIda.Date ||
                    vueloEnt.FechaSalida.Date == vuelosModel.FechaVuelta.Date)
                {
                    if (vueloEnt.Tarifas != null) // Compruebo si Tarifa no es nulo
                    {
                        var tarifas = vueloEnt.Tarifas
                            .Where(tarifa =>
                                (vuelosModel.CantAdultos == 0 || (tarifa.TipoPasajero == "A" && vuelosModel.CantAdultos <= tarifa.Disponibilidad)) &&
                                (vuelosModel.CantMenores == 0 || (tarifa.TipoPasajero == "M" && vuelosModel.CantMenores <= tarifa.Disponibilidad)) &&
                                (vuelosModel.CantInfantes == 0 || (tarifa.TipoPasajero == "I" && vuelosModel.CantInfantes <= tarifa.Disponibilidad)) &&
                                tarifa.Clase == vuelosModel.Clase);

                        // Verifico si 'tarifas' no es nulo y si contiene elementos antes de iterar sobre ella.
                        if (tarifas != null && tarifas.Any())
                        {
                            // Creo un vuelo para cada tipo de pasajero y agrego a la lista de vuelos filtrados
                            foreach (var tipoPasajero in tarifas.Select(tarifa => tarifa.TipoPasajero).Distinct())
                            {
                                var tarifaParaPasajero = tarifas.FirstOrDefault(tarifa => tarifa.TipoPasajero == tipoPasajero);
                                if (tarifaParaPasajero != null)
                                {
                                    vuelosEncontrados.Add(new Vuelo(
                                        vueloEnt.Origen,
                                        vueloEnt.Destino,
                                        vueloEnt.FechaSalida,
                                        vueloEnt.FechaArribo,
                                        vueloEnt.Aerolinea,
                                        tarifaParaPasajero.Precio,
                                        vuelosModel.Clase,
                                        tarifaParaPasajero.TipoPasajero,
                                        tarifaParaPasajero.IdTarifaVuelos // Agrego el IdTarifaVuelos
                                    ));
                                }
                            }
                        }
                    }
                }
            }
            return vuelosEncontrados;

        }

        internal static Vuelo ObtenerVueloPorId(string vuelosId) => throw new NotImplementedException();

        internal static List<Alojamiento> ObtenerAlojamientoPorIdHabitacion (int idHabitacion)
        {
            List<AlojamientosEnt> alojamientos = AlojamientoAlmacen.alojamientos;
            List<Alojamiento> alojamientosFiltrados = new List<Alojamiento>();


            foreach (var alojamiento in alojamientos)
            {
                foreach (var disponibilidad in alojamiento.Disponibilidad)
                {
                    foreach(var habitacion in disponibilidad.Habitaciones)
                    {
                        if (habitacion.IDHabitacion == idHabitacion)
                        {
                            List<DisponibilidadSubClass> disponibilidades = new List<DisponibilidadSubClass>();
                            DisponibilidadSubClass disponibilidadNuevo = new DisponibilidadSubClass();
                            disponibilidadNuevo.Nombre = disponibilidad.Nombre;
                            disponibilidadNuevo.Tarifa = disponibilidad.Tarifa;
                            disponibilidadNuevo.Capacidad = disponibilidad.Capacidad;
                            disponibilidadNuevo.Adultos = disponibilidad.Adultos;
                            disponibilidadNuevo.Menores = disponibilidad.Menores;
                            disponibilidadNuevo.Infantes = disponibilidad.Infantes;
                            disponibilidadNuevo.IDDisponibilidad = disponibilidad.IDDisponibilidad;
                            disponibilidadNuevo.Habitaciones = new List<HabitacionesHotelSubClass>();

                            List<HabitacionesHotelSubClass> habitaciones = new List<HabitacionesHotelSubClass>();
                            HabitacionesHotelSubClass habitacionNuevo = new HabitacionesHotelSubClass();
                            habitacionNuevo.IDHabitacion = habitacion.IDHabitacion;
                            habitacionNuevo.FechaHabitacionHotel = habitacion.FechaHabitacionHotel;
                            habitacionNuevo.Cantidad = habitacion.Cantidad;

                            disponibilidadNuevo.Habitaciones.Add(habitacionNuevo);
                            disponibilidades.Add(disponibilidadNuevo);

                            alojamientosFiltrados.Add(new Alojamiento(
                                        alojamiento.CodigoHotel,
                                        alojamiento.Nombre,
                                        alojamiento.CodigoCiudad,
                                        alojamiento.Direccion,
                                        alojamiento.Calificacion,
                                        disponibilidades
                                ));
                        }
                    }
                }
             }

            return alojamientosFiltrados;
         }
    }
}
