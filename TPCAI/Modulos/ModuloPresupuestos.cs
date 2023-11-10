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

namespace TPCAI.Modulos
{
    public static class ModuloPresupuestos
    {
        public static PresupuestosEnt PresupuestoActivo { get; set; }
        public static List<PresupuestosEnt> Presupuestos { get; set; }

        internal static void EliminarVueloDeActivo(string vueloId)
        {
            //TODO: eliminar un vuelo del presupuesto activo. Hacer validaciones si es necesario.
        }


        //CLIENTES
        public static void AgregarClientes(List<Cliente> clientes)
        {
            List<ClienteEnt> clientesEnt = new List<ClienteEnt>();

            foreach (Cliente cliente in clientes)
            {
                ClienteEnt clienteEnt = new ClienteEnt
                {
                    ID = GenerarID(),
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    DNI = Convert.ToInt64(cliente.DNI),
                    FechaNacimiento = cliente.FechaNacimiento.Date
                };

                clientesEnt.Add(clienteEnt);
            }

            // Agrega los clientes a la lista interna de AlmacenClientes
            AlmacenClientes.clientes.AddRange(clientesEnt);

            // Llama al método Grabar() de AlmacenClientes para guardar los datos en el archivo JSON.
            AlmacenClientes.Grabar();
        }

        private static int GenerarID()
        {
            // Obtener la lista de clientes desde AlmacenClientes
            List<ClienteEnt> clientes = AlmacenClientes.Clientes;

            var nuevoId = 1; // Valor predeterminado si no hay clientes registrados

            // Verifico si hay clientes registrados
            if (clientes != null && clientes.Count > 0)
            {
                // Obtengo el último cliente registrado
                ClienteEnt ultimoCliente = clientes.Last();

                // Incrementar el ID del último cliente en 1
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
            presupuestosTmp.AddRange(AlmacenPresupuestos.Presupuestos);
            if (Presupuestos != null)
            {
                presupuestosTmp.AddRange(Presupuestos);
            }

            // Verifico si hay presupuestos existentes
            if (presupuestosTmp.Any())
            {
                // Obtener el código del último presupuesto
                int ultimoCodigo = presupuestosTmp.Max(p => p.CodigoPresupuesto);                
                return ultimoCodigo + 1;
            }
            else
            {
                // Si no hay presupuestos, comenzar desde el código 1
                return 1;
            }
        }

        public static int ObtengoPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo.CodigoPresupuesto;
        }

        public static PresupuestosEnt agregarPresupuestoNuevo()
        {
            int idPresupuestoNuevo = CrearPresupuesto();
            PresupuestosEnt presupuestoNuevo = new PresupuestosEnt();
            presupuestoNuevo.CodigoPresupuesto = idPresupuestoNuevo;

            if (ModuloPresupuestos.Presupuestos == null)
            {
                ModuloPresupuestos.Presupuestos = new List<PresupuestosEnt>();
            }
            ModuloPresupuestos.Presupuestos.Add(presupuestoNuevo);

            return presupuestoNuevo;
        }

        public static List<PresupuestosEnt> obtenerPresupuestos()
        {
            List<PresupuestosEnt> tmpPresup = new List<PresupuestosEnt>();
            tmpPresup.AddRange(AlmacenPresupuestos.presupuestos);
            if (Presupuestos != null)
            {
                tmpPresup.AddRange(Presupuestos);
            }

            return tmpPresup;
        }
    }
}
