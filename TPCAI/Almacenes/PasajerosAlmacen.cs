using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;

namespace TPCAI.Almacenes
{
    class PasajerosAlmacen
    {
        public static List<PasajeroEnt> pasajeros;


        static PasajerosAlmacen()
        {
            pasajeros = new List<PasajeroEnt>()
            {
                new PasajeroEnt { PersonaID = 123, Tipo = "Adulto" },
                new PasajeroEnt { PersonaID = 124, Tipo = "Adulto" },
                new PasajeroEnt { PersonaID = 125, Tipo = "Menor" },
            };
        }
    }
}
