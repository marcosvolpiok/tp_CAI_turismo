using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades.SubClasses;
using TPCAI.Modulos;

namespace TPCAI.Modelos
{
    internal class GenerarReservasModel
    {
        public string PresupuestoActivo { get; set; }

        public long NuevoPresupuesto()
        {
            return ModuloPresupuestos.CrearPresupuesto();            
        }

        public string EstablecerPresupuestoActivo(string presupuestoActivo)
        {
            var NuevoPresupuestoActivo = presupuestoActivo;
            PresupuestoActivo = NuevoPresupuestoActivo;
            return PresupuestoActivo;
        }
    }
}
