using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Modulos;
using TPCAI.Entidades.SubClasses;
using TPCAI.Almacenes;
using TPCAI.Modelos;
using TPCAI.Modulos;
using System.Windows.Forms;
using TPCAI.Entidades;

namespace TPCAI.Modelos
{
    internal class ListadoVuelosModel
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaIda { get; set; }
        public DateTime FechaVuelta { get; set; }
        public int CantAdultos { get; set; }
        public int CantMenores { get; set; }
        public int CantInfantes { get; set; }
        public string Clase { get; set; }

        public List<Vuelo> VuelosFiltrados { get; set; }

        public CiudadesEnt obtenerCiudades()
        {
            return ProductosModulo.ciudades;
        }

        public CiudadesDetailSubClass obtenerCiudadPorCodigo(string codigoCiudad)
        {
            CiudadesEnt ciudades = ProductosModulo.ciudades;
            foreach (CiudadesDetailSubClass ciudad in ciudades.Ciudades)
            {
                if (ciudad.CodigoISO == codigoCiudad)
                {
                    return ciudad;
                }
            }

            MessageBox.Show("Código de ciudad " + codigoCiudad + " no encontrado");
            CiudadesDetailSubClass ciudadVacia = new CiudadesDetailSubClass();
            ciudadVacia.Nombre = "-";
            return ciudadVacia;
        }


        public void BuscarVuelos()
        {
            // Realiza la búsqueda de vuelos y guarda los resultados en VuelosFiltrados.
            VuelosFiltrados = new List<Vuelo>();
            //VuelosFiltrados = ProductosModulo.BusquedaVuelos(this);            

            bool resultadoValidacion = Validacion.validarDatosVuelo(this.Origen, this.Destino, this.FechaIda.ToString(), this.FechaVuelta.ToString(), this.CantAdultos.ToString(), this.CantMenores.ToString(), this.CantInfantes.ToString(), this.Clase);

            if (resultadoValidacion == true)
            {
                VuelosFiltrados = ProductosModulo.BusquedaVuelos(this);
            }
        }

        public void AgregarVueloAPresupuesto(string vueloId)
        {
            ModuloPresupuestos.AgregarVueloAPresupuesto(vueloId);

        }


        public int PresupuestoActivo()
        {
            var presupuestoActivo = ModuloPresupuestos.ObtengoPresupuestoActivo();
            return presupuestoActivo;
        }
    }
}
