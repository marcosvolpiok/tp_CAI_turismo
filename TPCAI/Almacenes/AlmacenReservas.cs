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
    internal static class AlmacenReservas
    {
        private static readonly List<ReservasEnt> reservas;

        public static List<ReservasEnt> ObtenerReservas()
        {
            return reservas;
        }

        static AlmacenReservas()
        {
            if (File.Exists("../../JSON/Reservas.json"))
            {
                var contenidoArchivo = File.ReadAllText("../../JSON/Reservas.json");
                reservas = JsonConvert.DeserializeObject<List<ReservasEnt>>(contenidoArchivo);
            }
        }
        public static void Grabar() => File.WriteAllText("../../JSON/Reservas.json", JsonConvert.SerializeObject(reservas));

        public static void AgregarReserva(ReservasEnt reserva)
        {
            reservas.Add(reserva);
        }

        public static void QuitarReserva(ReservasEnt reserva)
        {
            reservas.Remove(reserva);
        }

    }
}
