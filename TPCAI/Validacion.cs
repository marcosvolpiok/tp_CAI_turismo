using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    static internal class Validacion
    {
        public static bool validarFiltrosBusquedaAlojamiento(
            string destino,
            string fechaIngreso,
            string fechaEgreso,
            string cantidadAdultos,
            string cantidadMenores,
            string cantidadInfantes,
            string calificacion
            )
        {


            //Campos OBLIGATORIOS:
            //destino
            //fecha ingreso
            //fecha egreso
            //cantidad adultos

            //Campos solo números:
            //cantidad adultos
            //cantidad menores
            //cantidad infantes

            //Opcionales:
            //menores, infantes, calificacion


            bool flagHuboError = false;

            if(destino == "")
            {
                MessageBox.Show("El campo Destino es obligatorio");
                flagHuboError = true;
            }

            if (cantidadAdultos == "")
            {
                MessageBox.Show("La Cantidad de Adultos es obligatoria");
                flagHuboError = true;
            }
            else
            {
                if (!int.TryParse(cantidadAdultos, out int resultAdultos))
                {
                    MessageBox.Show("La Cantidad de Adultos solo puede contener números");
                    flagHuboError = true;
                }
            }


            if (cantidadMenores!="" && !int.TryParse(cantidadMenores, out int resultMenores))
            {
                MessageBox.Show("La Cantidad de Menores solo puede contener números");
                flagHuboError = true;
            }

            if (cantidadInfantes != "" && !int.TryParse(cantidadInfantes, out int resultInfantes))
            {
                MessageBox.Show("La Cantidad de Infantes solo puede contener números");
                flagHuboError = true;
            }

            //Fecha Ingreso No puede ser mayor a fecha Egreso

            if (flagHuboError == true)
            {
                return false;
            }
            return true;
        }
    }
}
