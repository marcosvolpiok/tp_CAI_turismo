using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPCAI
{
    public partial class FormListadoAlojamiento : Form
    {
        public FormListadoAlojamiento()
        {
            InitializeComponent();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos("ALOJAMIENTOS");
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
            //Carga destinos (códigos de ciudades)
            List<string> codigosCiudad = new List<string> { "MIAMI", "MADRID", "BUENOS AIRES" };
            comboDestino.Items.AddRange(codigosCiudad.ToArray());

            //Carga calificaciones (cantidad de estrellas)
            List<string> calificaciones = new List<string> { "1", "2", "3", "4", "5" };
            comboCalificacion.Items.AddRange(calificaciones.ToArray());


            //Carga listado con todos los alojamientos
            List<AlojamientosEnt> alojamientosList = AlojamientosModelo.BuscarVuelos();
            foreach(AlojamientosEnt alojamiento in alojamientosList){
                foreach(DisponibilidadSubClass disponibilidad in alojamiento.Disponibilidad)
                {
                    this.dataGridViewListadoAlojamiento.Rows.Add(alojamiento.CodigoCiudad, alojamiento.Nombre, disponibilidad.Tarifa, alojamiento.Calificacion, disponibilidad.Nombre);
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
            MessageBox.Show("Alojamiento añadido a presupuesto 4545");
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
                List<AlojamientosEnt> alojamientosList = AlojamientosModelo.BuscarVuelosFiltrados(
                comboDestino.Text,
                dateTimeIngreso.Text,
                dateTimeEgreso.Text,
                textCantidadAdultos.Text,
                textCantidadMenores.Text,
                textCantidadInfantes.Text,
                comboCalificacion.Text
                );
                this.dataGridViewListadoAlojamiento.Rows.Clear();


                foreach (AlojamientosEnt alojamiento in alojamientosList)
                {
                    foreach (DisponibilidadSubClass disponibilidad in alojamiento.Disponibilidad)
                    {
                        this.dataGridViewListadoAlojamiento.Rows.Add(alojamiento.CodigoCiudad, alojamiento.Nombre, disponibilidad.Tarifa, alojamiento.Calificacion, disponibilidad.Nombre);
                    }
                }

                MessageBox.Show("Alojamientos encontrados listados en la pantalla");
            }
        }
    }
}
