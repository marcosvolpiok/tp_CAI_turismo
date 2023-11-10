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
        public long NuevoPresupuesto()
        {
            return ModuloPresupuestos.CrearPresupuesto();            
        }

        public int EstablecerPresupuestoActivo(int presupuestoId)
        {
            PresupuestosEnt nuevoPresup = new PresupuestosEnt();
            nuevoPresup.CodigoPresupuesto = presupuestoId;
            ModuloPresupuestos.PresupuestoActivo = nuevoPresup;
            
            return presupuestoId;
        }
    }
}
