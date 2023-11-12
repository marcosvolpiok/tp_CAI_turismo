using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;
using TPCAI.Modelos;
using TPCAI.Modulos;

namespace TPCAI
{
    public partial class FormGenerarReservas : Form
    {
        GenerarReservasModel model;

        public FormGenerarReservas()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGenerarReservas_Load(object sender, EventArgs e)
        {
            model = new GenerarReservasModel();

            if (model.obtenerPrespuestoActivo() != null)
            {
                lblActivo.Text = "Presupuesto Activo: " + model.obtenerPrespuestoActivo().CodigoPresupuesto.ToString();
            }
            else
            {
                lblActivo.Text = "";
            }

            buscarPresupuestos();
        }

        private void buscarPresupuestos()
        {
            /*dataGridViewPresupuestos.Rows.Clear();
            foreach (var presupuesto in model.obtenerPresupuestos())
            {
                this.dataGridViewPresupuestos.Rows.Add(presupuesto.CodigoPresupuesto, null, null);
            }
            this.dataGridViewPresupuestos.Refresh();*/
        }

        private void btnPreReservar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estado de presupuesto modificado a Reserva");
            if (dataGridViewPresupuestos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPresupuestos.SelectedRows[0];
                int PresupuestoActivo = int.Parse(selectedRow.Cells["ColumnNroPresupuesto"].Value.ToString());

                // Llamar al método GenerarPreReserva de GenerarReservasModel
                model.GenerarPreReserva(PresupuestoActivo);

                //MessageBox.Show("Presupuesto guardado y Reserva en Estado Pre Reservada creada");
            }
            else
            {
                MessageBox.Show("Por favor seleccione un presupuesto para pre reservar");
            }
        }

        private void btnReserverFromGenerarPreReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAñadirPasajero formPasajero = new FormAñadirPasajero();
            formPasajero.Show();
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoVuelos formVuelos = new FormListadoVuelos();
            formVuelos.Show();
        }

        private void btnAgregarAlojamiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoAlojamiento formAlojamiento = new FormListadoAlojamiento();
            formAlojamiento.Show();
        }

        private void btnAñadirPasajeros_Click(object sender, EventArgs e)
        {
            FormAñadirPasajero formPasajero = new FormAñadirPasajero();
            formPasajero.ShowDialog();
        }

        private void btnNuevoPresupuesto_Click(object sender, EventArgs e)
        {
            var nuevoCodPresupuesto = model.NuevoPresupuesto();

            if (nuevoCodPresupuesto != null)
            {
                //AGRGAR DATOS RESTANTES DEL GRID VIEW
                this.dataGridViewPresupuestos.Rows.Add(nuevoCodPresupuesto.CodigoPresupuesto, null, null);
            }
            else
            {
                MessageBox.Show("No se pudo obtener un nuevo presupuesto del modelo.");
            }

        }

        private void btnEstablecerActivo_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewPresupuestos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPresupuestos.SelectedRows[0];
                int PresupuestoActivo = int.Parse(selectedRow.Cells["ColumnNroPresupuesto"].Value.ToString());
                model.EstablecerPresupuestoActivo(PresupuestoActivo);
                MessageBox.Show($"Presupuesto número {PresupuestoActivo} establecido como activo");

                // Buscar pre reservas y actualizar el DataGridViewGenerarReserva
                BuscarPreReservas();
                // Buscar reservas a confirmar y actualizar el dataGridViewGenerarConfirmacion
                BuscarReservasAConfirmar();


                lblActivo.Text = $"Presupuesto Activo: {PresupuestoActivo}";
            }
            else
            {
                MessageBox.Show("Por favor seleccione un presupuesto para establecer como activo");
            }

        }

        private void BuscarPreReservas()
        {
            // Llamo al método BuscarPreReservas de GenerarReservasModel
            var preReservas = model.BuscarPreReservas();

            // Limpio el DataGridViewGenerarReserva antes de mostrar nuevos datos
            dataGridViewGenerarReserva.Rows.Clear();

            var presupuestoActivo = model.obtenerPrespuestoActivo();

            // Llamada al método ObtengoInfoProductos en GenerarReservasModel
            string infoProductos = model.ObtengoInfoProductos(presupuestoActivo);

            // Llamada al método ObtengoPrecioTotal en GenerarReservasModel
            decimal precioTotal = model.ObtengoPrecioTotal(presupuestoActivo);

            // Llenar el dataGridViewGenerarReserva con la información obtenida
            foreach (var preReserva in preReservas)
            {
                dataGridViewGenerarReserva.Rows.Add(preReserva.CodigoReserva, infoProductos, precioTotal);
            }

        }

        private void BuscarReservasAConfirmar()
        {
            // Llamo al método BuscarReservasConfirmar de GenerarReservasModel
            var ReservasConfirmar = model.BuscarReservasConfirmar();

            // Limpio el dataGridViewGenerarConfirmacion antes de mostrar nuevos datos
            dataGridViewGenerarConfirmacion.Rows.Clear();

            var presupuestoActivo = model.obtenerPrespuestoActivo();

            // Llamada al método ObtengoInfoProductos en GenerarReservasModel
            string infoProductos = model.ObtengoInfoProductos(presupuestoActivo);

            // Llamada al método ObtengoPrecioTotal en GenerarReservasModel
            decimal precioTotal = model.ObtengoPrecioTotal(presupuestoActivo);


            // Llenar el dataGridViewGenerarConfirmacion con la información obtenida
            foreach (var ReservaAConfirmar in ReservasConfirmar)
            {
                dataGridViewGenerarConfirmacion.Rows.Add(ReservaAConfirmar.CodigoReserva, infoProductos, ReservaAConfirmar.EstadoReserva, precioTotal);
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenerarConfirmacion.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewGenerarConfirmacion.SelectedRows[0];
                int CodReserva = int.Parse(selectedRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString());

                // Llamar al método ConfirmarReserva de GenerarReservasModel
                model.ConfirmarReserva(CodReserva);

            }
            else
            {
                MessageBox.Show("Por favor seleccione un NroReserva para confirmala");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (int.TryParse(textBox1.Text, out int codigoPresupuesto))
                {
                    var presupuestoEncontrado = model.BuscarPresupuestoPorId(codigoPresupuesto);

                    // Llamada al método ObtengoInfoProductos en GenerarReservasModel
                    string infoProductos = model.ObtengoInfoProductos(presupuestoEncontrado);

                    if (presupuestoEncontrado != null)
                    {
                        // Llenar el DataGridView con los datos del presupuesto encontrado
                        dataGridViewPresupuestos.Rows.Clear();
                        dataGridViewPresupuestos.Rows.Add(presupuestoEncontrado.CodigoPresupuesto, presupuestoEncontrado.FechaPresupuesto.Date, infoProductos, presupuestoEncontrado.PrecioTotal);
                        lblActivo.Text = $"Presupuesto Activo: {presupuestoEncontrado.CodigoPresupuesto}";
                    }
                    else
                    {
                        MessageBox.Show("Presupuesto no encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de presupuesto válido");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de presupuesto antes de buscar");
            }
        }

        // BUSCADOR TAB GENERAR RESERVA
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenerarReserva.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewGenerarReserva.SelectedRows[0];
                int CodReserva = int.Parse(selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString());

                // Llamar al método ReservarPendientePago de GenerarReservasModel
                model.ReservarPendientePago(CodReserva);

            }
            else
            {
                MessageBox.Show("Por favor seleccione un NroReserva para actualizar su Estado de Reserva");
            }
        }


        private void btnConsultarVuelos_Click(object sender, EventArgs e)
        {
            FormListadoVuelos vuelos = new FormListadoVuelos();
            vuelos.ShowDialog();
            buscarPresupuestos();
        }

        private void btnConsultarAlojamientos_Click(object sender, EventArgs e)
        {
            FormListadoAlojamiento alojamiento = new FormListadoAlojamiento();
            alojamiento.ShowDialog();
            buscarPresupuestos();
        }
    }
}
