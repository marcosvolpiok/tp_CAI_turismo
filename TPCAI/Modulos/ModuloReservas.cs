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
                // Crear nueva reserva
                var nuevaReserva = new ReservasEnt
                {
                    CodigoReserva = ObtenerNuevoCodigoReserva(),
                    Presupuesto = codigoPresupuesto,
                    EstadoReserva = "Pre reservada",
                    Cobro = false,
                    FechaReservaConfirmada = null,
                    Pasajeros = null // Puedes inicializar esto según tus necesidades
                };

                // Agregar la nueva reserva al AlmacenReservas
                AlmacenReservas.AgregarReserva(nuevaReserva);
                //AlmacenReservas.Grabar();

                // Actualizar estado del presupuesto a "Guardado"
                presupuesto.EstadoPresupuesto = "Guardado";
                //AlmacenPresupuestos.Grabar();
                MessageBox.Show("Presupuesto guardado y Reserva en Estado Pre Reservada creada");
            }
            else
            {
                // Mostrar mensaje de error si el presupuesto está "Guardado"
                MessageBox.Show("El presupuesto seleccionado está en estado 'Guardado'. No se puede generar la pre reserva.");
            }
        }

        private static int ObtenerNuevoCodigoReserva()
        {
            // Obtener el último código de reserva y sumar 1
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
            // busco la reserva por el código
            var reserva = reservas.FirstOrDefault(r => r.CodigoReserva == codReserva);

            // verifico si la reserva existe y su estado actual es "Pre reservada"
            if (reserva != null && reserva.EstadoReserva == "Pre reservada")
            {
                // actualizo el estado de la reserva a "Pendiente de Pago"
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
            // Buscar la reserva por el código
            var reserva = reservas.FirstOrDefault(r => r.CodigoReserva == codReserva);

            // Verificar si la reserva existe y su estado actual es "Pagado"
            if (reserva != null && reserva.EstadoReserva == "Pagado")
            {
                // Verificar si la reserva ya está confirmada
                if (reserva.EstadoReserva != "Confirmada")
                {
                    // Actualizar el estado de la reserva a "Confirmada"
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
