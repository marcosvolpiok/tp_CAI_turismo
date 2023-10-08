namespace TPCAI
{
    partial class FormListadoAlojamiento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ColumnOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHoraArribo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrigen,
            this.ColumnDestino,
            this.ColumnFechaHoraArribo,
            this.ColumnFechaHoraSalida,
            this.ColumnAerolinea,
            this.ColumnPrecio,
            this.ColumnClase,
            this.ColumnTipoPasajero});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 523);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Añadir a Presupuesto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(782, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Volver a Menú";
            this.button2.UseVisualStyleBackColor = true;
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
            // FormListadoAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 608);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormListadoAlojamiento";
            this.Text = "Listado Vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHoraArribo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoPasajero;
    }
}