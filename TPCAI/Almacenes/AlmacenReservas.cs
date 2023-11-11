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
    internal static class AlmacenReservas
    {
        // esto debe ser private, pero lo dejo asi para probar
        internal static readonly List<ReservasEnt> reservas;
        // NO SE SI ESTO ESTA BIEN, REVISAR CON ANDRES

        public static List<ReservasEnt> Reservas
        {
            get { return reservas; }
        }

        static AlmacenReservas()
        {
            if (File.Exists("../../JSON/Reservas.json"))
            {
                var contenidoArchivo = File.ReadAllText("../../JSON/Reservas.json");
                reservas = JsonConvert.DeserializeObject<List<ReservasEnt>>(contenidoArchivo);
            }
            else
            {
                reservas = new List<ReservasEnt>();
            }
        }



        public static void Grabar() => File.WriteAllText("../../JSON/Reservas.json", JsonConvert.SerializeObject(reservas));

        public static void AgregarPresupuesto(ReservasEnt presupuesto)
        {
            reservas.Add(presupuesto);
        }

        public static void QuitarPresupuesto(ReservasEnt presupuesto)
        {
            reservas.Remove(presupuesto);
        }

    }
}
