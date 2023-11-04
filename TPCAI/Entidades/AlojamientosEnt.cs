using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPCAI
{
    class AlojamientosEnt
    {
        public long IDAlojamientos { get; set; }
        public string CodigoHotel { get; set; }
        public string Nombre { get; set; }
        public string CodigoCiudad { get; set; }
        public string Direccion { get; set; }
        public string Calificacion { get; set; }
        public List<DisponibilidadSubClass> Disponibilidad { get; set; }
        


    }
}
