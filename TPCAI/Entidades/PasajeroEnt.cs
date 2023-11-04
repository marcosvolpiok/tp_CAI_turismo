using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;

namespace TPCAI.Entidades
{
    class PasajeroEnt
    {
        public long ID { get; set; }
        public string Tipo { get; set; } // (aduto, menor, infante)
        public PersonaEnt Persona { get; set; }

    }
}
