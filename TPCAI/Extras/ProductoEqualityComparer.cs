using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Entidades.SubClasses;

namespace TPCAI.Extras
{
    class ProductoEqualityComparer : IEqualityComparer<Producto>
    {
        public object HashCode { get; private set; }

        public bool Equals(Producto x, Producto y)
        {
            // Comparar las propiedades relevantes para determinar la igualdad
            return x.idVuelo == y.idVuelo && x.IDDisponibilidadAlojamiento == y.IDDisponibilidadAlojamiento && x.nombre == y.nombre;
        }


        /*
        public int GetHashCode(Producto obj)
        {
            // Calcular un código hash basado en las propiedades relevantes
            //return HashCode.Combine(obj.idVuelo, obj.IDAlojamiento, obj.nombre);
            return obj.idVuelo.GetHashCode() ^ obj.IDAlojamiento.GetHashCode() ^ obj.nombre.GetHashCode();
        }
        */
        public int GetHashCode(Producto obj)
        {
            /*
            // Check for null and use a default hash code if null
            int idVueloHashCode = obj.idVuelo?.GetHashCode() ?? 0;
            int IDAlojamientoHashCode = obj.IDDisponibilidadAlojamiento?.GetHashCode() ?? 0;
            int nombreHashCode = obj.nombre?.GetHashCode() ?? 0;

            // Combine hash codes using XOR
            return idVueloHashCode ^ IDAlojamientoHashCode ^ nombreHashCode;
            */

            // Check for null and use a default hash code if null
            int idVueloHashCode = obj.idVuelo?.GetHashCode() ?? 0;
            int IDDisponibilidadAlojamientoHashCode = obj.IDDisponibilidadAlojamiento.GetHashCode();
            int nombreHashCode = obj.nombre?.GetHashCode() ?? 0;

            // Combine hash codes using XOR
            return idVueloHashCode ^ IDDisponibilidadAlojamientoHashCode ^ nombreHashCode;

        }
    }
}
