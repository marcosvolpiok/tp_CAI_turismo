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
    public partial class FormAñadirCliente : Form
    {
        public FormAñadirCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos presupuestos = new FormListadoPresupuestos("VUELOS"); //OJO! NO PASARLE MÁS ESTE PARÁMETRO
            presupuestos.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos formPresup = new FormListadoPresupuestos("VUELOS"); //OJO! NO PASARLE MÁS ESTE PARÁMETRO
            formPresup.Show();
        }
    }
}
