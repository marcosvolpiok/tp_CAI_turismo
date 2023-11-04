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
            FromMenu menu = new FromMenu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presupuesto Guardado y Cerrado");
        }

        private void FormListadoPresupuestos_Load(object sender, EventArgs e)
        {
            //this.dataGridViewPresupuestosAlojamientos.Rows.Add("Caracas, Venezuela", "Hotel Sheraton", "20/10/23 08:00", "25/10/23 11:00", "$ 25.000", "5 Estrellas", "Doble");
            this.dataGridViewPresupuestosAlojamientos.Rows.Add("Caracas, Venezuela", "Hotel Sheraton", 25000, "20/10/23 08:00", "25/10/23 11:00", "5 Estrellas", "Doble");
            this.dataGridViewPresupuestosVuelos.Rows.Add("CABA, Argentina", "La Habana, Cuba", "20/10/2023 00:30", "20/10/2023 06:30", "Latam", 120000, "Turista", "Adulto");

            ActualizarTotalPresupuesto(); // Agrego esta línea para actualizar el total al cargar el formulario.
            
        }

        // método para mantener actualizado el presupuesto en pantalla
        private void ActualizarTotalPresupuesto()
        {
            // Calculo suma de los precios de vuelos            
            decimal totalVuelos = 0;
            foreach (DataGridViewRow row in this.dataGridViewPresupuestosVuelos.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal precio;
                    if (decimal.TryParse(row.Cells["ColumnPrecio"].Value.ToString(), out precio))
                    {
                        totalVuelos += precio;
                    }
                }
            }

            // Calculo la suma de las tarifas de alojamientos
            decimal totalAlojamientos = 0;
            foreach (DataGridViewRow row in this.dataGridViewPresupuestosAlojamientos.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal tarifa;
                    if (decimal.TryParse(row.Cells["ColumnTarifa"].Value.ToString(), out tarifa))
                    {
                        totalAlojamientos += tarifa;
                    }
                }
            }

            label1.Text = $"Presupuesto Activo: {(totalVuelos + totalAlojamientos):C2}";
        }

        private void btnAñadirDatosCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAñadirCliente formCliente = new FormAñadirCliente();
            formCliente.Show();
        }

        /*
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewPresupuestosAlojamientos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridViewPresupuestosAlojamientos.SelectedRows)
                {
                    if (!row.IsNewRow) // Ensure you're not trying to remove a new row
                    {
                        this.dataGridViewPresupuestosAlojamientos.Rows.Remove(row);
                        this.dataGridViewPresupuestosVuelos.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para eliminar del presupuesto");
            }
        }
        */

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (this.tabControlAlojamientosVuelos.SelectedTab == tabVuelos)
            {
                if (this.dataGridViewPresupuestosVuelos.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in this.dataGridViewPresupuestosVuelos.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            this.dataGridViewPresupuestosVuelos.Rows.Remove(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione al menos una fila para eliminar el vuelo del presupuesto.");
                }
            }
            else if (this.tabControlAlojamientosVuelos.SelectedTab == tabAlojamientos)
            {
                if (this.dataGridViewPresupuestosAlojamientos.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in this.dataGridViewPresupuestosAlojamientos.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            this.dataGridViewPresupuestosAlojamientos.Rows.Remove(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione al menos una fila para eliminar el alojamiento del presupuesto.");
                }
            }
            ActualizarTotalPresupuesto(); // Agrego esta línea para actualizar el total al cargar el formulario.
        }

    }
}
