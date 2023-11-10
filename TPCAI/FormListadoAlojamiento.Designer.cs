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
            this.dataGridViewListadoAlojamiento = new System.Windows.Forms.DataGridView();
            this.ColumnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerPresupuesto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dateTimeEgreso = new System.Windows.Forms.DateTimePicker();
            this.dateTimeIngreso = new System.Windows.Forms.DateTimePicker();
            this.comboCalificacion = new System.Windows.Forms.ComboBox();
            this.textCantidadInfantes = new System.Windows.Forms.TextBox();
            this.textCantidadMenores = new System.Windows.Forms.TextBox();
            this.textCantidadAdultos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPresupuestoActivo = new System.Windows.Forms.Label();
            this.btnAñadirAPresupuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoAlojamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListadoAlojamiento
            // 
            this.dataGridViewListadoAlojamiento.AllowUserToAddRows = false;
            this.dataGridViewListadoAlojamiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListadoAlojamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoAlojamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDestino,
            this.ColumnNombreAlojamiento,
            this.ColumnTarifa,
            this.ColumnCalificacion,
            this.ColumnTipoHabitacion,
            this.IDHabitacion});
            this.dataGridViewListadoAlojamiento.Location = new System.Drawing.Point(460, 57);
            this.dataGridViewListadoAlojamiento.Name = "dataGridViewListadoAlojamiento";
            this.dataGridViewListadoAlojamiento.Size = new System.Drawing.Size(957, 495);
            this.dataGridViewListadoAlojamiento.TabIndex = 3;
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
            // IDHabitacion
            // 
            this.IDHabitacion.HeaderText = "ID Habitacion";
            this.IDHabitacion.Name = "IDHabitacion";
            // 
            // btnVerPresupuesto
            // 
            this.btnVerPresupuesto.Location = new System.Drawing.Point(1137, 576);
            this.btnVerPresupuesto.Name = "btnVerPresupuesto";
            this.btnVerPresupuesto.Size = new System.Drawing.Size(122, 31);
            this.btnVerPresupuesto.TabIndex = 6;
            this.btnVerPresupuesto.Text = "Ver Presupuesto";
            this.btnVerPresupuesto.UseVisualStyleBackColor = true;
            this.btnVerPresupuesto.Click += new System.EventHandler(this.btnVerPresupuesto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione el producto que desee agregar al presupuesto";
            // 
            // comboDestino
            // 
            this.comboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(199, 162);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(196, 21);
            this.comboDestino.TabIndex = 50;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(45, 488);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(122, 31);
            this.BtnBuscar.TabIndex = 48;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dateTimeEgreso
            // 
            this.dateTimeEgreso.Location = new System.Drawing.Point(199, 255);
            this.dateTimeEgreso.Name = "dateTimeEgreso";
            this.dateTimeEgreso.Size = new System.Drawing.Size(196, 20);
            this.dateTimeEgreso.TabIndex = 47;
            // 
            // dateTimeIngreso
            // 
            this.dateTimeIngreso.Location = new System.Drawing.Point(201, 207);
            this.dateTimeIngreso.Name = "dateTimeIngreso";
            this.dateTimeIngreso.Size = new System.Drawing.Size(196, 20);
            this.dateTimeIngreso.TabIndex = 46;
            // 
            // comboCalificacion
            // 
            this.comboCalificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCalificacion.FormattingEnabled = true;
            this.comboCalificacion.Location = new System.Drawing.Point(201, 430);
            this.comboCalificacion.Name = "comboCalificacion";
            this.comboCalificacion.Size = new System.Drawing.Size(196, 21);
            this.comboCalificacion.TabIndex = 45;
            // 
            // textCantidadInfantes
            // 
            this.textCantidadInfantes.Location = new System.Drawing.Point(199, 387);
            this.textCantidadInfantes.Name = "textCantidadInfantes";
            this.textCantidadInfantes.Size = new System.Drawing.Size(196, 20);
            this.textCantidadInfantes.TabIndex = 44;
            // 
            // textCantidadMenores
            // 
            this.textCantidadMenores.Location = new System.Drawing.Point(199, 348);
            this.textCantidadMenores.Name = "textCantidadMenores";
            this.textCantidadMenores.Size = new System.Drawing.Size(196, 20);
            this.textCantidadMenores.TabIndex = 43;
            // 
            // textCantidadAdultos
            // 
            this.textCantidadAdultos.Location = new System.Drawing.Point(199, 305);
            this.textCantidadAdultos.Name = "textCantidadAdultos";
            this.textCantidadAdultos.Size = new System.Drawing.Size(198, 20);
            this.textCantidadAdultos.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Cantidad de Infantes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Calificación (Estrellas)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cantidad de Menores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "* Cantidad de Adultos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "* Fecha de Egreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "* Fecha de Ingreso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "* Destino";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1295, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 51;
            this.button2.Text = "Volver al Menú";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPresupuestoActivo
            // 
            this.lblPresupuestoActivo.AutoSize = true;
            this.lblPresupuestoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuestoActivo.Location = new System.Drawing.Point(42, 105);
            this.lblPresupuestoActivo.Name = "lblPresupuestoActivo";
            this.lblPresupuestoActivo.Size = new System.Drawing.Size(214, 20);
            this.lblPresupuestoActivo.TabIndex = 58;
            this.lblPresupuestoActivo.Text = "Presupuesto Activo: 4545";
            // 
            // btnAñadirAPresupuesto
            // 
            this.btnAñadirAPresupuesto.Location = new System.Drawing.Point(975, 576);
            this.btnAñadirAPresupuesto.Name = "btnAñadirAPresupuesto";
            this.btnAñadirAPresupuesto.Size = new System.Drawing.Size(122, 31);
            this.btnAñadirAPresupuesto.TabIndex = 59;
            this.btnAñadirAPresupuesto.Text = "Añadir a Presupuesto";
            this.btnAñadirAPresupuesto.UseVisualStyleBackColor = true;
            this.btnAñadirAPresupuesto.Click += new System.EventHandler(this.btnAñadirAPresupuesto_Click);
            // 
            // FormListadoAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 625);
            this.Controls.Add(this.btnAñadirAPresupuesto);
            this.Controls.Add(this.lblPresupuestoActivo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dateTimeEgreso);
            this.Controls.Add(this.dateTimeIngreso);
            this.Controls.Add(this.comboCalificacion);
            this.Controls.Add(this.textCantidadInfantes);
            this.Controls.Add(this.textCantidadMenores);
            this.Controls.Add(this.textCantidadAdultos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.dataGridViewListadoAlojamiento);
            this.Name = "FormListadoAlojamiento";
            this.Text = "Listado Alojamiento";
            this.Load += new System.EventHandler(this.FormListadoAlojamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoAlojamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListadoAlojamiento;
        private System.Windows.Forms.Button btnVerPresupuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimeEgreso;
        private System.Windows.Forms.DateTimePicker dateTimeIngreso;
        private System.Windows.Forms.ComboBox comboCalificacion;
        private System.Windows.Forms.TextBox textCantidadInfantes;
        private System.Windows.Forms.TextBox textCantidadMenores;
        private System.Windows.Forms.TextBox textCantidadAdultos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPresupuestoActivo;
        private System.Windows.Forms.Button btnAñadirAPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHabitacion;
    }
}