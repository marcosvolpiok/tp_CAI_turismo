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

namespace TPCAI
{
    internal static class AlojamientoAlmacen
    {
        public static void Leer()
        {
            if (File.Exists("../../JSON/Alojamientos.json"))
            {
                string contenidoArchivo = File.ReadAllText("../../JSON/Alojamientos.json");
                ProductosModulo.alojamientos = JsonConvert.DeserializeObject<List<AlojamientosEnt>>(contenidoArchivo);
            }
        }

        public static void Grabar() => File.WriteAllText("../../JSON/Alojamientos.json", JsonConvert.SerializeObject(ProductosModulo.alojamientos));
    }
}
