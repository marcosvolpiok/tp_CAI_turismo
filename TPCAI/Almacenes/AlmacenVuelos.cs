using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;

namespace TPCAI.Almacenes
{
    internal static class AlmacenVuelos
    {
        // esto debe ser private, pero lo dejo asi para probar
        internal static readonly List<VuelosEnt> vuelos;
        // NO SE SI ESTO ESTA BIEN, REVISAR CON ANDRES

        public static List<VuelosEnt> Vuelos
        {
            get { return vuelos; }
        }

        static AlmacenVuelos()
        {
            if (File.Exists("../../Archivos/Vuelos.json"))
            {
                var contenidoArchivo = File.ReadAllText("../../Archivos/Vuelos.json");
                vuelos = JsonConvert.DeserializeObject<List<VuelosEnt>>(contenidoArchivo);
            }
            else
            {
                vuelos = new List<VuelosEnt>();
            }
        }



        public static void Grabar() => File.WriteAllText("../../Archivos/Vuelos.json", JsonConvert.SerializeObject(vuelos));

        public static void AgregarCliente(VuelosEnt vuelo)
        {
            vuelos.Add(vuelo);
        }

        public static void QuitarCliente(VuelosEnt vuelo)
        {
            vuelos.Remove(vuelo);
        }

    }
}
