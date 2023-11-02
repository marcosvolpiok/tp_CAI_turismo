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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnQuitarPasajero = new System.Windows.Forms.Button();
            this.dataGridListadoPasajeros = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAddPasajero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListadoPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Vuelo Buenos Aires - La Habana - Latam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Presupuesto Activo: 4545";
            // 
            // btnQuitarPasajero
            // 
            this.btnQuitarPasajero.Location = new System.Drawing.Point(223, 539);
            this.btnQuitarPasajero.Name = "btnQuitarPasajero";
            this.btnQuitarPasajero.Size = new System.Drawing.Size(161, 31);
            this.btnQuitarPasajero.TabIndex = 59;
            this.btnQuitarPasajero.Text = "Quitar Pasajero Seleccionado";
            this.btnQuitarPasajero.UseVisualStyleBackColor = true;
            this.btnQuitarPasajero.Click += new System.EventHandler(this.btnQuitarPasajero_Click);
            // 
            // dataGridListadoPasajeros
            // 
            this.dataGridListadoPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListadoPasajeros.Location = new System.Drawing.Point(72, 89);
            this.dataGridListadoPasajeros.Name = "dataGridListadoPasajeros";
            this.dataGridListadoPasajeros.Size = new System.Drawing.Size(796, 427);
            this.dataGridListadoPasajeros.TabIndex = 60;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(691, 539);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(177, 31);
            this.btnVolver.TabIndex = 61;
            this.btnVolver.Text = "Volver a Prespuestos y Reservas";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAddPasajero
            // 
            this.btnAddPasajero.Location = new System.Drawing.Point(72, 539);
            this.btnAddPasajero.Name = "btnAddPasajero";
            this.btnAddPasajero.Size = new System.Drawing.Size(122, 31);
            this.btnAddPasajero.TabIndex = 17;
            this.btnAddPasajero.Text = "Añadir Pasajero";
            this.btnAddPasajero.UseVisualStyleBackColor = true;
            this.btnAddPasajero.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormAñadirPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 606);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridListadoPasajeros);
            this.Controls.Add(this.btnQuitarPasajero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddPasajero);
            this.Name = "FormAñadirPasajero";
            this.Text = "Añadir Pasajero";
            this.Load += new System.EventHandler(this.FormAñadirPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListadoPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnQuitarPasajero;
        private System.Windows.Forms.DataGridView dataGridListadoPasajeros;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAddPasajero;
    }
}