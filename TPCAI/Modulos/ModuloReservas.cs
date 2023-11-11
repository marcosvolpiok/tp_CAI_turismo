using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades;
using TPCAI.Entidades.SubClasses;

namespace TPCAI.Modulos
{
    public static class ModuloReservas
    {
        public static ConcurrentDictionary<int, List<Pasajero>> diccionarioPresupuestoPasajero { get; set; } = new ConcurrentDictionary<int, List<Pasajero>>();


        internal static void guardarPasajeroAPresupuestoActivo(List<Pasajero> pasajeros)
        {
            diccionarioPresupuestoPasajero = new ConcurrentDictionary<int, List<Pasajero>>();

            foreach (Pasajero pasajero in pasajeros)
            {
                object value = diccionarioPresupuestoPasajero.AddOrUpdate(
                ModuloPresupuestos.ObtengoPresupuestoActivo(),
                new List<Pasajero> { pasajero },
                (key, existingList) =>
                    {
                        existingList.Add(pasajero);
                        return existingList;
                    }
                );
            }
        }
    }
}
