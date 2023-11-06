using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI.Modelos;

namespace TPCAI
{
    public partial class FormListadoVuelos : Form
    {

        public FormListadoVuelos()
        {
            InitializeComponent();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos listadoPresupuestos = new FormListadoPresupuestos("VUELOS");
            listadoPresupuestos.Show();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromMenu menu = new FromMenu();
            menu.Show();
        }

        private void FormListadoVuelos_Load(object sender, EventArgs e)
        {
            this.dataGridViewListadoVuelos.Rows.Add("CABA, Argentina", "La Habana, Cuba", "20/10/2023 00:30", "20/10/2023 06:30", "Latam", "$120.000", "Economy", "Adulto");

        }

        private void btnAñadirAPresupuesto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vuelo añadido a presupuesto 4545");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ListadoVuelosModel vuelosModel = new ListadoVuelosModel
            {
                Origen = comboBox2.Text,
                Destino = comboBox3.Text,
                FechaIda = dateTimePicker1.Value,
                FechaVuelta = dateTimePicker2.Value,
                CantAdultos = 0,
                CantMenores = 0,
                CantInfantes = 0,
                Clase = comboBox1.Text
            };

            if (int.TryParse(textBox4.Text, out int cantAdultos))
            {
                vuelosModel.CantAdultos = cantAdultos;
            }

            if (int.TryParse(textBox5.Text, out int cantMenores))
            {
                vuelosModel.CantMenores = cantMenores;
            }

            if (int.TryParse(textBox6.Text, out int cantInfantes))
            {
                vuelosModel.CantInfantes = cantInfantes;
            }

            //PRUEBA
            /*ListadoVuelosModel vuelosModel = new ListadoVuelosModel
            {
                Origen = "MIA",
                Destino = "LAX",
                FechaIda = new DateTime(2024, 10, 2),
                FechaVuelta = new DateTime(2024, 10, 2),
                CantAdultos = 1, // Ajusta la cantidad de pasajeros según tus necesidades de prueba
                CantMenores = 0,
                CantInfantes = 0,
                Clase = "Economy" // Ajusta la clase de vuelo según tus necesidades de prueba
            };*/


            vuelosModel.BuscarVuelos(); // Realiza la búsqueda de vuelos.

            // Mapear los resultados en el dataGridViewListadoVuelos
            this.dataGridViewListadoVuelos.Rows.Clear();
            foreach (var vuelo in vuelosModel.VuelosFiltrados)
            {
                this.dataGridViewListadoVuelos.Rows.Add(
                    vuelo.Origen,
                    vuelo.Destino,
                    vuelo.FechaSalida,
                    vuelo.FechaArribo,
                    vuelo.Aerolinea,
                    vuelo.Precio,
                    vuelo.Clase,
                    vuelo.TipoPasajero
                );
            }
            this.dataGridViewListadoVuelos.Refresh();

            MessageBox.Show("Vuelos encontrados listados en la pantalla");
        }
    }
}
