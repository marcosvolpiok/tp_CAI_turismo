using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades.SubClasses;

namespace TPCAI.Entidades
{
    public class ReservasEnt
    {
        public int CodigoReserva { get; set; }
        public int Presupuesto { get; set; }
        public string EstadoReserva { get; set; }
        public bool Cobro { get; set; }
        public DateTime? FechaReservaConfirmada { get; set; }
        public List<Pasajero> Pasajeros { get; set; }
    }
}
