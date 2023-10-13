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
            FormConsultarAlojamientos alojamientos = new FormConsultarAlojamientos();
            alojamientos.Show();
        }

        private void btnConsultarVuelos_Click(object sender, EventArgs e)
        {
            FormConsultarVuelos vuelos = new FormConsultarVuelos();
            vuelos.Show();
        }       
    }
}
