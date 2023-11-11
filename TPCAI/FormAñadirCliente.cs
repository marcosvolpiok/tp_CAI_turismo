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
    public partial class FormAñadirCliente : Form
    {
        AñadirClienteModel model;

        public FormAñadirCliente()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Recopilo los datos del formulario
            //AGREGAR VALIDACIONES
            string nombre = textBox1.Text;            
            string apellido = textBox2.Text;
            string dni = textBox3.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;

            /*
            model.Nombre = textBox1.Text;
            model.Apellido = textBox2.Text;
            model.DNI = textBox3.Text;
            model.FechaNacimiento = dateTimePicker1.Value;*/

            // Creo un objeto Cliente con los datos
            ClienteEnt cliente = new ClienteEnt
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = long.Parse(dni),
                FechaNacimiento = fechaNacimiento
            };

            // Llamo método en AñadirClienteModel para agregar el cliente
            AñadirClienteModel.AgregarCliente(cliente);

            // MENSAJE DE CONFIRMACION
            MessageBox.Show("Cliente guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            FormListadoPresupuestos presupuestos = new FormListadoPresupuestos(); //OJO! NO PASARLE MÁS ESTE PARÁMETRO
            presupuestos.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListadoPresupuestos formPresup = new FormListadoPresupuestos(); //OJO! NO PASARLE MÁS ESTE PARÁMETRO
            formPresup.Show();
        }

        private void FormAñadirCliente_Load_1(object sender, EventArgs e)
        {
            model = new AñadirClienteModel();

            lblPresupuestoActivo.Text = "Presupuesto Activo: " + model.ObtenerPresupuestoActivo().CodigoPresupuesto.ToString();
        }
    }
}
