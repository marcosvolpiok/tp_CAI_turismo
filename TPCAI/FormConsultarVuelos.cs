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
    public partial class FormConsultarVuelos : Form
    {
        public FormConsultarVuelos()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoVuelos listadovuelos = new FormListadoVuelos();
            listadovuelos.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuProductos menuProductos = new FormMenuProductos();
            menuProductos.Show();
        }
    }
}
