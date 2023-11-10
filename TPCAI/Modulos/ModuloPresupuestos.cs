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

        private static long GenerarID()
        {
            
            // IMPLEMENTAR LOGICA PARA EL ID
            return 0;
        }

        
        
        //PRESUPUESTOS
        public static long CrearPresupuesto()
        {
            long nuevoCodigoPresupuesto = ObtenerNuevoCodigoPresupuesto();
            return nuevoCodigoPresupuesto;
        }

        private static long ObtenerNuevoCodigoPresupuesto()
        {
            // Obtengo la lista de presupuestos del AlmacenPresupuestos
            List<PresupuestosEnt> presupuestos = AlmacenPresupuestos.Presupuestos;

            // Verifico si hay presupuestos existentes
            if (presupuestos.Any())
            {
                // Obtener el código del último presupuesto
                long ultimoCodigo = presupuestos.Max(p => p.CodigoPresupuesto);                
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


    }
}
