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
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos();
            listadoPresupuestos.Show();
        }
    }
}
