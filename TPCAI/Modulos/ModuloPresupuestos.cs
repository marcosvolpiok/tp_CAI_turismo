using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Almacenes;
using TPCAI.Entidades.SubClasses;
using TPCAI.Entidades;
using TPCAI.Modelos;

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


        

    }
}
