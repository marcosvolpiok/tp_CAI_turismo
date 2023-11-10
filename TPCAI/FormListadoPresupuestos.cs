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

namespace TPCAI
{
    public partial class FormListadoPresupuestos : Form
    {
        ListadoPresupuestosModel model;        

        public FormListadoPresupuestos()
        {
            InitializeComponent();            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FormListadoPresupuestos_Load(object sender, EventArgs e)
        {
            model = new ListadoPresupuestosModel();
            ActualizarPresupuestoVuelos(); // Inicialmente, muestra una lista vacía de vuelos en el dataGridViewPresupuestosVuelos
            //TODO: hacer lo mismo para alojamientos.

            ActualizarPresupuestoAlojamientos();

            ActualizarTotalPresupuesto(); // Agrego esta línea para actualizar el total al cargar el formulario.
                                          // 
            lblPresupuestoActivo.Text = $"Presupuesto Activo: #{ModuloPresupuestos.PresupuestoActivo.CodigoPresupuesto.ToString()}";

        }

        // método para mantener actualizado el presupuesto en pantalla
        private void ActualizarTotalPresupuesto()
        {
            decimal totalVuelos = model.ImporteTotalVuelos();
            decimal totalAlojamientos = model.ImporteTotalAlojamientos();
            label1.Text = $"Presupuesto Activo: {(totalVuelos + totalAlojamientos):C2}";
        }

        private void btnAñadirDatosCliente_Click(object sender, EventArgs e)
        {
            FormAñadirCliente formCliente = new FormAñadirCliente();
            formCliente.ShowDialog();
            ActualizarDatosCliente();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (this.tabControlAlojamientosVuelos.SelectedTab == tabVuelos)
            {
                if (this.dataGridViewPresupuestosVuelos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewPresupuestosVuelos.SelectedRows[0];
                    string vueloId = selectedRow.Cells["IdTarifaVuel"].Value.ToString(); //Obtener algún tipo de identificación de la tarifa a partir de la fila.
                    model.EliminarVueloDelPresupuesto(vueloId);
                    ActualizarPresupuestoVuelos();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione al menos una fila para eliminar el vuelo del presupuesto.");
                    return;
                }
            }
            else if (this.tabControlAlojamientosVuelos.SelectedTab == tabAlojamientos)
            {
                if (this.dataGridViewPresupuestosAlojamientos.SelectedRows.Count > 0)
                {
                    //Lo mismo que arriba pero con hoteles:
                    //1) conseguir fila seleccionada
                    //2) de la fila conseguir un id de tarifa o elemento a borrar.
                    //3) model.EliminarAlojamientoDePresupuesto(tarifaId)
                    //4) ActualizarPresupuestoAlojamientos() (o nombre similar)
                }
                else
                {
                    MessageBox.Show("Por favor seleccione al menos una fila para eliminar el alojamiento del presupuesto.");
                    return;
                }
            }
            
            ActualizarTotalPresupuesto(); // Agrego esta línea para actualizar el total al cargar el formulario.
        }

        
        // CREO METODO PARA ACTUALIZAR GRID VIEW VUELOS
        private void ActualizarPresupuestoVuelos()
        {
            var vuelos = model.ObtenerVuelosPresupuesto();

            dataGridViewPresupuestosVuelos.Rows.Clear();

            // Agrego los vuelos al modelo y actualiza el dataGridView al mismo tiempo
            foreach (var vuelo in vuelos)
            {                
                dataGridViewPresupuestosVuelos.Rows.Add(
                    vuelo.Origen,
                    vuelo.Destino,
                    vuelo.FechaSalida,
                    vuelo.FechaArribo,
                    vuelo.Aerolinea,
                    vuelo.Precio,
                    vuelo.Clase,
                    vuelo.TipoPasajero,
                    vuelo.IdTarifaVuelos
                );
            }
            this.dataGridViewPresupuestosVuelos.Refresh();
        }

        private void ActualizarPresupuestoAlojamientos()
        {
            var alojamientos = model.ObtenerAlojamientosPresupuesto();


            dataGridViewPresupuestosAlojamientos.Rows.Clear();
            // Agrego los vuelos al modelo y actualiza el dataGridView al mismo tiempo
            foreach (var alojamiento in alojamientos)
            {
                foreach(DisponibilidadSubClass disponibilidad in alojamiento.Disponibilidad){
                    foreach(HabitacionesHotelSubClass habitacion in disponibilidad.Habitaciones)
                    {
                        dataGridViewPresupuestosAlojamientos.Rows.Add(
                                                                alojamiento.CodigoCiudad,
                                                                alojamiento.Nombre,
                                                                disponibilidad.Tarifa,
                                                                habitacion.FechaHabitacionHotel,
                                                                alojamiento.Calificacion,
                                                                disponibilidad.Nombre,
                                                                habitacion.IDHabitacion
                                                            );
                    }
                }
                
            }
            this.dataGridViewPresupuestosAlojamientos.Refresh();
        }
        private void ActualizarDatosCliente()
        {
            var nombre = model.NombreCliente();
            var dni = model.DniClilente();

            label2.Text = $"Cliente: {nombre}";
            label3.Text = $"DNI: {dni}";
        }
    }
}
