﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            FromMenu menu = new FromMenu();
            menu.Show();
            this.Hide();
        }

        private void FormGenerarReservas_Load(object sender, EventArgs e)
        {
            /*this.dataGridViewPreReserva.Rows.Add("100", "13/10/2023", "2 Noches Hotel Kau Kaleshen", "$ 30.000");
            this.dataGridViewGenerarReserva.Rows.Add("101", "4 Noches Hotel Hilton Córdoba Centro", "$ 60.000");
            this.dataGridViewGenerarConfirmacion.Rows.Add("102", "1 Noche Hotel Kau Kaleshen", "Pagado", "$ 15.000");*/
            model = new GenerarReservasModel();

            if (ModuloPresupuestos.PresupuestoActivo != null)
            {
                lblActivo.Text = ModuloPresupuestos.PresupuestoActivo.CodigoPresupuesto.ToString();
            }
        }

        private void btnPreReservar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estado de presupuesto modificado a Reserva");
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAñadirPasajero formPasajero = new FormAñadirPasajero();
            formPasajero.Show();
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
            this.Hide();
            FormAñadirPasajero formPasajero = new FormAñadirPasajero();
            formPasajero.Show();
        }

        private void btnNuevoPresupuesto_Click(object sender, EventArgs e)
        {
            var nuevoCodPresupuesto = model.NuevoPresupuesto();

            if (nuevoCodPresupuesto != null)
            {
                this.dataGridViewPreReserva.Rows.Clear();

                this.dataGridViewPreReserva.Rows.Add(nuevoCodPresupuesto, null, null);
            }
            else
            {
                MessageBox.Show("No se pudo obtener un nuevo presupuesto del modelo.");
            }

        }

        private void btnEstablecerActivo_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewPreReserva.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPreReserva.SelectedRows[0];
                int PresupuestoActivo = int.Parse(selectedRow.Cells["ColumnNroPresupuesto"].Value.ToString());
                model.EstablecerPresupuestoActivo(PresupuestoActivo);
                MessageBox.Show($"Presupuesto número {PresupuestoActivo} establecido como activo");

                lblActivo.Text = $"Presupuesto Activo: {PresupuestoActivo}";
            }
            else
            {
                MessageBox.Show("Por favor seleccione un presupuesto para establecer como activo");
            }
            
        }        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reserva confirmada");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presupuesto encontrado");
        }
        

        private void btnConsultarVuelos_Click(object sender, EventArgs e)
        {
            FormListadoVuelos vuelos = new FormListadoVuelos();
            vuelos.Show();
            this.Hide();
        }

        private void btnConsultarAlojamientos_Click(object sender, EventArgs e)
        {
            FormListadoAlojamiento alojamiento = new FormListadoAlojamiento();
            alojamiento.Show();
            this.Hide();
        }
    }
}
