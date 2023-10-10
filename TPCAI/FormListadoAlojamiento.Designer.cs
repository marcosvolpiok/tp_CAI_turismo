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
            this.ColumnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDestino,
            this.ColumnNombreAlojamiento,
            this.ColumnTarifa,
            this.ColumnFechaIngreso,
            this.ColumnFechaEgreso,
            this.ColumnCalificacion,
            this.ColumnTipoHabitacion});
            this.dataGridView1.Location = new System.Drawing.Point(108, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 509);
            this.dataGridView1.TabIndex = 3;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(787, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Volver a Menú";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Añadir a Presupuesto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormListadoAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 639);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormListadoAlojamiento";
            this.Text = "FormListadoAlojamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoHabitacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}