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
    public partial class FormListadoVuelos : Form
    {
        public FormListadoVuelos()
        {
            InitializeComponent();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos();
            listadoPresupuestos.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuProductos menuProductos = new FormMenuProductos();
            menuProductos.Show();
        }

        private void FormListadoVuelos_Load(object sender, EventArgs e)
        {
            this.dataGridViewListadoVuelos.Rows.Add("CABA, Argentina", "La Habana, Cuba", "20/10/2023 00:30", "20/10/2023 06:30", "Latam", "$120.000", "Turista", "Adulto");
        }


    }
}
