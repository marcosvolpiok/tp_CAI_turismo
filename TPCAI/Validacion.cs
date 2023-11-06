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
                } else {
                    if (resultAdultos < 1)
                    {

                        MessageBox.Show("La cantidad de Adultos debe ser como mínimo 1");
                    }
                }
            }


            if (cantidadMenores != "" && !int.TryParse(cantidadMenores, out int resultMenores))
            {
                MessageBox.Show("La Cantidad de Menores solo puede contener números");
                flagHuboError = true;
            }

            if (int.TryParse(cantidadMenores, out int resultMenores2))
            {
                if (resultMenores2 < 0)
                {
                    MessageBox.Show("La cantidad de menores no puede ser un número negativo");
                }
            }

            if (cantidadInfantes != "" && !int.TryParse(cantidadInfantes, out int resultInfantes))
            {
                MessageBox.Show("La Cantidad de Infantes solo puede contener números");
                flagHuboError = true;
            }

            if (int.TryParse(cantidadInfantes, out int resultInfantes2))
            {
                if (resultInfantes2 < 0)
                {
                    MessageBox.Show("La cantidad de infantes no puede ser un número negativo");
                }
            }

            //Fecha Ingreso No puede ser mayor a fecha Egreso
            if (DateTime.Parse(fechaIngreso) > DateTime.Parse(fechaEgreso)) {
                MessageBox.Show("La Fecha de Ingreso no puede ser posterior a la Fecha de Egreso");
                flagHuboError = true;
            }

            if (flagHuboError == true)
            {
                return false;
            }
            return true;
        }
    }
}
