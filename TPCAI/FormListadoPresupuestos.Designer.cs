﻿namespace TPCAI
{
    partial class FormListadoPresupuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.tabControlAlojamientosVuelos = new System.Windows.Forms.TabControl();
            this.tabAlojamientos = new System.Windows.Forms.TabPage();
            this.dataGridViewPresupuestosAlojamientos = new System.Windows.Forms.DataGridView();
            this.ColumnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVuelos = new System.Windows.Forms.TabPage();
            this.dataGridViewPresupuestosVuelos = new System.Windows.Forms.DataGridView();
            this.ColumnOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHoraArribo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTarifaVuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAñadirDatosCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlAlojamientosVuelos.SuspendLayout();
            this.tabAlojamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresupuestosAlojamientos)).BeginInit();
            this.tabVuelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresupuestosVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(622, 551);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(170, 31);
            this.btnEliminarProducto.TabIndex = 8;
            this.btnEliminarProducto.Text = "Eliminar Producto Seleccionado";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // tabControlAlojamientosVuelos
            // 
            this.tabControlAlojamientosVuelos.Controls.Add(this.tabAlojamientos);
            this.tabControlAlojamientosVuelos.Controls.Add(this.tabVuelos);
            this.tabControlAlojamientosVuelos.Location = new System.Drawing.Point(24, 33);
            this.tabControlAlojamientosVuelos.Name = "tabControlAlojamientosVuelos";
            this.tabControlAlojamientosVuelos.SelectedIndex = 0;
            this.tabControlAlojamientosVuelos.Size = new System.Drawing.Size(965, 484);
            this.tabControlAlojamientosVuelos.TabIndex = 9;
            // 
            // tabAlojamientos
            // 
            this.tabAlojamientos.Controls.Add(this.dataGridViewPresupuestosAlojamientos);
            this.tabAlojamientos.Location = new System.Drawing.Point(4, 22);
            this.tabAlojamientos.Name = "tabAlojamientos";
            this.tabAlojamientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlojamientos.Size = new System.Drawing.Size(957, 458);
            this.tabAlojamientos.TabIndex = 0;
            this.tabAlojamientos.Text = "Alojamientos";
            this.tabAlojamientos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPresupuestosAlojamientos
            // 
            this.dataGridViewPresupuestosAlojamientos.AllowUserToAddRows = false;
            this.dataGridViewPresupuestosAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPresupuestosAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresupuestosAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDestino,
            this.ColumnNombreAlojamiento,
            this.ColumnTarifa,
            this.ColumnFechaIngreso,
            this.ColumnFechaEgreso,
            this.ColumnCalificacion,
            this.ColumnTipoHabitacion});
            this.dataGridViewPresupuestosAlojamientos.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewPresupuestosAlojamientos.Name = "dataGridViewPresupuestosAlojamientos";
            this.dataGridViewPresupuestosAlojamientos.Size = new System.Drawing.Size(951, 459);
            this.dataGridViewPresupuestosAlojamientos.TabIndex = 4;
            // 
            // ColumnDestino
            // 
            this.ColumnDestino.HeaderText = "Destino";
            this.ColumnDestino.Name = "ColumnDestino";
            // 
            // ColumnNombreAlojamiento
            // 
            this.ColumnNombreAlojamiento.HeaderText = "Nombre Alojamiento";
            this.ColumnNombreAlojamiento.Name = "ColumnNombreAlojamiento";
            // 
            // ColumnTarifa
            // 
            this.ColumnTarifa.HeaderText = "Tarifa";
            this.ColumnTarifa.Name = "ColumnTarifa";
            // 
            // ColumnFechaIngreso
            // 
            this.ColumnFechaIngreso.HeaderText = "Fecha Ingreso";
            this.ColumnFechaIngreso.Name = "ColumnFechaIngreso";
            // 
            // ColumnFechaEgreso
            // 
            this.ColumnFechaEgreso.HeaderText = "Fecha Egreso";
            this.ColumnFechaEgreso.Name = "ColumnFechaEgreso";
            // 
            // ColumnCalificacion
            // 
            this.ColumnCalificacion.HeaderText = "Calificacion";
            this.ColumnCalificacion.Name = "ColumnCalificacion";
            // 
            // ColumnTipoHabitacion
            // 
            this.ColumnTipoHabitacion.HeaderText = "Tipo Habitacion";
            this.ColumnTipoHabitacion.Name = "ColumnTipoHabitacion";
            // 
            // tabVuelos
            // 
            this.tabVuelos.Controls.Add(this.dataGridViewPresupuestosVuelos);
            this.tabVuelos.Location = new System.Drawing.Point(4, 22);
            this.tabVuelos.Name = "tabVuelos";
            this.tabVuelos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVuelos.Size = new System.Drawing.Size(957, 458);
            this.tabVuelos.TabIndex = 1;
            this.tabVuelos.Text = "Vuelos";
            this.tabVuelos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPresupuestosVuelos
            // 
            this.dataGridViewPresupuestosVuelos.AllowUserToAddRows = false;
            this.dataGridViewPresupuestosVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPresupuestosVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresupuestosVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrigen,
            this.dataGridViewTextBoxColumn1,
            this.ColumnFechaHoraArribo,
            this.ColumnFechaHoraSalida,
            this.ColumnAerolinea,
            this.ColumnPrecio,
            this.ColumnClase,
            this.ColumnTipoPasajero,
            this.IdTarifaVuel});
            this.dataGridViewPresupuestosVuelos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPresupuestosVuelos.Name = "dataGridViewPresupuestosVuelos";
            this.dataGridViewPresupuestosVuelos.Size = new System.Drawing.Size(957, 449);
            this.dataGridViewPresupuestosVuelos.TabIndex = 4;
            // 
            // ColumnOrigen
            // 
            this.ColumnOrigen.HeaderText = "Origen";
            this.ColumnOrigen.Name = "ColumnOrigen";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ColumnFechaHoraArribo
            // 
            this.ColumnFechaHoraArribo.HeaderText = "Fecha Hora Arribo";
            this.ColumnFechaHoraArribo.Name = "ColumnFechaHoraArribo";
            // 
            // ColumnFechaHoraSalida
            // 
            this.ColumnFechaHoraSalida.HeaderText = "Fecha Hora Salida";
            this.ColumnFechaHoraSalida.Name = "ColumnFechaHoraSalida";
            // 
            // ColumnAerolinea
            // 
            this.ColumnAerolinea.HeaderText = "Aerolinea";
            this.ColumnAerolinea.Name = "ColumnAerolinea";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnClase
            // 
            this.ColumnClase.HeaderText = "Clase";
            this.ColumnClase.Name = "ColumnClase";
            // 
            // ColumnTipoPasajero
            // 
            this.ColumnTipoPasajero.HeaderText = "Tipo Pasajero";
            this.ColumnTipoPasajero.Name = "ColumnTipoPasajero";
            // 
            // IdTarifaVuel
            // 
            this.IdTarifaVuel.HeaderText = "Id Tarifa";
            this.IdTarifaVuel.Name = "IdTarifaVuel";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(821, 551);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(162, 31);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAñadirDatosCliente
            // 
            this.btnAñadirDatosCliente.Location = new System.Drawing.Point(474, 551);
            this.btnAñadirDatosCliente.Name = "btnAñadirDatosCliente";
            this.btnAñadirDatosCliente.Size = new System.Drawing.Size(122, 31);
            this.btnAñadirDatosCliente.TabIndex = 11;
            this.btnAñadirDatosCliente.Text = "Añadir Datos Cliente";
            this.btnAñadirDatosCliente.UseVisualStyleBackColor = true;
            this.btnAñadirDatosCliente.Click += new System.EventHandler(this.btnAñadirDatosCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total: $25.000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "Presupuesto Activo: 4545";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Cliente: José Cabrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "DNI: 36.258.110";
            // 
            // FormListadoPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAñadirDatosCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tabControlAlojamientosVuelos);
            this.Controls.Add(this.btnEliminarProducto);
            this.Name = "FormListadoPresupuestos";
            this.Text = "Listado Presupuestos";
            this.Load += new System.EventHandler(this.FormListadoPresupuestos_Load);
            this.tabControlAlojamientosVuelos.ResumeLayout(false);
            this.tabAlojamientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresupuestosAlojamientos)).EndInit();
            this.tabVuelos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresupuestosVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.TabPage tabAlojamientos;
        private System.Windows.Forms.TabPage tabVuelos;
        private System.Windows.Forms.DataGridView dataGridViewPresupuestosAlojamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoHabitacion;
        private System.Windows.Forms.DataGridView dataGridViewPresupuestosVuelos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAñadirDatosCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHoraArribo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarifaVuel;
        public System.Windows.Forms.TabControl tabControlAlojamientosVuelos;
    }
}