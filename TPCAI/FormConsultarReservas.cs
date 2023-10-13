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
    public partial class FormConsultarReservas : Form
    {
        public FormConsultarReservas()
        {
            InitializeComponent();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FromMenu menu = new FromMenu();
            menu.Show();
            this.Hide();
        }

        private void FormConsultarReservas_Load(object sender, EventArgs e)
        {
            this.dataGridViewReservas.Rows.Add("01/10/2023", "31.091.212", "Florencia Cervi", "Pre-Reservado");
        }
    }
}
