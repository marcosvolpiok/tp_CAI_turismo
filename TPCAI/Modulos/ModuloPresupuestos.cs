﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI.Almacenes;
using TPCAI.Entidades.SubClasses;
using TPCAI.Entidades;
using TPCAI.Modelos;
using System.Security.Policy;
using System.Runtime.CompilerServices;

namespace TPCAI.Modulos
{
    public static class ModuloPresupuestos
    {
        public static PresupuestosEnt PresupuestoActivo { get; set; }
        public static List<PresupuestosEnt> Presupuestos { get; set; } //Referencia viva de Presupuestos
        public static List<Vuelo> VuelosPresupuesto { get; private set; } = new List<Vuelo>();

        internal static void EliminarVueloDeActivo(string vueloId)
        {
            VuelosPresupuesto.RemoveAll(v => v.IdTarifaVuelos == vueloId);
        }

        public static void obtenerVueloPorTarifaId(string vueloId)
        {

        }

        internal static void EliminarAlojamientoDeActivo(int IDHabitacion)
        {
            int habitacionAEliminar = -1;

            foreach (int habitacion in PresupuestoActivo.IDHabitacion)
            {
                if(habitacion == IDHabitacion)
                {
                    habitacionAEliminar = habitacion;
                    break;
                }
            }

            if(habitacionAEliminar != -1)
            {
                PresupuestoActivo.IDHabitacion.Remove(habitacionAEliminar);
            }
        }

        //CLIENTES
        public static bool AgregarClientes(Cliente cliente)
        {
            if (Validacion.validarNuevoCliente(cliente) == true)
            {
                ClienteEnt clienteNuevo = new ClienteEnt();
                clienteNuevo.ID = GenerarID();
                clienteNuevo.Nombre = cliente.Nombre;
                clienteNuevo.Apellido = cliente.Apellido;
                clienteNuevo.DNI = long.Parse(cliente.DNI);
                cliente.FechaNacimiento = cliente.FechaNacimiento;

                PresupuestoActivo.Clientes = clienteNuevo;

                return true;
            }

            return false;
        }

        private static int GenerarID()
        {
            // Obtener la lista de clientes desde AlmacenClientes
            List<ClienteEnt> clientes = AlmacenClientes.Clientes;

            var nuevoId = 1; // Valor predeterminado si no hay clientes registrados

            // Verifico si hay clientes registrados
            if (clientes != null && clientes.Count > 0)
            {
                // Obtengo el último cliente registrado
                ClienteEnt ultimoCliente = clientes.Last();

                // Incrementar el ID del último cliente en 1
                nuevoId = ultimoCliente.ID + 1;
            }

            return nuevoId;
        }

        
        
        //PRESUPUESTOS
        public static int CrearPresupuesto()
        {
            int nuevoCodigoPresupuesto = ObtenerNuevoCodigoPresupuesto();
            return nuevoCodigoPresupuesto;
        }

        private static int ObtenerNuevoCodigoPresupuesto()
        {
            List<PresupuestosEnt> presupuestosTmp = new List<PresupuestosEnt>();
            presupuestosTmp.AddRange(Presupuestos);
            if (Presupuestos != null)
            {
                presupuestosTmp.AddRange(Presupuestos);
            }

            // Verifico si hay presupuestos existentes
            if (presupuestosTmp.Any())
            {
                // Obtener el código del último presupuesto
                int ultimoCodigo = presupuestosTmp.Max(p => p.CodigoPresupuesto);                
                return ultimoCodigo + 1;
            }
            else
            {
                // Si no hay presupuestos, comenzar desde el código 1
                return 1;
            }
        }

        public static int ObtengoPresupuestoActivo()
        {
            return ModuloPresupuestos.PresupuestoActivo.CodigoPresupuesto;
        }

        public static PresupuestosEnt agregarPresupuestoNuevo()
        {
            int idPresupuestoNuevo = CrearPresupuesto();
            PresupuestosEnt presupuestoNuevo = new PresupuestosEnt();
            presupuestoNuevo.IDHabitacion = new List<int>();
            presupuestoNuevo.IdTarifaVuelo = new List<string>();
            presupuestoNuevo.CodigoPresupuesto = idPresupuestoNuevo;

            if (ModuloPresupuestos.Presupuestos == null)
            {
                ModuloPresupuestos.Presupuestos = new List<PresupuestosEnt>();
            }
            ModuloPresupuestos.Presupuestos.Add(presupuestoNuevo);

            return presupuestoNuevo;
        }

        public static List<PresupuestosEnt> obtenerPresupuestos()
        {
            return Presupuestos;
        }

        public static PresupuestosEnt BusquedaPresupuestoId(int codigoPresupuesto)
        {
            if (Presupuestos != null)
            {
                return Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == codigoPresupuesto);
            }
            else
            {
                return null;
            }
        }

        public static string ObtenerInfoP(PresupuestosEnt presupuestoActivo)
        {
            var presupuesto = Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == presupuestoActivo.CodigoPresupuesto);

            if (presupuesto != null)
            {
                string info = $"Vuelos: {string.Join(", ", presupuesto.IdTarifaVuelo)}, Alojamientos: {string.Join(", ", presupuesto.IDHabitacion)}";
                return info;
            }
            else
            {
                return "Presupuesto no encontrado";
            }
        }
        public static decimal ObtenerInfoPrecioTotal(PresupuestosEnt presupuestoActivo)
        {
            var presupuesto = Presupuestos.FirstOrDefault(p => p.CodigoPresupuesto == presupuestoActivo.CodigoPresupuesto);

            if (presupuesto != null)
            {
                decimal infoPrecioTotal = presupuesto.PrecioTotal;
                return infoPrecioTotal;
            }
            else
            {
                return 0;
            }
        }


        public static void AgregarVueloAPresupuesto(string vueloId)
        {
            PresupuestoActivo.IdTarifaVuelo.Add(vueloId);
        }


    }
}
