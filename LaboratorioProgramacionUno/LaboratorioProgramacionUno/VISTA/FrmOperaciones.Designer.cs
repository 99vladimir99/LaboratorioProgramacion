
using System;

namespace LaboratorioProgramacionUno.VISTA
{
    partial class FrmOperaciones
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
            this.lblTablaDescuentos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTablaDescuentos
            // 
            this.lblTablaDescuentos.AutoSize = true;
            this.lblTablaDescuentos.Location = new System.Drawing.Point(218, 9);
            this.lblTablaDescuentos.Name = "lblTablaDescuentos";
            this.lblTablaDescuentos.Size = new System.Drawing.Size(110, 13);
            this.lblTablaDescuentos.TabIndex = 1;
            this.lblTablaDescuentos.Text = "Tabla de descuentos ";
            this.lblTablaDescuentos.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar,
            this.Accion});
            this.dataGridView1.Location = new System.Drawing.Point(35, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 256);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Accion";
            this.Agregar.MinimumWidth = 20;
            this.Agregar.Name = "Agregar";
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Regla";
            this.Accion.Name = "Accion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTablaDescuentos);
            this.Name = "FrmOperaciones";
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Operaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblTablaDescuentos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.Label label1;
    }
}