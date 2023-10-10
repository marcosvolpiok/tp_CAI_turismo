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
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.btnConsultarReservas = new System.Windows.Forms.Button();
            this.btnGenerarReservas = new System.Windows.Forms.Button();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.Location = new System.Drawing.Point(147, 43);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(143, 42);
            this.btnConsultarProductos.TabIndex = 0;
            this.btnConsultarProductos.Text = "Consultar Productos";
            this.btnConsultarProductos.UseVisualStyleBackColor = true;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // btnConsultarReservas
            // 
            this.btnConsultarReservas.Location = new System.Drawing.Point(147, 214);
            this.btnConsultarReservas.Name = "btnConsultarReservas";
            this.btnConsultarReservas.Size = new System.Drawing.Size(143, 42);
            this.btnConsultarReservas.TabIndex = 2;
            this.btnConsultarReservas.Text = "Consular Reservas";
            this.btnConsultarReservas.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReservas
            // 
            this.btnGenerarReservas.Location = new System.Drawing.Point(147, 125);
            this.btnGenerarReservas.Name = "btnGenerarReservas";
            this.btnGenerarReservas.Size = new System.Drawing.Size(143, 42);
            this.btnGenerarReservas.TabIndex = 3;
            this.btnGenerarReservas.Text = "Generar Reservas";
            this.btnGenerarReservas.UseVisualStyleBackColor = true;
            this.btnGenerarReservas.Click += new System.EventHandler(this.btnGenerarReservas_Click);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Location = new System.Drawing.Point(147, 301);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(143, 42);
            this.btnSalirMenu.TabIndex = 4;
            this.btnSalirMenu.Text = "Salir";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // FromMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 467);
            this.Controls.Add(this.btnSalirMenu);
            this.Controls.Add(this.btnGenerarReservas);
            this.Controls.Add(this.btnConsultarReservas);
            this.Controls.Add(this.btnConsultarProductos);
            this.Name = "FromMenu";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.Button btnConsultarReservas;
        private System.Windows.Forms.Button btnGenerarReservas;
        private System.Windows.Forms.Button btnSalirMenu;
    }
}

