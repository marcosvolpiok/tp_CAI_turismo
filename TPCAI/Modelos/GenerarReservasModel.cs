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
    }
}
