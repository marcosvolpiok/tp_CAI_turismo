using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI.Almacenes;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;

namespace TPCAI.Modulos
{
    public static class ModuloReservas
    {
        public static ConcurrentDictionary<int, List<Pasajero>> diccionarioPresupuestoPasajero { get; set; } = new ConcurrentDictionary<int, List<Pasajero>>();
        public static List<ReservasEnt> reservas { get; set; } //Rerecencia viva de las reservas


        internal static void guardarPasajeroAPresupuestoActivo(List<Pasajero> pasajeros)
        {
            diccionarioPresupuestoPasajero = new ConcurrentDictionary<int, List<Pasajero>>();

            foreach (Pasajero pasajero in pasajeros)
            {
                object value = diccionarioPresupuestoPasajero.AddOrUpdate(
                ModuloPresupuestos.ObtengoPresupuestoActivo(),
                new List<Pasajero> { pasajero },
                (key, existingList) =>
                    {
                        existingList.Add(pasajero);
                        return existingList;
                    }
                );
            }
        }

        public static void GenerarPreReserva(int codigoPresupuesto)
        {
            // Validar que el EstadoPresupuesto no sea "Guardada"
            var presupuesto = ModuloPresupuestos.Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == codigoPresupuesto);

            if (presupuesto != null && presupuesto.EstadoPresupuesto != "Guardado")
            {
                List<Pasajero> pasajeros = diccionarioPresupuestoPasajero[ModuloPresupuestos.PresupuestoActivo.CodigoPresupuesto];


                //Verifica si cada vuelo tiene stock suficiente
                foreach (string vuelo1 in ModuloPresupuestos.PresupuestoActivo.IdTarifaVuelo)
                {
                    int totalvuelo = 0;
                    foreach (string vuelo2 in ModuloPresupuestos.PresupuestoActivo.IdTarifaVuelo)
                    {
                        if (vuelo1 == vuelo2)
                        {
                            totalvuelo++;
                        }
                    }

                    Tarifa tarifa = ProductosModulo.ObtenerTarifaRefPorIdTarifa(vuelo1);
                    VuelosEnt vuelo = ProductosModulo.ObtenerVueloPorId(vuelo1);
                    if(totalvuelo > tarifa.Disponibilidad)
                    {
                        MessageBox.Show("El vuelo " + vuelo.Origen + " " + vuelo.Destino + " (ID Tarifa: "+vuelo1+") no posee stock suficiente. Solicitados: "+totalvuelo+". Disponible: "+ tarifa.Disponibilidad);
                    }
                }





                //Verifica si cada alojamiento tiene stock suficiente
                foreach (int habitacion1 in ModuloPresupuestos.PresupuestoActivo.IDHabitacion)
                {
                    int totalhabitacion = 0;
                    foreach (int habitacion2 in ModuloPresupuestos.PresupuestoActivo.IDHabitacion)
                    {
                        if (habitacion1 == habitacion2)
                        {
                            totalhabitacion++;
                        }
                    }

                    HabitacionesHotelSubClass habitacion = ProductosModulo.ObtenerAlojamientoRefPorIdHabitacion(habitacion1);
                    Alojamiento alojamiento = ProductosModulo.ObtenerAlojamientoPorIdHabitacionIndividual(habitacion1);

                    if (totalhabitacion > habitacion.Cantidad)
                    {
                        MessageBox.Show("La habitación " + alojamiento.Nombre + " (ID Habitación: " + habitacion1 + ") no posee stock suficiente. Solicitados: " + totalhabitacion + ". Disponible: " + habitacion.Cantidad);
                    }
                }



                // Crear nueva reserva
                var nuevaReserva = new ReservasEnt
                {
                    CodigoReserva = ObtenerNuevoCodigoReserva(),
                    Presupuesto = codigoPresupuesto,
                    EstadoReserva = "Pre reservada",
                    Cobro = false,
                    FechaReservaConfirmada = null,
                    Pasajeros = pasajeros
                };

                ModuloReservas.reservas.Add(nuevaReserva);

                presupuesto.EstadoPresupuesto = "Guardado";
                

                //Baja stock de vuelos
                foreach(string vuelo in ModuloPresupuestos.PresupuestoActivo.IdTarifaVuelo)
                {
                    Tarifa tarifa = ProductosModulo.ObtenerTarifaRefPorIdTarifa(vuelo);
                    tarifa.Disponibilidad--;
                }

                //Baja stock de Alojamientos
                foreach (int IDHabitacion in ModuloPresupuestos.PresupuestoActivo.IDHabitacion)
                {
                    HabitacionesHotelSubClass habitacion = ProductosModulo.ObtenerAlojamientoRefPorIdHabitacion(IDHabitacion);
                    habitacion.Cantidad--;
                }


                MessageBox.Show("Presupuesto guardado y Reserva en Estado Pre Reservada creada");
            }
            else
            {
                MessageBox.Show("El presupuesto seleccionado está en estado 'Guardado'. No se puede generar la pre reserva.");
            }
        }

        private static int ObtenerNuevoCodigoReserva()
        {
            return reservas.Max(r => r.CodigoReserva) + 1;
        }

        public static List<ReservasEnt> BuscarPreReservas(int codigoPresupuesto)
        {
            // Obtengo reservas con EstadoReserva = "Pre reservada" para el presupuesto dado
            var reservasPreReservadas = reservas
            .Where(r => r.Presupuesto == codigoPresupuesto && r.EstadoReserva == "Pre reservada")
            .ToList();

            return reservasPreReservadas;
        }

        public static List<ReservasEnt> BuscarReservasAConfirmar(int codigoPresupuesto)
        {
            // Obtengo reservas con EstadoReserva = "Pendiente de pago" para el presupuesto dado
            var reservasPreReservadas = reservas
            .Where(r => r.Presupuesto == codigoPresupuesto && (r.EstadoReserva == "Pendiente de pago" || r.EstadoReserva == "Pagado"))
            .ToList();

            return reservasPreReservadas;
        }

        public static void GenerarReservaPendPago(int codReserva)
        {
            var reserva = reservas.FirstOrDefault(r => r.CodigoReserva == codReserva);

            if (reserva != null && reserva.EstadoReserva == "Pre reservada")
            {
                reserva.EstadoReserva = "Pendiente de pago";
                MessageBox.Show("Se ha cambiado el estado de la reserva a Pendiente de pago");
            }
            else
            {
                MessageBox.Show("La reserva no existe o su estado no es 'Pre reservada'. No se pudo actualizar.");
            }
        }

        internal static void GenerarReservaConfirmada(int codReserva)
        {
            var reserva = reservas.FirstOrDefault(r => r.CodigoReserva == codReserva);

            if (reserva != null && reserva.EstadoReserva == "Pagado")
            {
                if (reserva.EstadoReserva != "Confirmada")
                {
                    reserva.EstadoReserva = "Confirmada";
                    reserva.FechaReservaConfirmada = DateTime.Now;
                    MessageBox.Show("La reserva ha sido confirmada");
                }
                else
                {
                    MessageBox.Show("La reserva ya está confirmada, no hay nada que confirmar nuevamente");
                }
            }
            else
            {
                MessageBox.Show("La reserva aún no se encuentra pagada, no se puede confirmar");
            }
        }
    }
}
