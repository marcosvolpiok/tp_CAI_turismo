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

        public static List<AlojamientosEnt> ObtenerAlojamientosFiltrados(){
            return Alojamientos;
        }
    }
}
