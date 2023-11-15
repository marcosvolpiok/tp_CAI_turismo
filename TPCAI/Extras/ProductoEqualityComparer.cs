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
            return x.idVuelo == y.idVuelo && x.IDDisponibilidadAlojamiento == y.IDDisponibilidadAlojamiento && x.nombre == y.nombre;
        }

        public int GetHashCode(Producto obj)
        {
            int idVueloHashCode = obj.idVuelo?.GetHashCode() ?? 0;
            int IDDisponibilidadAlojamientoHashCode = obj.IDDisponibilidadAlojamiento.GetHashCode();
            int nombreHashCode = obj.nombre?.GetHashCode() ?? 0;

            return idVueloHashCode ^ IDDisponibilidadAlojamientoHashCode ^ nombreHashCode;

        }
    }
}
