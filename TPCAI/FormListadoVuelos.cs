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
    public partial class FormListadoVuelos : Form
    {
        ListadoVuelosModel model;
        private FormListadoPresupuestos formListadoPresupuestos; // Referencia al formulario FormListadoPresupuestos

        public FormListadoVuelos()
        {
            InitializeComponent();
            this.formListadoPresupuestos = formListadoPresupuestos; // Asignar referencia
            //this.model = model;
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos("VUELOS");
            // Pasa los vuelos al formulario FormListadoPresupuestos
            listadoPresupuestos.ActualizarPresupuestoVuelos(model.ObtenerVuelosPresupuesto());

            listadoPresupuestos.ShowDialog();

            // Refresco
            Buscar();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            FromMenu menu = new FromMenu();
            menu.Show();*/
            this.Close();
        }

        private void FormListadoVuelos_Load(object sender, EventArgs e)
        {
            model = new ListadoVuelosModel();
            
            /* inicializar y llenar datos de origenes y destinos */
        }

        private void btnAñadirAPresupuesto_Click(object sender, EventArgs e)
        {

            if (dataGridViewListadoVuelos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewListadoVuelos.SelectedRows[0];
                string vueloId = selectedRow.Cells["ColumnIdTarifa"].Value.ToString();

                model.IdTarifaVuelosSeleccionada = vueloId;
                model.AgregarVueloAPresupuesto(vueloId);

                MessageBox.Show("Se ha añadido correctamente el producto al presupuesto.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alojamiento para agregar al presupuesto.");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {            

            if (int.TryParse(textBox4.Text, out int cantAdultos))
            {
                model.CantAdultos = cantAdultos;
            }

            if (int.TryParse(textBox5.Text, out int cantMenores))
            {
                model.CantMenores = cantMenores;
            }

            if (int.TryParse(textBox6.Text, out int cantInfantes))
            {
                model.CantInfantes = cantInfantes;
            }
            //VALIDACIONES POR AGREGAR
            model.Origen = comboBox2.Text;
            model.Destino = comboBox3.Text;
            model.FechaIda = dateTimePicker1.Value;
            model.FechaVuelta = dateTimePicker2.Value;
            model.Clase = comboBox1.Text;

            model.BuscarVuelos(); // Realiza la búsqueda de vuelos.

            this.Buscar();
        }

        
        private void Buscar()
        {
            // Mapear los resultados en el dataGridViewListadoVuelos
            this.dataGridViewListadoVuelos.Rows.Clear();
            foreach (var vuelo in model.VuelosFiltrados)
            {
                this.dataGridViewListadoVuelos.Rows.Add(
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
            this.dataGridViewListadoVuelos.Refresh();
        }


    }
}
