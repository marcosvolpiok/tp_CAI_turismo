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

            if (model.ObtenerPresupuestoActivo() == null)
            {
                MessageBox.Show("Seleccione un presupuesto primero");
                this.Close();
            }
            else
            {
                if ((model.ObtenerPresupuestoActivo().IDHabitacion == null || model.ObtenerPresupuestoActivo().IDHabitacion.Count() == 0) &&
                    (model.ObtenerPresupuestoActivo().IdTarifaVuelo == null || model.ObtenerPresupuestoActivo().IdTarifaVuelo.Count() == 0) ) {
                    MessageBox.Show("Añada Productos al presupuesto primero");
                    this.Close();
                }
                else
                {
                    lblPresupuestoActivo.Text = "Presupusto Activo: " + model.ObtenerPresupuestoActivo().CodigoPresupuesto.ToString();

                    cargarComboProductos();
                }
            }
        }


        private void cargarComboProductos()
        {
            List<Producto> productos = new List<Producto>();

            //Añade Habitaciones
            string nombreHabitacion;
            if (model.ObtenerPresupuestoActivo().IDHabitacion != null && model.ObtenerPresupuestoActivo().IDHabitacion.Count() > 0)
            {
                foreach (int habitacion in model.ObtenerPresupuestoActivo().IDHabitacion)
                {
                    nombreHabitacion = model.ObtenerHabitacionNombre(habitacion);
                    if (nombreHabitacion == null)
                    {
                        MessageBox.Show("Habitación ID: " + habitacion + " No encontrada");
                    }
                    else
                    {
                        Producto producto = new Producto();
                        producto.nombre = nombreHabitacion;
                        producto.idhabitacion = habitacion;
                        productos.Add(producto);
                    }
                }
            }


            //Añade Vuelos
            if (model.ObtenerPresupuestoActivo().IdTarifaVuelo != null && model.ObtenerPresupuestoActivo().IdTarifaVuelo.Count() > 0)
            {
                string nombreVuelo;
                foreach (string vuelo in model.ObtenerPresupuestoActivo().IdTarifaVuelo)
                {
                    nombreVuelo = model.ObtenerVueloNombre(vuelo);
                    if (nombreVuelo == null)
                    {
                        MessageBox.Show("Vuelo ID: " + vuelo + " No encontrada");
                    }
                    else
                    {
                        Producto producto = new Producto();
                        producto.nombre = nombreVuelo;
                        producto.idVuelo = vuelo;
                        productos.Add(producto);
                    }
                }
            }

            comboProductos.Items.AddRange(productos.ToArray());
            comboProductos.DisplayMember = "nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitarPasajero_Click(object sender, EventArgs e)
        {
            if (listViewPasajeros.SelectedItems.Count > 0)
            {
                listViewPasajeros.Items.Remove(listViewPasajeros.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Seleccione un pasajero de la lista");
            }
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {            
            Producto productoSeleccionado = comboProductos.SelectedItem as Producto;

            if(productoSeleccionado == null)
            {
                var item = new ListViewItem(new[] { this.textNombre.Text, this.textApellido.Text, this.textDNI.Text, this.dateTimeFechaNacimiento.Value.ToString("dd-MM-yyyy"), null, null });
                listViewPasajeros.Items.Add(item);
            }
            else if (productoSeleccionado.idVuelo != null)
            {
                var item = new ListViewItem(new[] { this.textNombre.Text, this.textApellido.Text, this.textDNI.Text, this.dateTimeFechaNacimiento.Value.ToString("dd-MM-yyyy"), productoSeleccionado.idVuelo.ToString(), null });
                listViewPasajeros.Items.Add(item);
            }
            else
            {
                var item = new ListViewItem(new[] { this.textNombre.Text, this.textApellido.Text, this.textDNI.Text, this.dateTimeFechaNacimiento.Value.ToString("dd-MM-yyyy"), null, productoSeleccionado.idhabitacion.ToString() });
                listViewPasajeros.Items.Add(item);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (model.validarPasajerosDeDataGridView(this.listViewPasajeros))
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
                }

                model.GuardarPasajeros(pasajeros);

                MessageBox.Show("Pasajeros guardados en el presupuesto activo");
            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            ;
            if(model.ObtenerPasajerosPresupuestos().TryGetValue(model.ObtenerPresupuestoActivo().CodigoPresupuesto, out List<Pasajero> valorPasajero))
            {
                MessageBox.Show("Cantidad de pasajeros en el presupusto activo: " +
                                model.ObtenerPasajerosPresupuestos()[model.ObtenerPresupuestoActivo().CodigoPresupuesto].Count().ToString());

                MessageBox.Show("Ahora voy a mostrar un messageBox con el nombre y apellido de cada pasajero en el presupuesto activo.");

                foreach (Pasajero pasajero in model.ObtenerPasajerosPresupuestos()[model.ObtenerPresupuestoActivo().CodigoPresupuesto])
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

        private void btnCargarVuelo_Click(object sender, EventArgs e)
        {
            // ***** DEBUG 
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            // Borrar este método porque le está pegando al Módulo, SOLO PARA DEBUGGEAR PORQUE NO ANDA LA CARGA DE VUELOS A PRESUPUESTO
            PresupuestosEnt nuevoPresupDEBUGVuelo = new PresupuestosEnt();
            nuevoPresupDEBUGVuelo.IdTarifaVuelo = new List<string> { "TV1" };
            ModuloPresupuestos.PresupuestoActivo = nuevoPresupDEBUGVuelo;

            cargarComboProductos();
        }
    }
}
