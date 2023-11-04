using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            return ProductosModulo.ObtenerAlojamientos();
        }

        public static List<AlojamientosEnt> BuscarVuelosFiltrados(
            string destino,
            string fechaIngreso,
            string fechaEgreso,
            int cantidadAdultos,
            int cantidadMenores,
            int cantidadInfantes,
            int calificacion
            )
        {
            return ProductosModulo.ObtenerAlojamientosFiltrados(
                destino,
                fechaIngreso,
                fechaEgreso,
                cantidadAdultos,
                cantidadMenores,
                cantidadInfantes,
                calificacion);
        }


    }
}
