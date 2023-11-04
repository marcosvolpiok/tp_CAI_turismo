using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TPCAI.Almacenes
{
    internal static class AlmacenClientes
    {
        // esto debe ser private, pero lo dejo asi para probar
        internal static readonly List<ClienteEnt> clientes;
        // NO SE SI ESTO ESTA BIEN, REVISAR CON ANDRES
        public static List<ClienteEnt> Clientes
        {
            get { return clientes; }
        }

        static AlmacenClientes()
        {
            if (File.Exists("Clientes.json"))
            {
                var contenidoArchivo = File.ReadAllText("Clientes.json");
                clientes = JsonConvert.DeserializeObject<List<ClienteEnt>>(contenidoArchivo);
            }
            else
            {
                clientes = new List<ClienteEnt> ();
            }
        }

        public static void Grabar() => File.WriteAllText("Clientes.json", JsonConvert.SerializeObject(clientes));

        public static void AgregarCliente(ClienteEnt cliente)
        {
            clientes.Add(cliente);
        }

        public static void QuitarCliente(ClienteEnt cliente)
        {
            clientes.Remove(cliente);
        }

        

    }
}
