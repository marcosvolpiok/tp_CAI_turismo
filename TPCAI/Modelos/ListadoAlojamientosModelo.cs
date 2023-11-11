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
        public string IdDisponibilidadsSeleccionada { get; set; } // Nueva propiedad

        public List<Alojamiento> AlojamientosFiltrados { get; private set; }

        public CiudadesEnt obtenerCiudades()
        {
            return ProductosModulo.obtenerCiudades();
        }

        public CiudadesDetailSubClass obtenerCiudadPorCodigo(string codigoCiudad)
        {
            CiudadesEnt ciudades = ProductosModulo.obtenerCiudades();
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
            //return ProductosModulo.ObtenerAlojamientos();
            AlojamientosFiltrados = ProductosModulo.ObtenerAlojamientos();
        }

        public void BuscarAlojamientosFiltrados()
        {
            AlojamientosFiltrados = ProductosModulo.ObtenerAlojamientosFiltrados(this);
        }

        public void AgregarAlojamientoAPresupuesto(string idHabitacion)
        {

            int idHabitacionInt;
            if (int.TryParse(idHabitacion, out idHabitacionInt)){
                ModuloPresupuestos.PresupuestoActivo.IDHabitacion.Add(idHabitacionInt);
            }
            else
            {
                MessageBox.Show("El ID de habitación no es un número");
            }
        }

        public PresupuestosEnt ObtenerPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo;
        }
    }
}
