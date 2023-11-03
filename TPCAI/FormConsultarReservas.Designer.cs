namespace TPCAI
{
    partial class FormConsultarReservas
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
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.ColumnFechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.AllowUserToAddRows = false;
            this.dataGridViewReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFechaReserva,
            this.ColumnDNI,
            this.ColNombre,
            this.ColumnEstado});
            this.dataGridViewReservas.Location = new System.Drawing.Point(23, 84);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.Size = new System.Drawing.Size(957, 495);
            this.dataGridViewReservas.TabIndex = 7;
            // 
            // ColumnFechaReserva
            // 
            this.ColumnFechaReserva.HeaderText = "Fecha de Reserva";
            this.ColumnFechaReserva.Name = "ColumnFechaReserva";
            // 
            // ColumnDNI
            // 
            this.ColumnDNI.HeaderText = "DNI";
            this.ColumnDNI.Name = "ColumnDNI";
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre y Apellido del Cliente";
            this.ColNombre.Name = "ColNombre";
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° Presupuesto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(858, 596);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(122, 31);
            this.btnVolverMenu.TabIndex = 13;
            this.btnVolverMenu.Text = "Volver al Menú";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // FormConsultarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 659);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.dataGridViewReservas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "FormConsultarReservas";
            this.Text = "Consultar Reservas";
            this.Load += new System.EventHandler(this.FormConsultarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
    }
}