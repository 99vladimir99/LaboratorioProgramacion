﻿
namespace LaboratorioProgramacionUno
{
    partial class frmMenú
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(38, 97);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(242, 68);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "USUARIO";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.Location = new System.Drawing.Point(366, 97);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(242, 68);
            this.btnAdministrador.TabIndex = 1;
            this.btnAdministrador.Text = "ADMINISTRADOR";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 256);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnUsuario);
            this.Name = "frmMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnAdministrador;
    }
}

