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
    public partial class FormAñadirPasajero : Form
    {
        public FormAñadirPasajero()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.dataGridListadoPasajeros.Rows.Add("", "", "", "", "");
        }

        private void FormAñadirPasajero_Load(object sender, EventArgs e)
        {
            this.dataGridListadoPasajeros.Columns.Add("tipo", "Tipo");
            this.dataGridListadoPasajeros.Columns.Add("nombre", "Nombre");
            this.dataGridListadoPasajeros.Columns.Add("apellido", "Apellido");
            this.dataGridListadoPasajeros.Columns.Add("dni", "DNI");
            this.dataGridListadoPasajeros.Columns.Add("fechaNacimiento", "Fecha de Nacimiento");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGenerarReservas formReservas = new FormGenerarReservas();
            formReservas.Show();
        }

        private void btnQuitarPasajero_Click(object sender, EventArgs e)
        {
            if (this.dataGridListadoPasajeros.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridListadoPasajeros.SelectedRows)
                {
                    if (!row.IsNewRow) // Ensure you're not trying to remove a new row
                    {
                        this.dataGridListadoPasajeros.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un pasajero para quitar de la lista");
            }
        }
    }
}
