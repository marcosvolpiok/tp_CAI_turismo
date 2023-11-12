﻿using System;
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
            return ModuloPresupuestos.agregarPresupuestoNuevo();
        }

        public int EstablecerPresupuestoActivo(int presupuestoId)
        {
            PresupuestosEnt nuevoPresup = new PresupuestosEnt();
            nuevoPresup.CodigoPresupuesto = presupuestoId;
            ModuloPresupuestos.PresupuestoActivo = nuevoPresup;

            return presupuestoId;
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
            var codigoPresupuestoActivo = obtenerPrespuestoActivo().CodigoPresupuesto;
            var reservasPreReservadas = ModuloReservas.BuscarPreReservas(codigoPresupuestoActivo);

            // Llamo al método BuscarPreReservas de ModuloReservas
            return ModuloReservas.BuscarPreReservas(obtenerPrespuestoActivo().CodigoPresupuesto);
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
            return infoProductos; ;
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
