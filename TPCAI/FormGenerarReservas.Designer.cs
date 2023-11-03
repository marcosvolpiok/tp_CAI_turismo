namespace TPCAI
{
    partial class FormGenerarReservas
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
            this.btnPreReservar = new System.Windows.Forms.Button();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGenerarPreReserva = new System.Windows.Forms.TabPage();
            this.btnNuevoPresupuesto = new System.Windows.Forms.Button();
            this.btnEstablecerActivo = new System.Windows.Forms.Button();
            this.btnAñadirPasajeros = new System.Windows.Forms.Button();
            this.dataGridViewPreReserva = new System.Windows.Forms.DataGridView();
            this.ColumnNroPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalPrespuestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabReservar = new System.Windows.Forms.TabPage();
            this.dataGridViewGenerarReserva = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConfirmar = new System.Windows.Forms.TabPage();
            this.dataGridViewGenerarConfirmacion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstadoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.lblActivo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGenerarPreReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreReserva)).BeginInit();
            this.tabReservar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenerarReserva)).BeginInit();
            this.tabConfirmar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenerarConfirmacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreReservar
            // 
            this.btnPreReservar.Location = new System.Drawing.Point(850, 507);
            this.btnPreReservar.Name = "btnPreReservar";
            this.btnPreReservar.Size = new System.Drawing.Size(122, 31);
            this.btnPreReservar.TabIndex = 2;
            this.btnPreReservar.Text = "Pre-Reservar";
            this.btnPreReservar.UseVisualStyleBackColor = true;
            this.btnPreReservar.Click += new System.EventHandler(this.btnPreReservar_Click);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(11, 20);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(75, 13);
            this.labelDNI.TabIndex = 3;
            this.labelDNI.Text = "N° Presupusto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGenerarPreReserva);
            this.tabControl1.Controls.Add(this.tabReservar);
            this.tabControl1.Controls.Add(this.tabConfirmar);
            this.tabControl1.Location = new System.Drawing.Point(9, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 572);
            this.tabControl1.TabIndex = 9;
            // 
            // tabGenerarPreReserva
            // 
            this.tabGenerarPreReserva.Controls.Add(this.btnNuevoPresupuesto);
            this.tabGenerarPreReserva.Controls.Add(this.btnEstablecerActivo);
            this.tabGenerarPreReserva.Controls.Add(this.btnAñadirPasajeros);
            this.tabGenerarPreReserva.Controls.Add(this.dataGridViewPreReserva);
            this.tabGenerarPreReserva.Controls.Add(this.btnPreReservar);
            this.tabGenerarPreReserva.Location = new System.Drawing.Point(4, 22);
            this.tabGenerarPreReserva.Name = "tabGenerarPreReserva";
            this.tabGenerarPreReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerarPreReserva.Size = new System.Drawing.Size(987, 546);
            this.tabGenerarPreReserva.TabIndex = 0;
            this.tabGenerarPreReserva.Text = "Generar Pre-Reserva";
            this.tabGenerarPreReserva.UseVisualStyleBackColor = true;
            this.tabGenerarPreReserva.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnNuevoPresupuesto
            // 
            this.btnNuevoPresupuesto.Location = new System.Drawing.Point(352, 507);
            this.btnNuevoPresupuesto.Name = "btnNuevoPresupuesto";
            this.btnNuevoPresupuesto.Size = new System.Drawing.Size(149, 31);
            this.btnNuevoPresupuesto.TabIndex = 15;
            this.btnNuevoPresupuesto.Text = "Iniciar Nuevo Presupuesto";
            this.btnNuevoPresupuesto.UseVisualStyleBackColor = true;
            this.btnNuevoPresupuesto.Click += new System.EventHandler(this.btnNuevoPresupuesto_Click);
            // 
            // btnEstablecerActivo
            // 
            this.btnEstablecerActivo.Location = new System.Drawing.Point(507, 507);
            this.btnEstablecerActivo.Name = "btnEstablecerActivo";
            this.btnEstablecerActivo.Size = new System.Drawing.Size(209, 31);
            this.btnEstablecerActivo.TabIndex = 14;
            this.btnEstablecerActivo.Text = "Establecer Seleccionado como Activo";
            this.btnEstablecerActivo.UseVisualStyleBackColor = true;
            this.btnEstablecerActivo.Click += new System.EventHandler(this.btnEstablecerActivo_Click);
            // 
            // btnAñadirPasajeros
            // 
            this.btnAñadirPasajeros.Location = new System.Drawing.Point(722, 507);
            this.btnAñadirPasajeros.Name = "btnAñadirPasajeros";
            this.btnAñadirPasajeros.Size = new System.Drawing.Size(122, 31);
            this.btnAñadirPasajeros.TabIndex = 13;
            this.btnAñadirPasajeros.Text = "Añadir Pasajeros";
            this.btnAñadirPasajeros.UseVisualStyleBackColor = true;
            this.btnAñadirPasajeros.Click += new System.EventHandler(this.btnAñadirPasajeros_Click);
            // 
            // dataGridViewPreReserva
            // 
            this.dataGridViewPreReserva.AllowUserToAddRows = false;
            this.dataGridViewPreReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPreReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNroPresupuesto,
            this.ColumnFecha,
            this.ColumnProductos,
            this.ColumnTotalPrespuestado});
            this.dataGridViewPreReserva.Location = new System.Drawing.Point(15, 6);
            this.dataGridViewPreReserva.Name = "dataGridViewPreReserva";
            this.dataGridViewPreReserva.Size = new System.Drawing.Size(957, 495);
            this.dataGridViewPreReserva.TabIndex = 3;
            // 
            // ColumnNroPresupuesto
            // 
            this.ColumnNroPresupuesto.HeaderText = "NroPresupuesto";
            this.ColumnNroPresupuesto.Name = "ColumnNroPresupuesto";
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            // 
            // ColumnProductos
            // 
            this.ColumnProductos.HeaderText = "Productos";
            this.ColumnProductos.Name = "ColumnProductos";
            // 
            // ColumnTotalPrespuestado
            // 
            this.ColumnTotalPrespuestado.HeaderText = "Total Prespuestado";
            this.ColumnTotalPrespuestado.Name = "ColumnTotalPrespuestado";
            // 
            // tabReservar
            // 
            this.tabReservar.Controls.Add(this.dataGridViewGenerarReserva);
            this.tabReservar.Location = new System.Drawing.Point(4, 22);
            this.tabReservar.Name = "tabReservar";
            this.tabReservar.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservar.Size = new System.Drawing.Size(987, 546);
            this.tabReservar.TabIndex = 1;
            this.tabReservar.Text = "Generar Reservar";
            this.tabReservar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGenerarReserva
            // 
            this.dataGridViewGenerarReserva.AllowUserToAddRows = false;
            this.dataGridViewGenerarReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGenerarReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenerarReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewGenerarReserva.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewGenerarReserva.Name = "dataGridViewGenerarReserva";
            this.dataGridViewGenerarReserva.Size = new System.Drawing.Size(981, 543);
            this.dataGridViewGenerarReserva.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NroReserva";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Productos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tabConfirmar
            // 
            this.tabConfirmar.Controls.Add(this.dataGridViewGenerarConfirmacion);
            this.tabConfirmar.Controls.Add(this.btnConfirmar);
            this.tabConfirmar.Location = new System.Drawing.Point(4, 22);
            this.tabConfirmar.Name = "tabConfirmar";
            this.tabConfirmar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfirmar.Size = new System.Drawing.Size(987, 546);
            this.tabConfirmar.TabIndex = 2;
            this.tabConfirmar.Text = "Generar Confirmación";
            this.tabConfirmar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGenerarConfirmacion
            // 
            this.dataGridViewGenerarConfirmacion.AllowUserToAddRows = false;
            this.dataGridViewGenerarConfirmacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGenerarConfirmacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenerarConfirmacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.ColumnEstadoPago,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewGenerarConfirmacion.Location = new System.Drawing.Point(15, 6);
            this.dataGridViewGenerarConfirmacion.Name = "dataGridViewGenerarConfirmacion";
            this.dataGridViewGenerarConfirmacion.Size = new System.Drawing.Size(957, 495);
            this.dataGridViewGenerarConfirmacion.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "NroReserva";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Productos";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // ColumnEstadoPago
            // 
            this.ColumnEstadoPago.HeaderText = "Estado Pago";
            this.ColumnEstadoPago.Name = "ColumnEstadoPago";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(850, 507);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(122, 31);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(414, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 31);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(863, 637);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(122, 31);
            this.btnVolverMenu.TabIndex = 12;
            this.btnVolverMenu.Text = "Volver al Menú";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(589, 20);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(214, 20);
            this.lblActivo.TabIndex = 59;
            this.lblActivo.Text = "Presupuesto Activo: 4545";
            // 
            // FormGenerarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 682);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDNI);
            this.Name = "FormGenerarReservas";
            this.Text = "Generar Reservas";
            this.Load += new System.EventHandler(this.FormGenerarReservas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGenerarPreReserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreReserva)).EndInit();
            this.tabReservar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenerarReserva)).EndInit();
            this.tabConfirmar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenerarConfirmacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreReservar;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGenerarPreReserva;
        private System.Windows.Forms.TabPage tabReservar;
        private System.Windows.Forms.TabPage tabConfirmar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dataGridViewPreReserva;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNroPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalPrespuestado;
        private System.Windows.Forms.DataGridView dataGridViewGenerarReserva;
        private System.Windows.Forms.DataGridView dataGridViewGenerarConfirmacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstadoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnAñadirPasajeros;
        private System.Windows.Forms.Button btnNuevoPresupuesto;
        private System.Windows.Forms.Button btnEstablecerActivo;
        private System.Windows.Forms.Label lblActivo;
    }
}