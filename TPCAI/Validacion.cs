﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TPCAI.Entidades.SubClasses;

namespace TPCAI
{
    static internal class Validacion
    {

        public static bool validarPasajeros(
            List<Pasajero> pasajeros
            )
        {
            foreach(Pasajero pasajero in pasajeros)
            {

            }

           return true;
        }

            public static bool validarNuevoCliente(
            Cliente cliente
            )
        {
            if (cliente.DNI == "")
            {
                MessageBox.Show("No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo.");

                return false;
            }

            if (cliente.Nombre == "")
            {
                MessageBox.Show("No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo."); // TO DO: esto dice en el CU. Opinión: me suena muy mal mensaje

                return false;
            }

            if (cliente.Apellido == "")
            {
                MessageBox.Show("No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo."); // TO DO: esto dice en el CU. Opinión: me suena muy mal mensaje

                return false;
            }

            if (long.TryParse(cliente.DNI, out long resultDNI))
            {
                if (resultDNI < 0)
                {
                    MessageBox.Show("Documento ingresado inválido por favor volver a ingresar");  //OK: Validado con CU

                    return false;
                }

                if (resultDNI < 1000000)
                {
                    MessageBox.Show("Documento ingresado inválido por favor volver a ingresar");  //OK: Validado con CU

                    return false;
                }

                if (resultDNI > 100000000)
                {
                    MessageBox.Show("Documento ingresado inválido por favor volver a ingresar"); //OK: Validado con CU

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Documento ingresado inválido por favor volver a ingresar");

                return false;
            }

            if (cliente.FechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("Fecha de nacimiento ingresada es posterior al día de la fecha. Por favor, ingrese nuevamente la fecha de nacimiento"); //OK: Validado con CU

                return false;
            }

            if (cliente.FechaNacimiento == null)
            {
                MessageBox.Show("Fecha de nacimiento ingresada es inválida");

                return false;
            }

            string patternSololetras = "^[a-zA-ZáéíóúüñÁÉÍÓÚÜÑ ]+$";

            if (!Regex.IsMatch(cliente.Nombre, patternSololetras))
            {
                MessageBox.Show("No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo."); // TO DO: esto dice en el CU. Opinión: me suena muy mal mensaje

                return false;
            }

            if (!Regex.IsMatch(cliente.Apellido, patternSololetras))
            {
                MessageBox.Show("No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo."); // TO DO: esto dice en el CU. Opinión: me suena muy mal mensaje

                return false;
            }

            return true;
        }
 

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

                        MessageBox.Show("Debe ingresar al menos 1 adulto en cantidad de pasajeros");
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

            // Verificar si la fecha es mayor o igual a la fecha actual
            if (!DateTime.TryParse(fechaIngreso, out DateTime fechaIngresada) || fechaIngresada < DateTime.Now.Date)
            {
                MessageBox.Show("Ha ingresado una fecha anterior a la fecha de hoy, por favor ingrese una fecha mayor o igual a la fecha de hoy");
                return false;
            }

            

            //Fecha Ingreso No puede ser mayor a fecha Egreso
            if (DateTime.Parse(fechaIngreso) > DateTime.Parse(fechaEgreso)) {
                MessageBox.Show("Su fecha de Egreso debe ser mayor o igual a su fecha de Ingreso. Por favor, ingrese nuevamente una fecha de Egreso");
                flagHuboError = true;
            }

            if (flagHuboError == true)
            {
                return false;
            }
            return true;
        }


        public static bool validarDatosVuelo(string Origen, string Destino, string FechaIda, string FechaVuelta, string CantAdultos, string CantMenores, string CantInfantes, string Clase)
        {
            bool flagHuboError = false;

            if (Destino == "")
            {
                MessageBox.Show("El campo Destino es obligatorio");
                flagHuboError = true;
            }

            if (Origen == "")
            {
                MessageBox.Show("El campo Origen es obligatorio");
                flagHuboError = true;
            }

            if (CantAdultos == "")
            {
                MessageBox.Show("La Cantidad de Adultos es obligatoria");
                flagHuboError = true;
            }
            else
            {
                if (!int.TryParse(CantAdultos, out int resultAdultos))
                {
                    MessageBox.Show("La Cantidad de Adultos solo puede contener números");
                    flagHuboError = true;
                }
                else
                {
                    if (resultAdultos < 1)
                    {

                        MessageBox.Show("Debe ingresar al menos 1 adulto en cantidad de pasajeros");
                    }
                }
            }


            if (CantMenores != "" && !int.TryParse(CantMenores, out int resultMenores))
            {
                MessageBox.Show("La Cantidad de Menores solo puede contener números");
                flagHuboError = true;
            }

            if (int.TryParse(CantMenores, out int resultMenores2))
            {
                if (resultMenores2 < 0)
                {
                    MessageBox.Show("La cantidad de menores no puede ser un número negativo");
                }
            }

            if (CantInfantes != "" && !int.TryParse(CantInfantes, out int resultInfantes))
            {
                MessageBox.Show("La Cantidad de Infantes solo puede contener números");
                flagHuboError = true;
            }

            if (int.TryParse(CantInfantes, out int resultInfantes2))
            {
                if (resultInfantes2 < 0)
                {
                    MessageBox.Show("La cantidad de infantes no puede ser un número negativo");
                }
            }

            // Verificar si la fecha es mayor o igual a la fecha actual
            if (!DateTime.TryParse(FechaIda, out DateTime fechaIngresada) || fechaIngresada < DateTime.Now.Date)
            {
                MessageBox.Show("Ha ingresado una fecha anterior a la fecha de hoy, por favor ingrese una fecha mayor o igual a la fecha de hoy");
                return false;
            }

            // Verificar si la fecha es mayor o igual a la fecha actual
            if (!DateTime.TryParse(FechaVuelta, out DateTime fechaIngresadaVuelta) || fechaIngresadaVuelta < DateTime.Now.Date)
            {
                MessageBox.Show("Ha ingresado una fecha anterior a la fecha de hoy, por favor ingrese una fecha mayor o igual a la fecha de hoy");
                return false;
            }

            int cantidadAdultos, cantidadMenores, cantidadInfantes;

            if (!int.TryParse(CantAdultos, out cantidadAdultos) ||
                !int.TryParse(CantMenores, out cantidadMenores) ||
                !int.TryParse(CantInfantes, out cantidadInfantes))
            {
                return false;
            }
            if (cantidadAdultos < cantidadMenores + cantidadInfantes)
            {
                MessageBox.Show("Ingrese una cantidad de adultos mayor o igual a la cantidad de menores e infantes");
                return false;
            }

            if (Clase == "" )
            {
                MessageBox.Show("El campo Clase es obligatorio, por favor elija una Clase para buscar vuelos");
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
