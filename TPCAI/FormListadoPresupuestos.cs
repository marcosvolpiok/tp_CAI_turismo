using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI.Entidades.SubClasses;
using TPCAI.Modelos;

namespace TPCAI
{
    public partial class FormListadoPresupuestos : Form
    {
        ListadoPresupuestosModel model;        

        public FormListadoPresupuestos(String TabParaMostrar)
        {
            InitializeComponent();

            model = new ListadoPresupuestosModel();

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


        // BOTON GUARDAR
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presupuesto Guardado y Cerrado");
        }

        private void FormListadoPresupuestos_Load(object sender, EventArgs e)
        {
         
            ActualizarPresupuestoVuelos(new List<Vuelo>()); // Inicialmente, muestra una lista vacía de vuelos en el dataGridViewPresupuestosVuelos
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

        
        // CREO METODO PARA ACTUALIZAR GRID VIEW VUELOS
        public void ActualizarPresupuestoVuelos(List<Vuelo> vuelos)
        {
        
            // Agrego los vuelos al modelo y actualiza el dataGridView al mismo tiempo
            foreach (var vuelo in vuelos)
            {
                model.AgregarVueloAPresupuesto(vuelo); // Agrega el vuelo al modelo
                dataGridViewPresupuestosVuelos.Rows.Add(
                    vuelo.Origen,
                    vuelo.Destino,
                    vuelo.FechaSalida,
                    vuelo.FechaArribo,
                    vuelo.Aerolinea,
                    vuelo.Precio,
                    vuelo.Clase,
                    vuelo.TipoPasajero,
                    vuelo.IdTarifaVuelos
                );
            }
            this.dataGridViewPresupuestosVuelos.Refresh();
        }


    }
}
