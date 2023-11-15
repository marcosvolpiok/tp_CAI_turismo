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
            string nombre = txtNombre.Text;            
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;

            Cliente cliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                FechaNacimiento = fechaNacimiento
            };

            if (AñadirClienteModel.AgregarCliente(cliente) == true)
            {
                MessageBox.Show("Cliente guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                FormListadoPresupuestos presupuestos = new FormListadoPresupuestos();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormListadoPresupuestos formPresup = new FormListadoPresupuestos();
            this.Close();
        }

        private void FormAñadirCliente_Load_1(object sender, EventArgs e)
        {
            model = new AñadirClienteModel();

            lblPresupuestoActivo.Text = "Presupuesto Activo: " + model.ObtenerPresupuestoActivo().CodigoPresupuesto.ToString();
        }
    }
}
