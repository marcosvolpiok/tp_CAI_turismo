﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCAI;
using TPCAI.Entidades.SubClasses;

namespace TPCAI
{
    public class ListadoAlojamientosModelo
    {
        public string destino { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaEgreso { get; set; }
        public string cantidadAdultos { get; set; }
        public string cantidadMenores { get; set; }
        public string cantidadInfantes { get; set; }
        public string calificacion { get; set; }

        public List<Alojamiento> AlojamientosFiltrados { get; private set; }

        public void BuscarAlojaimentos()
        {
            //return ProductosModulo.ObtenerAlojamientos();
            AlojamientosFiltrados = ProductosModulo.ObtenerAlojamientos();
        }

        public void BuscarAlojamientosFiltrados()
        {
            AlojamientosFiltrados = ProductosModulo.ObtenerAlojamientosFiltrados(this);
        }


    }
}