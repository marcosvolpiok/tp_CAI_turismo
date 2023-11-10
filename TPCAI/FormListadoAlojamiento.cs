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
using TPCAI.Modulos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPCAI
{
    public partial class FormListadoAlojamiento : Form
    {
        ListadoAlojamientosModelo model;

        public FormListadoAlojamiento()
        {
            InitializeComponent();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos();
            listadoPresupuestos.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromMenu menu = new FromMenu();
            menu.Show();
        }

        private void FormListadoAlojamiento_Load(object sender, EventArgs e)
        {
            model = new ListadoAlojamientosModelo();

            //Carga destinos (códigos de ciudades)
            List<string> codigosCiudad = new List<string> { "MIAMI", "MADRID", "BUENOS AIRES" };
            comboDestino.Items.AddRange(codigosCiudad.ToArray());

            //Carga calificaciones (cantidad de estrellas)
            List<string> calificaciones = new List<string> { "1", "2", "3", "4", "5" };
            comboCalificacion.Items.AddRange(calificaciones.ToArray());

            if (ModuloPresupuestos.PresupuestoActivo != null)
            {
                lblPresupuestoActivo.Text = "Presupuesto Activo: " + ModuloPresupuestos.PresupuestoActivo.CodigoPresupuesto.ToString();
            }

            //Busca alojamientos
            model.BuscarAlojaimentos();

            //Muestra en lista
            foreach (Alojamiento alojamiento in model.AlojamientosFiltrados)
            {
                foreach (DisponibilidadSubClass disponibilidad in alojamiento.Disponibilidad)
                {
                    this.dataGridViewListadoAlojamiento.Rows.Add(alojamiento.CodigoCiudad, alojamiento.Nombre, disponibilidad.Tarifa, alojamiento.Calificacion, disponibilidad.Nombre, disponibilidad.IDDisponibilidad);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromMenu menu = new FromMenu();
            menu.Show();
        }

        private void btnAñadirAPresupuesto_Click(object sender, EventArgs e)
        {
            if (dataGridViewListadoAlojamiento.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewListadoAlojamiento.SelectedRows[0];
                string IDDisponibilidad = selectedRow.Cells["IDDisponibilidad"].Value.ToString();

                model.IdDisponibilidadsSeleccionada = IDDisponibilidad;
                model.AgregarAlojamientoAPresupuesto(IDDisponibilidad);

                MessageBox.Show("Se ha añadido correctamente el producto al presupuesto.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alojamiento para agregar al presupuesto.");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            bool resultadoValidacion = Validacion.validarFiltrosBusquedaAlojamiento(
                comboDestino.Text,
                dateTimeIngreso.Text,
                dateTimeEgreso.Text,
                textCantidadAdultos.Text,
                textCantidadMenores.Text,
                textCantidadInfantes.Text,
                comboCalificacion.Text
                );


            if (resultadoValidacion == true) {
                model.destino = comboDestino.Text;
                model.fechaIngreso = dateTimeIngreso.Text;
                model.fechaEgreso = dateTimeEgreso.Text;
                model.cantidadAdultos = textCantidadAdultos.Text;
                model.cantidadMenores = textCantidadMenores.Text;
                model.cantidadInfantes = textCantidadInfantes.Text;
                model.calificacion = comboCalificacion.Text;

                model.BuscarAlojamientosFiltrados(); //<-- OK

                this.dataGridViewListadoAlojamiento.Rows.Clear();
                foreach (Alojamiento alojamiento in model.AlojamientosFiltrados) {
                    foreach (DisponibilidadSubClass disponibilidad in alojamiento.Disponibilidad)
                    {
                        this.dataGridViewListadoAlojamiento.Rows.Add(alojamiento.CodigoCiudad, alojamiento.Nombre, disponibilidad.Tarifa, alojamiento.Calificacion, disponibilidad.Nombre, disponibilidad.IDDisponibilidad);
                    }
                }

                if (this.dataGridViewListadoAlojamiento.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron alojamientos con los parámetros solicitados");
                }
            }
        }
    }
}
