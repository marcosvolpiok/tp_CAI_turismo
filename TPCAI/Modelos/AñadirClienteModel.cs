using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Modulos;

namespace TPCAI
{
    internal class AñadirClienteModel
    {
        public static List<Cliente> Clientes = new List<Cliente>();
        /*public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }*/

        internal static void AgregarCliente(Cliente cliente)
        {
            // Agregar lógica de validación para el cliente si es necesario

            Clientes.Add(cliente);
            ModuloPresupuestos.AgregarClientes(Clientes);
        }
    }
}
