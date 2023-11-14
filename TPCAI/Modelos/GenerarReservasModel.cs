using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;
using TPCAI.Modulos;

namespace TPCAI.Modelos
{
    internal class GenerarReservasModel
    {
        public PresupuestosEnt NuevoPresupuesto()
        {
            PresupuestosEnt presupuestoNuevo = ModuloPresupuestos.agregarPresupuestoNuevo();
            ModuloPresupuestos.Presupuestos.Add(presupuestoNuevo);

            return presupuestoNuevo;
        }

        public int EstablecerPresupuestoActivo(int presupuestoId)
        {
            PresupuestosEnt presupuesto = ModuloPresupuestos.Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == presupuestoId);
            ModuloPresupuestos.PresupuestoActivo = presupuesto;

            return presupuesto.CodigoPresupuesto;
        }

        public List<PresupuestosEnt> obtenerPresupuestos()
        {
            return ModuloPresupuestos.obtenerPresupuestos();
        }

        public PresupuestosEnt obtenerPrespuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo;

        }

        public PresupuestosEnt BuscarPresupuestoPorId(int presupuestoId)
        {
            return ModuloPresupuestos.BusquedaPresupuestoId(presupuestoId);
        }

        public void GenerarPreReserva(int codigoPresupuesto)
        {
            ModuloReservas.GenerarPreReserva(codigoPresupuesto);
        }

        public List<ReservasEnt> BuscarPreReservas()
        {
            // Obtengo reservas con EstadoReserva = "Pre reservada" para el presupuesto activo
            int codigoPresupuestoActivo = obtenerPrespuestoActivo().CodigoPresupuesto;
            List<ReservasEnt> reservasPreReservadas = ModuloReservas.BuscarPreReservas(codigoPresupuestoActivo);

            return reservasPreReservadas;
        }

        public List<ReservasEnt> BuscarReservasConfirmar()
        {
            // Obtengo reservas con EstadoReserva = "Pendiente de pago" para el presupuesto activo
            var codigoPresupuestoActivo = obtenerPrespuestoActivo().CodigoPresupuesto;
            var reservasAConfirmar = ModuloReservas.BuscarReservasAConfirmar(codigoPresupuestoActivo);

            // Llamo al método BuscarPreReservas de ModuloReservas
            return ModuloReservas.BuscarReservasAConfirmar(obtenerPrespuestoActivo().CodigoPresupuesto);
        }



        internal string ObtengoInfoProductos(PresupuestosEnt presupuestoActivo)
        {
            var infoProductos = ModuloPresupuestos.ObtenerInfoP(presupuestoActivo);
            return infoProductos;
        }

        internal decimal ObtengoPrecioTotal(PresupuestosEnt presupuestoActivo)
        {
            var infoPrecioTotal = ModuloPresupuestos.ObtenerInfoPrecioTotal(presupuestoActivo);
            return infoPrecioTotal; ;
        }

        internal void ReservarPendientePago(int codReserva)
        {
            ModuloReservas.GenerarReservaPendPago(codReserva);
        }

        internal void ConfirmarReserva(int codReserva)
        {
            ModuloReservas.GenerarReservaConfirmada(codReserva);
        }
    }
}
