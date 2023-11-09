using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI.Entidades
{
    internal class PresupuestosEnt
    {
        public int CodigoPresupuesto { get; set; }
        public List<string> IdTarifaVuelo { get; set; }
        public List<int> IDHabitacion { get; set; }
        public ClienteEnt Clientes { get; set; }
        public DateTime FechaPresupuesto { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
