using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI;

namespace TPCAI
{
    class AlojamientosModelo
    {
        //public static List<AlojamientosEnt> Alojamientos = AlojamientoAlmacen.alojamientos;
        //Traer vuelos de módulo
        public ProductosModulo ProductosModulo = new ProductosModulo();

        public static List<AlojamientosEnt> BuscarVuelos()
        {
            return ProductosModulo.ObtenerAlojamientosFiltrados();
;
        }
    }
}
