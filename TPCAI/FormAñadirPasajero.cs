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
using TPCAI.Extras;
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

            cargarComboProductos();
        }


        private void cargarComboProductos()
        {
            List<Producto> productosRepetidos = new List<Producto>();
            List<Producto> productos = new List<Producto>();

            //Añade Habitaciones
            string nombreHabitacion;
            if (model.ObtenerPresupuestoActivo().IDHabitacion != null && model.ObtenerPresupuestoActivo().IDHabitacion.Count() > 0)
            {
                foreach (int habitacion in model.ObtenerPresupuestoActivo().IDHabitacion)
                {
                    nombreHabitacion = model.ObtenerHabitacionNombre(habitacion);
                    DisponibilidadSubClass dispobibilidad = model.ObtenerDisponibilidadDeHabitacionID(habitacion);

                    if (nombreHabitacion == null)
                    {
                        MessageBox.Show("Habitación ID: " + habitacion + " No encontrada");
                    }
                    else
                    {
                        //Obtiene hotel a la que pertenece la habitacion
                        //Muestra info del hotel
                        Alojamiento alojamiento = model.ObtenerAlojamientoDeHabitacionID(habitacion);


                        Producto producto = new Producto();
                        producto.nombre = alojamiento.Nombre;
                        producto.IDDisponibilidadAlojamiento = dispobibilidad.IDDisponibilidad;
                        productosRepetidos.Add(producto);
                    }
                }

                productos = productosRepetidos.Distinct(new ProductoEqualityComparer()).ToList();
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
                var item = new ListViewItem(new[] { this.textNombre.Text, this.textApellido.Text, this.textDNI.Text, this.dateTimeFechaNacimiento.Value.ToString("dd-MM-yyyy"), null, productoSeleccionado.IDDisponibilidadAlojamiento.ToString() });
                listViewPasajeros.Items.Add(item);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (model.validarPasajerosDeDataGridView(this.listViewPasajeros, comboProductos))
            {
                List<Pasajero> pasajeros = new List<Pasajero>();
                foreach (ListViewItem item in listViewPasajeros.Items)
                {
                    Pasajero pasajero = new Pasajero();
                    pasajero.NombrePasajero = item.SubItems[0].Text;
                    pasajero.ApellidoPasajero = item.SubItems[1].Text;
                    pasajero.Dni = long.Parse(item.SubItems[2].Text);
                    pasajero.FechaNacimiento = DateTime.Parse(item.SubItems[3].Text);

                    if(item.SubItems[4].Text!= null && item.SubItems[4].Text != "")
                    {
                        pasajero.IdTarifaVuelos = item.SubItems[4].Text;
                    }

                    if (item.SubItems[5].Text != null && item.SubItems[5].Text != "")
                    {
                        DisponibilidadSubClass disponibilidad = model.ObtenerDisponibilidadPorHabitacionID(int.Parse(item.SubItems[5].Text));
                        pasajero.IdAlojamiento = disponibilidad.IDDisponibilidad.ToString();
                    }
                    pasajeros.Add(pasajero);
                }

                model.GuardarPasajeros(pasajeros);

                MessageBox.Show("Pasajeros guardados en el presupuesto activo");
            }
        }
    }
}
