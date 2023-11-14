using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;

namespace TPCAI.Almacenes
{
    internal static class AlmacenPresupuestos
    {
        private static readonly List<PresupuestosEnt> presupuestos;

        public static List<PresupuestosEnt> ObtenerPresupuestos()
        {
            return presupuestos;
        }

        static AlmacenPresupuestos()
        {
            if (File.Exists("../../JSON/Presupuestos.json"))
            {
                var contenidoArchivo = File.ReadAllText("../../JSON/Presupuestos.json");
                presupuestos = JsonConvert.DeserializeObject<List<PresupuestosEnt>>(contenidoArchivo);
            }
            else
            {
                presupuestos = new List<PresupuestosEnt>();
            }
        }



        public static void Grabar() => File.WriteAllText("../../JSON/Presupuestos.json", JsonConvert.SerializeObject(presupuestos));

        

    }
}
