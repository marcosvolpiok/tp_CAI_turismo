using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TPCAI.Entidades;

namespace TPCAI.Almacenes
{
    internal static class AlmacenPresupuestos
    {
        // esto debe ser private, pero lo dejo asi para probar
        internal static readonly List<PresupuestosEnt> presupuestos;
        // NO SE SI ESTO ESTA BIEN, REVISAR CON ANDRES

        public static List<PresupuestosEnt> Presupuestos
        {
            get { return presupuestos; }
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

        public static void AgregarPresupuesto(PresupuestosEnt presupuesto)
        {
            presupuestos.Add(presupuesto);
        }

        public static void QuitarPresupuesto(PresupuestosEnt presupuesto)
        {
            presupuestos.Remove(presupuesto);
        }

    }
}
