using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI.Almacenes;

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

            //Guardar Almacenes

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FromMenu());



        }
    }
}
