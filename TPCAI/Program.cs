using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI.Almacenes;
using TPCAI.Modulos;

namespace TPCAI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Lee Almacenes
            ProductosModulo.ciudades = CiudadAlmacen.ObtenerCiudades();
            ProductosModulo.alojamientos = AlojamientoAlmacen.ObtenerAlojamientos();
            ProductosModulo.vuelos = AlmacenVuelos.ObtenerVuelos();
            ModuloPresupuestos.Presupuestos = AlmacenPresupuestos.ObtenerPresupuestos();
            ModuloReservas.reservas = AlmacenReservas.ObtenerReservas();

            //Guardar Almacenes

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FromMenu());



        }
    }
}
