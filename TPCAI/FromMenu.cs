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
    public partial class FromMenu : Form
    {
        public FromMenu()
        {
            InitializeComponent();
        }

        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            FormMenuProductos menu = new FormMenuProductos();
            menu.Show();
            
        }
    }
}
