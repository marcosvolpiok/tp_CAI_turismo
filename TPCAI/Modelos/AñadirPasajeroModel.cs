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
    internal class AñadirPasajeroModel
    {
        public PresupuestosEnt ObtenerPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo;
        }

        public void GuardarPasajeros(List<Pasajero> pasajeros)
        {
                ModuloReservas.guardarPasajeroAPresupuestoActivo(pasajeros);
        }
    }
}
