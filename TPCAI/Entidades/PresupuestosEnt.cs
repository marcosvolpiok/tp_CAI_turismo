using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI.Entidades
{
    public class PresupuestosEnt
    {
        public int CodigoPresupuesto { get; set; }
        public List<string> IdTarifaVuelo { get; set; }
        public List<int> IDHabitacion { get; set; }
        public ClienteEnt Clientes { get; set; }
        public DateTime FechaPresupuesto { get; set; }
        public decimal PrecioTotal { get; set; }

        public PresupuestosEnt() //TO DO: ¿Está bien esto? Sino lo inicializo no me deja hacerle add
        {
            IDHabitacion = new List<int>();
        }
    }
}
