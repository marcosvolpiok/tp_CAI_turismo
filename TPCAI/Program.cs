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
            ModuloPresupuestos.clientes = AlmacenClientes.ObtenerClientes();
            ModuloReservas.reservas = AlmacenReservas.ObtenerReservas();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new FromMenu());
                GuardarAlmacenes();
            }
            catch (Exception ex)
            {
                GuardarAlmacenes();
                MessageBox.Show("Se encontró un error no reconocido, por favor repórtelo. Los cambios que realizó fueron guardados", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                MessageBox.Show("Por favor reporte este error con este mensaje. Descripción técnica del error: " + ex.Message + " - StackTrace: " + ex.StackTrace);
            }
        }

        public static void GuardarAlmacenes()
        {
            CiudadAlmacen.Grabar(ProductosModulo.ciudades);
            AlojamientoAlmacen.Grabar(ProductosModulo.alojamientos);
            AlmacenVuelos.Grabar(ProductosModulo.vuelos);
            AlmacenPresupuestos.Grabar(ModuloPresupuestos.Presupuestos);
            AlmacenClientes.Grabar(ModuloPresupuestos.clientes);
            AlmacenReservas.Grabar(ModuloReservas.reservas);

            //Application.Exit();
        }
        
    }
}
