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
    public partial class FormAñadirPasajero : Form
    {
        public FormAñadirPasajero()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGenerarReservas formReservas = new FormGenerarReservas();
            formReservas.Show();
        }
    }
}
