namespace RepasoVehiculos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonVehiculos = new System.Windows.Forms.Button();
            this.buttonAlquiler = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // buttonCliente
            // 
            this.buttonCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonCliente.Image")));
            this.buttonCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCliente.Location = new System.Drawing.Point(45, 86);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(317, 57);
            this.buttonCliente.TabIndex = 2;
            this.buttonCliente.Text = "Ingreso Clientes";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonVehiculos
            // 
            this.buttonVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("buttonVehiculos.Image")));
            this.buttonVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVehiculos.Location = new System.Drawing.Point(45, 149);
            this.buttonVehiculos.Name = "buttonVehiculos";
            this.buttonVehiculos.Size = new System.Drawing.Size(317, 57);
            this.buttonVehiculos.TabIndex = 3;
            this.buttonVehiculos.Text = "Ingreso Vehículos";
            this.buttonVehiculos.UseVisualStyleBackColor = true;
            this.buttonVehiculos.Click += new System.EventHandler(this.buttonVehiculos_Click);
            // 
            // buttonAlquiler
            // 
            this.buttonAlquiler.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlquiler.Image")));
            this.buttonAlquiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlquiler.Location = new System.Drawing.Point(45, 212);
            this.buttonAlquiler.Name = "buttonAlquiler";
            this.buttonAlquiler.Size = new System.Drawing.Size(317, 57);
            this.buttonAlquiler.TabIndex = 4;
            this.buttonAlquiler.Text = "Alquilar Vehículo";
            this.buttonAlquiler.UseVisualStyleBackColor = true;
            this.buttonAlquiler.Click += new System.EventHandler(this.buttonAlquiler_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.Image = ((System.Drawing.Image)(resources.GetObject("buttonReporte.Image")));
            this.buttonReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporte.Location = new System.Drawing.Point(45, 275);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(317, 57);
            this.buttonReporte.TabIndex = 5;
            this.buttonReporte.Text = "Reporte de Alquileres";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrar.Location = new System.Drawing.Point(45, 339);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(317, 57);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 421);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.buttonAlquiler);
            this.Controls.Add(this.buttonVehiculos);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ingreso de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonVehiculos;
        private System.Windows.Forms.Button buttonAlquiler;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button buttonCerrar;
    }
}

