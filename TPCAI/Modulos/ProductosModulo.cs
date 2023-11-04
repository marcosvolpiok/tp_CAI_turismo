using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI;

namespace TPCAI
{
    class ProductosModulo
    {
        public static List<AlojamientosEnt> Alojamientos = AlojamientoAlmacen.alojamientos;

        public static List<AlojamientosEnt> ObtenerAlojamientos(
            )
        {
            return Alojamientos;
        }
        public static List<AlojamientosEnt> ObtenerAlojamientosFiltrados(
            string destino,
            string fechaIngreso,
            string fechaEgreso,
            int cantidadAdultos,
            int cantidadMenores,
            int cantidadInfantes,
            int calificacion)
        {
            List<AlojamientosEnt> alojamientosFiltrados = new List<AlojamientosEnt>();

            foreach(var alojamiento in Alojamientos)
            {
                if(alojamiento.CodigoCiudad == destino)
                {
                    alojamientosFiltrados.Add(alojamiento);
                }
            }
            return alojamientosFiltrados;
        }
    }
}
