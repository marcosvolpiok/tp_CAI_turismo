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
    public partial class FormListadoPresupuestos : Form
    {
        public FormListadoPresupuestos(String TabParaMostrar)
        {
            InitializeComponent();

            if (TabParaMostrar == "VUELOS")
            {
                this.tabControlAlojamientosVuelos.SelectTab("tabVuelos");
            }
            else
            {
                this.tabControlAlojamientosVuelos.SelectTab("tabAlojamientos");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuProductos menuProductos = new FormMenuProductos();
            menuProductos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAñadirCliente formCliente = new FormAñadirCliente();
            formCliente.Show();
        }

        private void FormListadoPresupuestos_Load(object sender, EventArgs e)
        {
            this.dataGridViewPresupuestosAlojamientos.Rows.Add("Caracas, Venezuela", "Hotel Sheraton", "20/10/23 08:00", "25/10/23 11:00", "$ 25.000", "5 Estrellas", "Doble");
            this.dataGridViewPresupuestosVuelos.Rows.Add("CABA, Argentina", "La Habana, Cuba", "20/10/2023 00:30", "20/10/2023 06:30", "Latam", "$120.000", "Turista", "Adulto");

        }
    }
}
