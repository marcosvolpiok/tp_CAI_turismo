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

            lblDNICliente.Text = "";
            lblNombreCliente.Text = "";


            ActualizarPresupuestoVuelos();

            ActualizarPresupuestoAlojamientos();

            ActualizarTotalPresupuesto();

            ActualizarDatosCliente();

            lblPresupuestoActivo.Text = $"Presupuesto Activo: {model.ObtenerPresupuestoActivo().CodigoPresupuesto.ToString()}";

        }

        // método para mantener actualizado el presupuesto en pantalla
        private void ActualizarTotalPresupuesto()
        {
            decimal totalVuelos = model.ImporteTotalVuelos();
            decimal totalAlojamientos = model.ImporteTotalAlojamientos();
            lblTotal.Text = $"Total Presupuesto Activo: {(totalVuelos + totalAlojamientos):C2}";
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
                    string vueloId = selectedRow.Cells["IdTarifaVuel"].Value.ToString();
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

                    DataGridViewRow selectedRow = dataGridViewPresupuestosAlojamientos.SelectedRows[0];
                    int IDHabitacion = int.Parse(selectedRow.Cells["IDHabitacion"].Value.ToString());
                    model.EliminarAlojamientoDelPresupuesto(IDHabitacion);
                    ActualizarPresupuestoAlojamientos();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione al menos una fila para eliminar el alojamiento del presupuesto.");
                    return;
                }
            }
            
            ActualizarTotalPresupuesto();
        }

        
        // CREO METODO PARA ACTUALIZAR GRID VIEW VUELOS
        private void ActualizarPresupuestoVuelos()
        {

            var vuelos = model.ObtenerVuelosPresupuesto();
            //Console.WriteLine(vuelos);

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
                                                                model.obtenerCiudadPorCodigo(alojamiento.CodigoCiudad).Nombre,
                                                                alojamiento.Nombre,
                                                                disponibilidad.Tarifa,
                                                                habitacion.FechaHabitacionHotel.ToString("dd-MM-yyyy"),
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

            lblNombreCliente.Text = $"Cliente: {nombre}";
            lblDNICliente.Text = $"DNI: {dni}";
        }
    }
}
