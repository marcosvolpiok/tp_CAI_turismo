using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Diagnostics;

namespace TPCAI
{
    internal static class AlojamientoAlmacen
    {
        internal static readonly List<AlojamientosEnt> alojamientos;

        public static List<AlojamientosEnt> Alojamientos
        {
            get { return alojamientos; }
        }

        static AlojamientoAlmacen()
        {
            if (File.Exists("../../JSON/Alojamientos.json"))
            {
                string contenidoArchivo = File.ReadAllText("../../JSON/Alojamientos.json");
                alojamientos = JsonConvert.DeserializeObject<List<AlojamientosEnt>>(contenidoArchivo);
            }
            else
            {
                alojamientos = new List<AlojamientosEnt>();
            }
        }

        public static void Grabar() => File.WriteAllText("../../JSON/Alojamientos.json", JsonConvert.SerializeObject(alojamientos));
    }
}
