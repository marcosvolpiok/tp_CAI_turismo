using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;
using TPCAI.Modulos;

namespace TPCAI
{
    internal class AñadirClienteModel
    {
        internal static bool AgregarCliente(Cliente cliente)
        {
            return ModuloPresupuestos.AgregarClientes(cliente);
        }

        public PresupuestosEnt ObtenerPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo;
        }
    }
}
