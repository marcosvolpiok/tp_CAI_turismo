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
            PresupuestosEnt presupuestoNuevo = ModuloPresupuestos.agregarPresupuestoNuevo();

            return presupuestoNuevo;
        }

        public List<Pasajero> ObtenerPasajerosCargadosAPresupuestoPorID(int IDPresupuesto)
        {
            if (ModuloReservas.diccionarioPresupuestoPasajero.ContainsKey(IDPresupuesto))
            {
                return ModuloReservas.diccionarioPresupuestoPasajero[IDPresupuesto];
            }
            else
            {
                return new List<Pasajero>();
            }            
        }

        public int EstablecerPresupuestoActivo(int presupuestoId)
        {
            PresupuestosEnt presupuesto = ModuloPresupuestos.Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == presupuestoId);
            ModuloPresupuestos.EstablecerPresupuestoActivo(presupuesto);

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
