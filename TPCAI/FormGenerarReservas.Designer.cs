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
            this.button1 = new System.Windows.Forms.Button();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGenerarPreReserva = new System.Windows.Forms.TabPage();
            this.tabReservar = new System.Windows.Forms.TabPage();
            this.tabConfirmar = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.ColumnNroPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalPrespuestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstadoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabGenerarPreReserva.SuspendLayout();
            this.tabReservar.SuspendLayout();
            this.tabConfirmar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pre-Reservar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(13, 30);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 3;
            this.labelDNI.Text = "DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGenerarPreReserva);
            this.tabControl1.Controls.Add(this.tabReservar);
            this.tabControl1.Controls.Add(this.tabConfirmar);
            this.tabControl1.Location = new System.Drawing.Point(16, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 509);
            this.tabControl1.TabIndex = 9;
            // 
            // tabGenerarPreReserva
            // 
            this.tabGenerarPreReserva.Controls.Add(this.dataGridView1);
            this.tabGenerarPreReserva.Controls.Add(this.button1);
            this.tabGenerarPreReserva.Location = new System.Drawing.Point(4, 22);
            this.tabGenerarPreReserva.Name = "tabGenerarPreReserva";
            this.tabGenerarPreReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerarPreReserva.Size = new System.Drawing.Size(1011, 483);
            this.tabGenerarPreReserva.TabIndex = 0;
            this.tabGenerarPreReserva.Text = "Generar Pre-Reserva";
            this.tabGenerarPreReserva.UseVisualStyleBackColor = true;
            this.tabGenerarPreReserva.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabReservar
            // 
            this.tabReservar.Controls.Add(this.dataGridView2);
            this.tabReservar.Controls.Add(this.button2);
            this.tabReservar.Location = new System.Drawing.Point(4, 22);
            this.tabReservar.Name = "tabReservar";
            this.tabReservar.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservar.Size = new System.Drawing.Size(1011, 483);
            this.tabReservar.TabIndex = 1;
            this.tabReservar.Text = "Generar Reservar";
            this.tabReservar.UseVisualStyleBackColor = true;
            // 
            // tabConfirmar
            // 
            this.tabConfirmar.Controls.Add(this.dataGridView3);
            this.tabConfirmar.Controls.Add(this.button3);
            this.tabConfirmar.Location = new System.Drawing.Point(4, 22);
            this.tabConfirmar.Name = "tabConfirmar";
            this.tabConfirmar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfirmar.Size = new System.Drawing.Size(1011, 483);
            this.tabConfirmar.TabIndex = 2;
            this.tabConfirmar.Text = "Generar Confirmación";
            this.tabConfirmar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(921, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reservar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(921, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNroPresupuesto,
            this.ColumnFecha,
            this.ColumnProductos,
            this.ColumnTotalPrespuestado});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(998, 441);
            this.dataGridView1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(352, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(998, 427);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.ColumnEstadoPago,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView3.Location = new System.Drawing.Point(6, 21);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(998, 417);
            this.dataGridView3.TabIndex = 4;
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
            // FormGenerarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 603);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDNI);
            this.Name = "FormGenerarReservas";
            this.Text = "Generar Reservas";
            this.tabControl1.ResumeLayout(false);
            this.tabGenerarPreReserva.ResumeLayout(false);
            this.tabReservar.ResumeLayout(false);
            this.tabConfirmar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGenerarPreReserva;
        private System.Windows.Forms.TabPage tabReservar;
        private System.Windows.Forms.TabPage tabConfirmar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNroPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalPrespuestado;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstadoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}