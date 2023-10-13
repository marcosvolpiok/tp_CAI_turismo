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
    public partial class FormConsultarAlojamientos : Form
    {
        public FormConsultarAlojamientos()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormListadoAlojamiento listadoAlojamientos = new FormListadoAlojamiento();
            listadoAlojamientos.Show();
        }
    }
}
