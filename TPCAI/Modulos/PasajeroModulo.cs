using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;
using TPCAI.Almacenes;

namespace TPCAI.Modulos
{
    class PasajeroModulo
    {
        public static List<PasajeroEnt> BuscarTodas() {
            return PasajerosAlmacen.pasajeros;
        }
    }
}
