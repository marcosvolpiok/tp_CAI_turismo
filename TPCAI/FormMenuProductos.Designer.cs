﻿namespace TPCAI
{
    partial class FormMenuProductos
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
            this.btnConsultarAlojamiento = new System.Windows.Forms.Button();
            this.btnConsultarVuelos = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarAlojamiento
            // 
            this.btnConsultarAlojamiento.Location = new System.Drawing.Point(85, 71);
            this.btnConsultarAlojamiento.Name = "btnConsultarAlojamiento";
            this.btnConsultarAlojamiento.Size = new System.Drawing.Size(114, 40);
            this.btnConsultarAlojamiento.TabIndex = 10;
            this.btnConsultarAlojamiento.Text = "Consular Alojamientos";
            this.btnConsultarAlojamiento.UseVisualStyleBackColor = true;
            this.btnConsultarAlojamiento.Click += new System.EventHandler(this.btnConsultarAlojamiento_Click);
            // 
            // btnConsultarVuelos
            // 
            this.btnConsultarVuelos.Location = new System.Drawing.Point(85, 140);
            this.btnConsultarVuelos.Name = "btnConsultarVuelos";
            this.btnConsultarVuelos.Size = new System.Drawing.Size(114, 40);
            this.btnConsultarVuelos.TabIndex = 8;
            this.btnConsultarVuelos.Text = "Consular Vuelos";
            this.btnConsultarVuelos.UseVisualStyleBackColor = true;
            this.btnConsultarVuelos.Click += new System.EventHandler(this.btnConsultarVuelos_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(179, 229);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(93, 29);
            this.btnVolverMenu.TabIndex = 11;
            this.btnVolverMenu.Text = "Volver al Menú";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // FormMenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnConsultarAlojamiento);
            this.Controls.Add(this.btnConsultarVuelos);
            this.Name = "FormMenuProductos";
            this.Text = "Menú Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarAlojamiento;
        private System.Windows.Forms.Button btnConsultarVuelos;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}