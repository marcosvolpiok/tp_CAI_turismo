using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;

namespace TPCAI.Almacenes
{
    class PersonasAlmacen
    {
        public static List<PersonaEnt> personas;

        static PersonasAlmacen()
        {
            personas = new List<PersonaEnt>()
            {
                new PersonaEnt { ID = 123, Nombre = "Juan", Apellido="Bautista", DNI=10111222, FechaNacimiento = new DateTime(2001, 11, 4) },
                new PersonaEnt { ID = 124, Nombre = "José", Apellido="Mendez", DNI=10111223, FechaNacimiento = new DateTime(2002, 12, 4) },
                new PersonaEnt { ID = 125, Nombre = "María", Apellido="Ave", DNI=10111224, FechaNacimiento = new DateTime(2003, 01, 4) },  
            };
        }
    }
}
