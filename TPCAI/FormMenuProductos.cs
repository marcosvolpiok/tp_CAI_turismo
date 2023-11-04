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
    public partial class FormMenuProductos : Form
    {
        public FormMenuProductos()
        {
            InitializeComponent();
        }

        private void btnConsultarAlojamiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsultarAlojamientos alojamientos = new FormConsultarAlojamientos();
            alojamientos.Show();
        }

        private void btnConsultarVuelos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsultarVuelos vuelos = new FormConsultarVuelos();
            vuelos.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FromMenu menu = new FromMenu();
            menu.Show();
            this.Hide();
        }       
    }
}
