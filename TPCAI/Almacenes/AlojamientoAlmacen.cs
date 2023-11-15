using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Diagnostics;
using TPCAI.Entidades.SubClasses;
using TPCAI.Entidades;

namespace TPCAI
{
    internal static class AlojamientoAlmacen
    {
        private static readonly List<AlojamientosEnt> alojamientos;

        public static List<AlojamientosEnt> ObtenerAlojamientos()
        {
            return alojamientos;
        }

        static AlojamientoAlmacen()
        {
            if (File.Exists("../../JSON/Alojamientos.json"))
            {
                string contenidoArchivo = File.ReadAllText("../../JSON/Alojamientos.json");
                alojamientos = JsonConvert.DeserializeObject<List<AlojamientosEnt>>(contenidoArchivo);
            }
        }


        public static void Grabar(List<AlojamientosEnt> alojamientosNew) => File.WriteAllText("../../JSON/Alojamientos.json", JsonConvert.SerializeObject(alojamientosNew));
    }
}
