using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI.Entidades.SubClasses
{
    public class Alojamiento
    {
        public string CodigoHotel { get; set; }
        public string Nombre { get; set; }
        public string CodigoCiudad { get; set; }
        public Direccion Direccion { get; set; }
        public int Calificacion { get; set; }
        public List<DisponibilidadSubClass> Disponibilidad { get; set; }

        public Alojamiento(string codigoHotel, string nombre, string codigoCiudad, Direccion direccion, int calificacion, List<DisponibilidadSubClass> disponibilidad)
        {
            CodigoHotel = codigoHotel;
            Nombre = nombre;
            CodigoCiudad = codigoCiudad;
            Direccion = direccion;
            Calificacion = calificacion;
            Disponibilidad = disponibilidad;
        }
    }
}
