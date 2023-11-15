using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;

namespace TPCAI.Almacenes
{
    internal static class AlmacenVuelos
    {
        private static readonly List<VuelosEnt> vuelos;


        static AlmacenVuelos()
        {
            if (File.Exists("../../JSON/Vuelos.json"))
            {
                var contenidoArchivo = File.ReadAllText("../../JSON/Vuelos.json");
                vuelos = JsonConvert.DeserializeObject<List<VuelosEnt>>(contenidoArchivo);
            }
            else
            {
                vuelos = new List<VuelosEnt>();
            }
        }

        public static List<VuelosEnt> ObtenerVuelos()
        {
            return vuelos;
        }


        public static void Grabar(List<VuelosEnt> vuelosNew) => File.WriteAllText("../../JSON/Vuelos.json", JsonConvert.SerializeObject(vuelosNew));
    }
}
