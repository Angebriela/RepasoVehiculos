﻿namespace RepasoVehiculos
{
    partial class FormReporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAlquiler = new System.Windows.Forms.Label();
            this.buttonMostrarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTE DE ALQUILERES";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(680, 415);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(108, 23);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "MENU";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 276);
            this.dataGridView1.TabIndex = 4;
            // 
            // labelAlquiler
            // 
            this.labelAlquiler.AutoSize = true;
            this.labelAlquiler.Location = new System.Drawing.Point(30, 415);
            this.labelAlquiler.Name = "labelAlquiler";
            this.labelAlquiler.Size = new System.Drawing.Size(52, 13);
            this.labelAlquiler.TabIndex = 5;
            this.labelAlquiler.Text = "El carro...";
            this.labelAlquiler.Visible = false;
            // 
            // buttonMostrarReporte
            // 
            this.buttonMostrarReporte.Location = new System.Drawing.Point(33, 93);
            this.buttonMostrarReporte.Name = "buttonMostrarReporte";
            this.buttonMostrarReporte.Size = new System.Drawing.Size(731, 23);
            this.buttonMostrarReporte.TabIndex = 6;
            this.buttonMostrarReporte.Text = "Generar Reporte 📃";
            this.buttonMostrarReporte.UseVisualStyleBackColor = true;
            this.buttonMostrarReporte.Click += new System.EventHandler(this.buttonMostrarReporte_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMostrarReporte);
            this.Controls.Add(this.labelAlquiler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.label1);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAlquiler;
        private System.Windows.Forms.Button buttonMostrarReporte;
    }
}