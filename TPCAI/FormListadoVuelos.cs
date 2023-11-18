using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;
using TPCAI.Modelos;

namespace TPCAI
{
    public partial class FormListadoVuelos : Form
    {
        ListadoVuelosModel model;

        public FormListadoVuelos()
        {
            InitializeComponent();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos();
            listadoPresupuestos.tabControlAlojamientosVuelos.SelectTab("tabVuelos");
            listadoPresupuestos.ShowDialog(); //La ejecución se detiene acá y pasa al otro formulario.
            // Refresco
            Buscar();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListadoVuelos_Load(object sender, EventArgs e)
        {
            model = new ListadoVuelosModel();

            comboBox2.DisplayMember = "Nombre";
            CiudadesEnt ciudades = model.obtenerCiudades();

            comboBox2.Items.AddRange(ciudades.Ciudades.ToArray());

            comboBox3.DisplayMember = "Nombre";
            comboBox3.Items.AddRange(ciudades.Ciudades.ToArray());


            var CodPresupuestoActivo = model.PresupuestoActivo();            
            label10.Text = $"Presupuesto Activo: {CodPresupuestoActivo}";
        }

        private void btnAñadirAPresupuesto_Click(object sender, EventArgs e)
        {
            if (dataGridViewListadoVuelos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewListadoVuelos.SelectedRows[0];
                string vueloId = selectedRow.Cells["ColumnIdTarifa"].Value.ToString();
                model.AgregarVueloAPresupuesto(vueloId);
                MessageBox.Show("Se ha añadido correctamente el producto al presupuesto.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un vuelo para agregar al presupuesto.");
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

            if (comboBox2.SelectedItem != null)
            {
                CiudadesDetailSubClass ciudadSeleccionada = comboBox2.SelectedItem as CiudadesDetailSubClass;
                model.Origen = ciudadSeleccionada.CodigoISO;
            }
            else
            {
                model.Origen = "";
            }

            if (comboBox3.SelectedItem != null)
            {
                CiudadesDetailSubClass ciudadSeleccionada = comboBox3.SelectedItem as CiudadesDetailSubClass;
                model.Destino = ciudadSeleccionada.CodigoISO;
            }
            else
            {
                model.Destino = "";
            }



            //VALIDACIONES POR AGREGAR            
            model.FechaIda = dateTimePicker1.Value;
            model.FechaVuelta = dateTimePicker2.Value;
            model.Clase = comboBox1.Text;

            model.BuscarVuelos(); // Realiza la búsqueda de vuelos.

            this.Buscar();
        }

        
        private void Buscar(bool ocultarMsgbox = false)
        {
            this.dataGridViewListadoVuelos.Rows.Clear();

            if (model.VuelosFiltrados != null)
            {
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
            }
            
            this.dataGridViewListadoVuelos.Refresh();

            if (this.dataGridViewListadoVuelos.Rows.Count == 0 && ocultarMsgbox == false)
            {
                MessageBox.Show("No se encontraron vuelos con los parámetros solicitados");
            }
        }


    }
}
