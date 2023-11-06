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
