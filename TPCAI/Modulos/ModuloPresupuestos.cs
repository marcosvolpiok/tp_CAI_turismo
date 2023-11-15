using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Almacenes;
using TPCAI.Entidades.SubClasses;
using TPCAI.Entidades;
using TPCAI.Modelos;
using System.Security.Policy;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TPCAI.Modulos
{
    public static class ModuloPresupuestos
    {
        public static PresupuestosEnt PresupuestoActivo { get; set; }
        public static List<PresupuestosEnt> Presupuestos { get; set; } //Referencia viva de Presupuestos
        public static List<Vuelo> VuelosPresupuesto { get; private set; } = new List<Vuelo>();
        public static List<ClienteEnt> clientes { get; set; }

        public static void AgregarAlojamientoAPresupuesto(string idHabitacion)
        {
            int idHabitacionInt;
            if (int.TryParse(idHabitacion, out idHabitacionInt))
            {
                ModuloPresupuestos.PresupuestoActivo.IDHabitacion.Add(idHabitacionInt);
                ModuloPresupuestos.PresupuestoActivo.PrecioTotal = ProductosModulo.ImporteTotalAlojamientos() + ProductosModulo.ImporteTotalVuelos();
            }
            else
            {
                MessageBox.Show("El ID de habitación no es un número");
            }
        }

        internal static void EliminarVueloDeActivo(string vueloId)
        {
            PresupuestoActivo.IdTarifaVuelo.RemoveAll(v => v == vueloId);
        }

        public static void obtenerVueloPorTarifaId(string vueloId)
        {

        }

        internal static void EliminarAlojamientoDeActivo(int IDHabitacion)
        {
            int habitacionAEliminar = -1;

            foreach (int habitacion in PresupuestoActivo.IDHabitacion)
            {
                if(habitacion == IDHabitacion)
                {
                    habitacionAEliminar = habitacion;
                    break;
                }
            }

            if(habitacionAEliminar != -1)
            {
                PresupuestoActivo.IDHabitacion.Remove(habitacionAEliminar);
            }
        }

       public static bool AgregarClientes(Cliente cliente)
        {
            if (Validacion.validarNuevoCliente(cliente) == true)
            {
                ClienteEnt clienteNuevo = new ClienteEnt();
                clienteNuevo.ID = GenerarID();
                clienteNuevo.Nombre = cliente.Nombre;
                clienteNuevo.Apellido = cliente.Apellido;
                clienteNuevo.DNI = long.Parse(cliente.DNI);
                cliente.FechaNacimiento = cliente.FechaNacimiento;

                PresupuestoActivo.Clientes = clienteNuevo;
                clientes.Add(clienteNuevo);

                return true;
            }

            return false;
        }

        private static int GenerarID()
        {
            var nuevoId = 1;

            if (clientes != null && clientes.Count > 0)
            {
                ClienteEnt ultimoCliente = clientes.Last();
                nuevoId = ultimoCliente.ID + 1;
            }

            return nuevoId;
        }

        
        
        //PRESUPUESTOS
        public static int CrearPresupuesto()
        {
            int nuevoCodigoPresupuesto = ObtenerNuevoCodigoPresupuesto();
            return nuevoCodigoPresupuesto;
        }

        private static int ObtenerNuevoCodigoPresupuesto()
        {
            List<PresupuestosEnt> presupuestosTmp = new List<PresupuestosEnt>();
            presupuestosTmp.AddRange(Presupuestos);
            if (Presupuestos != null)
            {
                presupuestosTmp.AddRange(Presupuestos);
            }

            if (presupuestosTmp.Any())
            {
                int ultimoCodigo = presupuestosTmp.Max(p => p.CodigoPresupuesto);                
                return ultimoCodigo + 1;
            }
            else
            {
                return 1;
            }
        }

        public static int ObtengoPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo.CodigoPresupuesto;
        }

        public static void EstablecerPresupuestoActivo(PresupuestosEnt presupuesto)
        {
            PresupuestoActivo = presupuesto;
        }

        public static PresupuestosEnt agregarPresupuestoNuevo()
        {
            int idPresupuestoNuevo = CrearPresupuesto();
            PresupuestosEnt presupuestoNuevo = new PresupuestosEnt();
            presupuestoNuevo.IDHabitacion = new List<int>();
            presupuestoNuevo.IdTarifaVuelo = new List<string>();
            presupuestoNuevo.CodigoPresupuesto = idPresupuestoNuevo;
            presupuestoNuevo.EstadoPresupuesto = "No Guardado";

            if (Presupuestos == null)
            {
                Presupuestos = new List<PresupuestosEnt>();
            }
            Presupuestos.Add(presupuestoNuevo);

            return presupuestoNuevo;
        }

        public static List<PresupuestosEnt> obtenerPresupuestos()
        {
            return Presupuestos;
        }

        public static PresupuestosEnt BusquedaPresupuestoId(int codigoPresupuesto)
        {
            if (Presupuestos != null)
            {
                return Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == codigoPresupuesto);
            }
            else
            {
                return null;
            }
        }

        public static string ObtenerInfoP(PresupuestosEnt presupuestoActivo)
        {
            var presupuesto = Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == presupuestoActivo.CodigoPresupuesto);

            if (presupuesto != null)
            {
                string info = $"Vuelos: {string.Join(", ", presupuesto.IdTarifaVuelo)}, Alojamientos: {string.Join(", ", presupuesto.IDHabitacion)}";
                return info;
            }
            else
            {
                return "Presupuesto no encontrado";
            }
        }
        public static decimal ObtenerInfoPrecioTotal(PresupuestosEnt presupuestoActivo)
        {
            var presupuesto = Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == presupuestoActivo.CodigoPresupuesto);

            if (presupuesto != null)
            {
                decimal infoPrecioTotal = presupuesto.PrecioTotal;
                return infoPrecioTotal;
            }
            else
            {
                return 0;
            }
        }


        public static void AgregarVueloAPresupuesto(string vueloId)
        {
            PresupuestoActivo.IdTarifaVuelo.Add(vueloId);
            ModuloPresupuestos.PresupuestoActivo.PrecioTotal = ProductosModulo.ImporteTotalAlojamientos() + ProductosModulo.ImporteTotalVuelos();
        }


    }
}
