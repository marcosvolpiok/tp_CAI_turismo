﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TPCAI.Modelos;
using TPCAI.Modulos;

namespace TPCAI
{
    public partial class FromMenu : Form
    {
        MenuModelo model;

        public FromMenu()
        {
            InitializeComponent();
        }

        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            if (model.PresupuestoActivo() == null)
            {
                MessageBox.Show("Seleccione un presupuesto primero.");
                return;
            }

            if(model.PresupuestoActivo().EstadoPresupuesto == "Guardado")
            {
                MessageBox.Show("No se puede añadir productos a un presupuesto en este estado.");
                return;
            }

            FormListadoVuelos vuelos = new FormListadoVuelos();
            vuelos.ShowDialog();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarReservas_Click(object sender, EventArgs e)
        {
            FormGenerarReservas generarReservas = new FormGenerarReservas();
            generarReservas.ShowDialog();
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            FormConsultarReservas consultarReservas = new FormConsultarReservas();
            consultarReservas.ShowDialog();
        }

        private void FromMenu_Load(object sender, EventArgs e)
        {
            model = new MenuModelo();
        }

        private void btnAlojamientos_Click(object sender, EventArgs e)
        {
            if (model.PresupuestoActivo() == null)
            {
                MessageBox.Show("Seleccione un presupuesto primero.");
                return;
            }

            if (model.PresupuestoActivo().EstadoPresupuesto == "Guardado")
            {
                MessageBox.Show("No se puede añadir productos a un presupuesto en este estado.");
                return;
            }

            FormListadoAlojamiento alojamiento = new FormListadoAlojamiento();
            alojamiento.ShowDialog();
        }
    }
}
