namespace TPCAI
{
    partial class FromMenu
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
            this.btnVuelos = new System.Windows.Forms.Button();
            this.btnGenerarReservas = new System.Windows.Forms.Button();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.btnAlojamientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVuelos
            // 
            this.btnVuelos.Location = new System.Drawing.Point(85, 79);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(143, 42);
            this.btnVuelos.TabIndex = 0;
            this.btnVuelos.Text = "Consultar Vuelos";
            this.btnVuelos.UseVisualStyleBackColor = true;
            this.btnVuelos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // btnGenerarReservas
            // 
            this.btnGenerarReservas.Location = new System.Drawing.Point(85, 234);
            this.btnGenerarReservas.Name = "btnGenerarReservas";
            this.btnGenerarReservas.Size = new System.Drawing.Size(143, 42);
            this.btnGenerarReservas.TabIndex = 3;
            this.btnGenerarReservas.Text = "Presupuestos y Reservas";
            this.btnGenerarReservas.UseVisualStyleBackColor = true;
            this.btnGenerarReservas.Click += new System.EventHandler(this.btnGenerarReservas_Click);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Location = new System.Drawing.Point(85, 312);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(143, 42);
            this.btnSalirMenu.TabIndex = 4;
            this.btnSalirMenu.Text = "Salir";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // btnAlojamientos
            // 
            this.btnAlojamientos.Location = new System.Drawing.Point(85, 154);
            this.btnAlojamientos.Name = "btnAlojamientos";
            this.btnAlojamientos.Size = new System.Drawing.Size(143, 42);
            this.btnAlojamientos.TabIndex = 5;
            this.btnAlojamientos.Text = "Consultar Alojamientos";
            this.btnAlojamientos.UseVisualStyleBackColor = true;
            this.btnAlojamientos.Click += new System.EventHandler(this.btnAlojamientos_Click);
            // 
            // FromMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 433);
            this.Controls.Add(this.btnAlojamientos);
            this.Controls.Add(this.btnSalirMenu);
            this.Controls.Add(this.btnGenerarReservas);
            this.Controls.Add(this.btnVuelos);
            this.Name = "FromMenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.FromMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVuelos;
        private System.Windows.Forms.Button btnGenerarReservas;
        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.Button btnAlojamientos;
    }
}

