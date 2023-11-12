﻿using System;
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
            string nombre = txtNombre.Text;            
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;

            // Creo un objeto Cliente con los datos
            Cliente cliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                FechaNacimiento = fechaNacimiento
            };

            // Llamo método en AñadirClienteModel para agregar el cliente
            if (AñadirClienteModel.AgregarCliente(cliente) == true)
            {
                // MENSAJE DE CONFIRMACION
                MessageBox.Show("Cliente guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                FormListadoPresupuestos presupuestos = new FormListadoPresupuestos(); //OJO! NO PASARLE MÁS ESTE PARÁMETRO
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormListadoPresupuestos formPresup = new FormListadoPresupuestos(); //OJO! NO PASARLE MÁS ESTE PARÁMETRO
            this.Close();
        }

        private void FormAñadirCliente_Load_1(object sender, EventArgs e)
        {
            model = new AñadirClienteModel();

            lblPresupuestoActivo.Text = "Presupuesto Activo: " + model.ObtenerPresupuestoActivo().CodigoPresupuesto.ToString();
        }
    }
}
