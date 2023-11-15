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
        private static readonly List<ClienteEnt> clientes;

        public static List<ClienteEnt> ObtenerClientes()
        {
            return clientes;
        }

        static AlmacenClientes()
        {
            if (File.Exists("../../JSON/Clientes.json"))
            {
                var contenidoArchivo = File.ReadAllText("../../JSON/Clientes.json");
                clientes = JsonConvert.DeserializeObject<List<ClienteEnt>>(contenidoArchivo);
            }
            else
            {
                clientes = new List<ClienteEnt> ();
            }
        }

        public static void Grabar() => File.WriteAllText("../../JSON/Clientes.json", JsonConvert.SerializeObject(clientes));
    }
}
