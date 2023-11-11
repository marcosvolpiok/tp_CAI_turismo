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
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos();
            listadoPresupuestos.ShowDialog();
            this.mostrarAlojamientosEnGrilla();

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListadoAlojamiento_Load(object sender, EventArgs e)
        {
            model = new ListadoAlojamientosModelo();

            comboDestino.DisplayMember = "Nombre";
            CiudadesEnt ciudades = model.obtenerCiudades();
            comboDestino.Items.AddRange(ciudades.Ciudades.ToArray());

            //Carga calificaciones (cantidad de estrellas)
            List<string> calificaciones = new List<string> { "1", "2", "3", "4", "5" };
            comboCalificacion.Items.AddRange(calificaciones.ToArray());

            if (ModuloPresupuestos.PresupuestoActivo != null)
            {
                lblPresupuestoActivo.Text = "Presupuesto Activo: " + ModuloPresupuestos.PresupuestoActivo.CodigoPresupuesto.ToString();
            }

            //Busca alojamientos
            model.BuscarAlojaimentos();

            this.mostrarAlojamientosEnGrilla();
        }

        private void mostrarAlojamientosEnGrilla()
        {
            this.dataGridViewListadoAlojamiento.Rows.Clear();

            //Muestra en lista
            foreach (Alojamiento alojamiento in model.AlojamientosFiltrados)
            {
                foreach (DisponibilidadSubClass disponibilidad in alojamiento.Disponibilidad)
                {
                    foreach (HabitacionesHotelSubClass habitacion in disponibilidad.Habitaciones)
                    {
                        this.dataGridViewListadoAlojamiento.Rows.Add(
                            model.obtenerCiudadPorCodigo(alojamiento.CodigoCiudad).Nombre,
                            alojamiento.Nombre,
                            disponibilidad.Tarifa,
                            alojamiento.Calificacion,
                            disponibilidad.Nombre,
                            habitacion.FechaHabitacionHotel.ToString("dd-MM-yyyy"),
                            habitacion.IDHabitacion);
                    }
                }
            }

            if (this.dataGridViewListadoAlojamiento.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron alojamientos con los parámetros solicitados");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadirAPresupuesto_Click(object sender, EventArgs e)
        {
            if (dataGridViewListadoAlojamiento.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewListadoAlojamiento.SelectedRows[0];
                string IDHabitacion = selectedRow.Cells["IDHabitacion"].Value.ToString();

                model.AgregarAlojamientoAPresupuesto(IDHabitacion);

                MessageBox.Show("Se ha añadido correctamente el producto al presupuesto.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alojamiento para agregar al presupuesto.");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (comboDestino.SelectedItem != null)
            {
                CiudadesDetailSubClass ciudadSeleccionada = comboDestino.SelectedItem as CiudadesDetailSubClass;
                model.destino = ciudadSeleccionada.CodigoISO;
            }
            else
            {
                model.destino = "";
            }
            
            model.fechaIngreso = dateTimeIngreso.Text;
            model.fechaEgreso = dateTimeEgreso.Text;
            model.cantidadAdultos = textCantidadAdultos.Text;
            model.cantidadMenores = textCantidadMenores.Text;
            model.cantidadInfantes = textCantidadInfantes.Text;
            model.calificacion = comboCalificacion.Text;

            model.BuscarAlojamientosFiltrados();

            if (model.AlojamientosFiltrados != null)
            {
                this.mostrarAlojamientosEnGrilla();
            }
        }
    }
}
