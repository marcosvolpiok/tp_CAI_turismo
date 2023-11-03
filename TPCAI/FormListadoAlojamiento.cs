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
    public partial class FormListadoAlojamiento : Form
    {
        public FormListadoAlojamiento()
        {
            InitializeComponent();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos("ALOJAMIENTOS");
            listadoPresupuestos.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromMenu menu = new FromMenu();
            menu.Show();
        }

        private void FormListadoAlojamiento_Load(object sender, EventArgs e)
        {
            this.dataGridViewListadoAlojamiento.Rows.Add("Caracas, Venezuela", "Hotel Sheraton", "$ 25.000", "5 Estrellas", "Doble");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromMenu menu = new FromMenu();
            menu.Show();
        }

        private void btnAñadirAPresupuesto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alojamiento añadido a presupuesto 4545");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alojamientos encontrados listados en la pantalla");
        }
    }
}
