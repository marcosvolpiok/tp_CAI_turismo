using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            FormListadoVuelos vuelos = new FormListadoVuelos();
            vuelos.Show();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnGenerarReservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGenerarReservas generarReservas = new FormGenerarReservas();
            generarReservas.Show();
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsultarReservas consultarReservas = new FormConsultarReservas();
            consultarReservas.Show();
        }

        private void FromMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAlojamientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoAlojamiento alojamiento = new FormListadoAlojamiento();
            alojamiento.Show();
        }
    }
}
