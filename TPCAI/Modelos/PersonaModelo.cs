using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;
using TPCAI.Almacenes;


namespace TPCAI.Modelos
{
    class PersonaModelo
    {
        public static PersonaEnt AgregarPersona(PersonaEnt persona)
        {
            PersonasAlmacen.personas.Add(persona);

            return persona;
        }
    }
}
