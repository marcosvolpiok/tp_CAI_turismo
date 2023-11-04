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
    public partial class FormAñadirCliente : Form
    {
        private AñadirClienteModel model;

        public FormAñadirCliente()
        {
            InitializeComponent();
            this.model = model;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Recopilo los datos del formulario
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string dni = textBox3.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;

            // Creo un objeto Cliente con los datos
            Cliente cliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                FechaNacimiento = fechaNacimiento
            };

            // Llamo método en AñadirClienteModel para agregar el cliente
            AñadirClienteModel.AgregarCliente(cliente);

            // MENSAJE DE CONFIRMACION
            MessageBox.Show("Cliente guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            FormListadoPresupuestos presupuestos = new FormListadoPresupuestos("VUELOS"); //OJO! NO PASARLE MÁS ESTE PARÁMETRO
            presupuestos.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos formPresup = new FormListadoPresupuestos("VUELOS"); //OJO! NO PASARLE MÁS ESTE PARÁMETRO
            formPresup.Show();
        }
    }
}
