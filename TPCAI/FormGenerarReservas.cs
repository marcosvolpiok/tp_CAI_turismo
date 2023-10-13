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
    public partial class FormGenerarReservas : Form
    {
        public FormGenerarReservas()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FromMenu menu = new FromMenu();
            menu.Show();
            this.Hide();
        }

        private void FormGenerarReservas_Load(object sender, EventArgs e)
        {
            this.dataGridViewPreReserva.Rows.Add("100", "13/10/2023", "2 Noches Hotel Kau Kaleshen", "$ 30.000");
            this.dataGridViewGenerarReserva.Rows.Add("101", "4 Noches Hotel Hilton Córdoba Centro", "$ 60.000");
            this.dataGridViewGenerarConfirmacion.Rows.Add("102", "13/10/2023", "1 Noche Hotel Kau Kaleshen", "Pagado", "$ 15.000");
        }

        private void btnPreReservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAñadirPasajero formPasajero = new FormAñadirPasajero();
            formPasajero.Show();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAñadirPasajero formPasajero = new FormAñadirPasajero();
            formPasajero.Show();
        }
    }
}
