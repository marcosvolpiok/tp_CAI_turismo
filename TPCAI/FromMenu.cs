using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TPCAI.Modulos;

namespace TPCAI
{
    public partial class FromMenu : Form
    {
        public FromMenu()
        {
            InitializeComponent();
        }

        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (ModuloPresupuestos.PresupuestoActivo == null)
            {
                MessageBox.Show("Seleccione un presupuesto primero.");
                return;
            }

            FormListadoVuelos vuelos = new FormListadoVuelos();
            vuelos.ShowDialog(); //queda detenida acá. Hasta que.... se oculte FormListadoVuelos.
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnGenerarReservas_Click(object sender, EventArgs e)
        {
            FormGenerarReservas generarReservas = new FormGenerarReservas();
            generarReservas.ShowDialog();
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            FormConsultarReservas consultarReservas = new FormConsultarReservas();
            consultarReservas.ShowDialog();
        }

        private void FromMenu_Load(object sender, EventArgs e)
        {



        }

        private void btnAlojamientos_Click(object sender, EventArgs e)
        {
            if (ModuloPresupuestos.PresupuestoActivo == null)
            {
                MessageBox.Show("Seleccione un presupuesto primero.");
                return;
            }

            FormListadoAlojamiento alojamiento = new FormListadoAlojamiento();
            alojamiento.ShowDialog();
        }
    }
}
