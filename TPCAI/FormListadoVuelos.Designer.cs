﻿namespace TPCAI
{
    partial class FormListadoVuelos
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
            this.dataGridViewListadoVuelos = new System.Windows.Forms.DataGridView();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVerPresupuesto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHoraArribo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListadoVuelos
            // 
            this.dataGridViewListadoVuelos.AllowUserToAddRows = false;
            this.dataGridViewListadoVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListadoVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrigen,
            this.ColumnDestino,
            this.ColumnFechaHoraSalida,
            this.ColumnFechaHoraArribo,
            this.ColumnAerolinea,
            this.ColumnPrecio,
            this.ColumnClase,
            this.ColumnTipoPasajero});
            this.dataGridViewListadoVuelos.Location = new System.Drawing.Point(27, 44);
            this.dataGridViewListadoVuelos.Name = "dataGridViewListadoVuelos";
            this.dataGridViewListadoVuelos.Size = new System.Drawing.Size(957, 477);
            this.dataGridViewListadoVuelos.TabIndex = 3;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(833, 536);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(153, 31);
            this.btnVolverMenu.TabIndex = 5;
            this.btnVolverMenu.Text = "Volver a Menú de Productos";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Añadir a Presupuesto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVerPresupuesto
            // 
            this.btnVerPresupuesto.Location = new System.Drawing.Point(687, 536);
            this.btnVerPresupuesto.Name = "btnVerPresupuesto";
            this.btnVerPresupuesto.Size = new System.Drawing.Size(122, 31);
            this.btnVerPresupuesto.TabIndex = 7;
            this.btnVerPresupuesto.Text = "Ver Presupuesto";
            this.btnVerPresupuesto.UseVisualStyleBackColor = true;
            this.btnVerPresupuesto.Click += new System.EventHandler(this.btnVerPresupuesto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione el producto que desee agregar al presupuesto";
            // 
            // ColumnOrigen
            // 
            this.ColumnOrigen.HeaderText = "Origen";
            this.ColumnOrigen.Name = "ColumnOrigen";
            // 
            // ColumnDestino
            // 
            this.ColumnDestino.HeaderText = "Destino";
            this.ColumnDestino.Name = "ColumnDestino";
            // 
            // ColumnFechaHoraSalida
            // 
            this.ColumnFechaHoraSalida.HeaderText = "Fecha Hora Salida";
            this.ColumnFechaHoraSalida.Name = "ColumnFechaHoraSalida";
            // 
            // ColumnFechaHoraArribo
            // 
            this.ColumnFechaHoraArribo.HeaderText = "Fecha Hora Arribo";
            this.ColumnFechaHoraArribo.Name = "ColumnFechaHoraArribo";
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
            this.ColumnClase.HeaderText = "Clase de Vuelo";
            this.ColumnClase.Name = "ColumnClase";
            // 
            // ColumnTipoPasajero
            // 
            this.ColumnTipoPasajero.HeaderText = "Tipo Pasajero";
            this.ColumnTipoPasajero.Name = "ColumnTipoPasajero";
            // 
            // FormListadoVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.dataGridViewListadoVuelos);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.button1);
            this.Name = "FormListadoVuelos";
            this.Text = "Listado Vuelos";
            this.Load += new System.EventHandler(this.FormListadoVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListadoVuelos;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVerPresupuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHoraArribo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoPasajero;
    }
}