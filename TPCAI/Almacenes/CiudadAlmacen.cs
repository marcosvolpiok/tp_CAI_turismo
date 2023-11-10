using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;

namespace TPCAI.Almacenes
{
    internal static class CiudadAlmacen
    {
        internal static readonly CiudadesEnt ciudades;

        public static CiudadesEnt ListadoCiudades
        {
            get { return ciudades; }
        }

        static CiudadAlmacen()
        {
            if (File.Exists("../../JSON/Ciudades.json"))
            {
                string contenidoArchivo = File.ReadAllText("../../JSON/Ciudades.json");
                ciudades = JsonConvert.DeserializeObject<CiudadesEnt>(contenidoArchivo);
            }
            else
            {
                ciudades = new CiudadesEnt();
            }
        }
    }
}
