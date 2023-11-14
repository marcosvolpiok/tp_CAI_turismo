using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;
using System.Windows.Forms;

namespace TPCAI.Almacenes
{
    internal static class CiudadAlmacen
    {
        static CiudadAlmacen()
        {
           
        }

        public static void Leer()
        {
            if (File.Exists("../../JSON/Ciudades.json"))
            {
                string contenidoArchivo = File.ReadAllText("../../JSON/Ciudades.json");
                ProductosModulo.ciudades = JsonConvert.DeserializeObject<CiudadesEnt>(contenidoArchivo);
            }
        }
    }
}
