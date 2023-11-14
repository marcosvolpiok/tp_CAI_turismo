namespace TPCAI
{
    partial class FormAñadirPasajero
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
            this.lblPresupuestoActivo = new System.Windows.Forms.Label();
            this.btnQuitarPasajero = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAddAñadir = new System.Windows.Forms.Button();
            this.listViewPasajeros = new System.Windows.Forms.ListView();
            this.ColumnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaNacimiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdTarifaVuelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdHabitacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboProductos = new System.Windows.Forms.ComboBox();
            this.btnCargarVuelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPresupuestoActivo
            // 
            this.lblPresupuestoActivo.AutoSize = true;
            this.lblPresupuestoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuestoActivo.Location = new System.Drawing.Point(68, 21);
            this.lblPresupuestoActivo.Name = "lblPresupuestoActivo";
            this.lblPresupuestoActivo.Size = new System.Drawing.Size(177, 20);
            this.lblPresupuestoActivo.TabIndex = 58;
            this.lblPresupuestoActivo.Text = "lblPresupuestoActivo";
            // 
            // btnQuitarPasajero
            // 
            this.btnQuitarPasajero.Location = new System.Drawing.Point(433, 472);
            this.btnQuitarPasajero.Name = "btnQuitarPasajero";
            this.btnQuitarPasajero.Size = new System.Drawing.Size(161, 31);
            this.btnQuitarPasajero.TabIndex = 59;
            this.btnQuitarPasajero.Text = "Quitar Pasajero Seleccionado";
            this.btnQuitarPasajero.UseVisualStyleBackColor = true;
            this.btnQuitarPasajero.Click += new System.EventHandler(this.btnQuitarPasajero_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(735, 554);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(177, 31);
            this.btnVolver.TabIndex = 61;
            this.btnVolver.Text = "Volver a Prespuestos y Reservas";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAddAñadir
            // 
            this.btnAddAñadir.Location = new System.Drawing.Point(433, 426);
            this.btnAddAñadir.Name = "btnAddAñadir";
            this.btnAddAñadir.Size = new System.Drawing.Size(161, 31);
            this.btnAddAñadir.TabIndex = 17;
            this.btnAddAñadir.Text = "Añadir Pasajero";
            this.btnAddAñadir.UseVisualStyleBackColor = true;
            this.btnAddAñadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // listViewPasajeros
            // 
            this.listViewPasajeros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnNombre,
            this.columnApellido,
            this.columnDNI,
            this.columnFechaNacimiento,
            this.columnIdTarifaVuelo,
            this.columnIdHabitacion});
            this.listViewPasajeros.HideSelection = false;
            this.listViewPasajeros.Location = new System.Drawing.Point(84, 60);
            this.listViewPasajeros.Name = "listViewPasajeros";
            this.listViewPasajeros.Size = new System.Drawing.Size(796, 262);
            this.listViewPasajeros.TabIndex = 62;
            this.listViewPasajeros.UseCompatibleStateImageBehavior = false;
            this.listViewPasajeros.View = System.Windows.Forms.View.Details;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.Text = "Nombre";
            this.ColumnNombre.Width = 185;
            // 
            // columnApellido
            // 
            this.columnApellido.Text = "Apellido";
            this.columnApellido.Width = 131;
            // 
            // columnDNI
            // 
            this.columnDNI.Text = "DNI";
            this.columnDNI.Width = 116;
            // 
            // columnFechaNacimiento
            // 
            this.columnFechaNacimiento.Text = "Fecha Nacimiento";
            this.columnFechaNacimiento.Width = 120;
            // 
            // columnIdTarifaVuelo
            // 
            this.columnIdTarifaVuelo.Text = "IDVuelo";
            // 
            // columnIdHabitacion
            // 
            this.columnIdHabitacion.Text = "IDHabitacion";
            this.columnIdHabitacion.Width = 80;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(81, 354);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(307, 20);
            this.textNombre.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(81, 411);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(307, 20);
            this.textApellido.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "DNI";
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(81, 463);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(307, 20);
            this.textDNI.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(78, 516);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(310, 20);
            this.dateTimeFechaNacimiento.TabIndex = 71;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(524, 554);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 31);
            this.btnGuardar.TabIndex = 72;
            this.btnGuardar.Text = "Guardar Todos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.Red;
            this.btnDebug.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDebug.Location = new System.Drawing.Point(719, 405);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(161, 52);
            this.btnDebug.TabIndex = 73;
            this.btnDebug.Text = "DEBUG: Ver pasajeros en módulo Reservas";
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Visible = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Producto";
            // 
            // comboProductos
            // 
            this.comboProductos.FormattingEnabled = true;
            this.comboProductos.Location = new System.Drawing.Point(82, 576);
            this.comboProductos.Name = "comboProductos";
            this.comboProductos.Size = new System.Drawing.Size(305, 21);
            this.comboProductos.TabIndex = 75;
            // 
            // btnCargarVuelo
            // 
            this.btnCargarVuelo.BackColor = System.Drawing.Color.Red;
            this.btnCargarVuelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargarVuelo.Location = new System.Drawing.Point(719, 479);
            this.btnCargarVuelo.Name = "btnCargarVuelo";
            this.btnCargarVuelo.Size = new System.Drawing.Size(161, 52);
            this.btnCargarVuelo.TabIndex = 76;
            this.btnCargarVuelo.Text = "DEBUG: Cargar vuelo en Combo Productos";
            this.btnCargarVuelo.UseVisualStyleBackColor = false;
            this.btnCargarVuelo.Visible = false;
            this.btnCargarVuelo.Click += new System.EventHandler(this.btnCargarVuelo_Click);
            // 
            // FormAñadirPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 606);
            this.Controls.Add(this.btnCargarVuelo);
            this.Controls.Add(this.comboProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dateTimeFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.listViewPasajeros);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnQuitarPasajero);
            this.Controls.Add(this.lblPresupuestoActivo);
            this.Controls.Add(this.btnAddAñadir);
            this.Name = "FormAñadirPasajero";
            this.Text = "Añadir Pasajero";
            this.Load += new System.EventHandler(this.FormAñadirPasajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPresupuestoActivo;
        private System.Windows.Forms.Button btnQuitarPasajero;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAddAñadir;
        private System.Windows.Forms.ListView listViewPasajeros;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColumnHeader ColumnNombre;
        private System.Windows.Forms.ColumnHeader columnApellido;
        private System.Windows.Forms.ColumnHeader columnDNI;
        private System.Windows.Forms.ColumnHeader columnFechaNacimiento;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboProductos;
        private System.Windows.Forms.ColumnHeader columnIdTarifaVuelo;
        private System.Windows.Forms.ColumnHeader columnIdHabitacion;
        private System.Windows.Forms.Button btnCargarVuelo;
    }
}