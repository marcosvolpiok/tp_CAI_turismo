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
using TPCAI.Modelos;
using TPCAI.Modulos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPCAI
{
    public partial class FormAñadirPasajero : Form
    {
        AñadirPasajeroModel model;

        public FormAñadirPasajero()
        {
            InitializeComponent();
        }

        private void FormAñadirPasajero_Load(object sender, EventArgs e)
        {
            model = new AñadirPasajeroModel();

            lblPresupuestoActivo.Text = "Presupusto Activo: " + model.ObtenerPresupuestoActivo().CodigoPresupuesto.ToString();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitarPasajero_Click(object sender, EventArgs e)
        {



        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem(new[] { this.textNombre.Text, this.textApellido.Text, this.textDNI.Text, this.dateTimeFechaNacimiento.Value.ToString("dd-MM-yyyy") });
            listViewPasajeros.Items.Add(item);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            foreach (ListViewItem item in listViewPasajeros.Items)
            {
                Pasajero pasajero = new Pasajero();
                pasajero.NombrePasajero = item.SubItems[0].Text;
                pasajero.ApellidoPasajero = item.SubItems[1].Text;
                pasajero.Dni = long.Parse(item.SubItems[2].Text);
                pasajero.FechaNacimiento = DateTime.Parse(item.SubItems[3].Text);
                pasajeros.Add(pasajero);

                MessageBox.Show("Añadiendo pasajero: " + item.SubItems[0].Text);
            }

            model.GuardarPasajeros(pasajeros);
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            ;
            if(ModuloReservas.diccionarioPresupuestoPasajero.TryGetValue(model.ObtenerPresupuestoActivo().CodigoPresupuesto, out List<Pasajero> valorPasajero))
            {
                MessageBox.Show("Cantidad de pasajeros en el presupusto activo: " +
                                ModuloReservas.diccionarioPresupuestoPasajero[model.ObtenerPresupuestoActivo().CodigoPresupuesto].Count().ToString());

                MessageBox.Show("Ahora voy a mostrar un messageBox con el nombre y apellido de cada pasajero en el presupuesto activo.");

                foreach (Pasajero pasajero in ModuloReservas.diccionarioPresupuestoPasajero[model.ObtenerPresupuestoActivo().CodigoPresupuesto])
                {
                    MessageBox.Show("Datos de pasajero: " +
                                " - nombre: " + pasajero.NombrePasajero +
                                " - apellido: " + pasajero.ApellidoPasajero +
                                " - DNI: " + pasajero.Dni +
                                " - FechaNacimiento: " + pasajero.FechaNacimiento.ToString()
                                );
                }
            }
            else
            {
                MessageBox.Show("Añada pasajeros para poder debuggear");
            }
        }
    }
}
