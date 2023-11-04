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
    class AlojamientoAlmacen
    {
        public static readonly List<AlojamientosEnt> alojamientos;

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

            /*
            alojamientos = new List<AlojamientosEnt>{
                new AlojamientosEnt {
                    IDAlojamientos = 1,
                    CodigoHotel ="KAU",
                    Nombre = "Kaukaleshen",
                    CodigoCiudad = "CALAF",
                    Direccion = "Av Santa Cruz 1234",
                    Calificacion  = "5 Estrellas",
                    Disponibilidad = new List<DisponibilidadSubClass> {
                        new DisponibilidadSubClass { 
                            Nombre = "SUITE NORMAL",
                            Tarifa = 570000,
                            Capacidad = 2,
                            Menores = 1,
                            Infantes = 1,
                            IDDisponibilidad = 1,
                            Habitaciones = new List <HabitacionesHotelSubClass> {
                                new HabitacionesHotelSubClass {
                                    IDHabitacion = 1,
                                    FechaHabitacionHotel = new DateTime(2024, 03, 03),
                                    Cantidad = 10
                                }
                            }
                     }
                 }
                }
            };
            */

        }

        public static void Grabar() => File.WriteAllText("../../JSON/Alojamientos.json", JsonConvert.SerializeObject(clientes));
    }
}
