using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;
using TPCAI.Modulos;

namespace TPCAI
{
    public class ListadoAlojamientosModelo
    {
        public string destino { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaEgreso { get; set; }
        public string cantidadAdultos { get; set; }
        public string cantidadMenores { get; set; }
        public string cantidadInfantes { get; set; }
        public string calificacion { get; set; }
        public string IdDisponibilidadsSeleccionada { get; set; }

        public List<Alojamiento> AlojamientosFiltrados { get; private set; }

        public CiudadesEnt obtenerCiudades()
        {
            return ProductosModulo.ciudades;
        }

        public CiudadesDetailSubClass obtenerCiudadPorCodigo(string codigoCiudad)
        {
            CiudadesEnt ciudades = ProductosModulo.ciudades;
            foreach(CiudadesDetailSubClass ciudad in ciudades.Ciudades)
            {
                if(ciudad.CodigoISO == codigoCiudad)
                {
                    return ciudad;
                }
            }

            MessageBox.Show("Código de ciudad " + codigoCiudad + " no encontrado");
            CiudadesDetailSubClass ciudadVacia = new CiudadesDetailSubClass();
            ciudadVacia.Nombre = "-";
            return ciudadVacia;
        }


        public void BuscarAlojaimentos()
        {
            AlojamientosFiltrados = ProductosModulo.ObtenerAlojamientos();
        }

        public void BuscarAlojamientosFiltrados()
        {

            bool resultadoValidacion = Validacion.validarFiltrosBusquedaAlojamiento(
                this.destino,
                this.fechaIngreso,
                this.fechaEgreso,
                this.cantidadAdultos,
                this.cantidadMenores,
                this.cantidadInfantes,
                this.calificacion
                );
            if (resultadoValidacion == true)
            {
                if (this.calificacion == "TODOS")
                {
                    this.calificacion = "";
                }

                AlojamientosFiltrados = ProductosModulo.ObtenerAlojamientosFiltrados(this);
            }
        }

        public void AgregarAlojamientoAPresupuesto(string idHabitacion)
        {
            ModuloPresupuestos.AgregarAlojamientoAPresupuesto(idHabitacion);
        }

        public PresupuestosEnt ObtenerPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo;
        }
    }
}
