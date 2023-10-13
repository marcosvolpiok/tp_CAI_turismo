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
            FormListadoVuelos listadovuelos = new FormListadoVuelos();
            listadovuelos.Show();
        }
    }
}
