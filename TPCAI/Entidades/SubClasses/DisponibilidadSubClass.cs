using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    class DisponibilidadSubClass
    {
        public string Nombre { get; set; }
        public decimal Tarifa { get; set; }
        public int Capacidad { get; set; }
        public int Menores { get; set; }
        public int Infantes { get; set; }
        public List<HabitacionesHotelSubClass> Habitaciones { get; set; }
        public long IDDisponibilidad { get; set; }
    }
}
