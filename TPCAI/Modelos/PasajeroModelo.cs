using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Modelos;
using TPCAI.Entidades;
using TPCAI.Almacenes;


namespace TPCAI.Modelos
{
    class PasajeroModelo
    {
        public static PasajeroEnt AgregarPersona(PasajeroEnt pasajero)
        {
            Int32 id = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

            pasajero.Persona.PasajeroID = id;
            pasajero.ID = id;
            PasajerosAlmacen.pasajeros.Add(pasajero);

            return pasajero;
        }
    }
}
