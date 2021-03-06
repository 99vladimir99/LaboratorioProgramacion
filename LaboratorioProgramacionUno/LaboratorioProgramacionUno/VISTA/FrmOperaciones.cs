﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaboratorioProgramacionUno.DOMINIO;
using LaboratorioProgramacionUno.NEGOCIO;
namespace LaboratorioProgramacionUno.VISTA
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }
        public String nombrePersona;
        frmLoginUsuario logi = new frmLoginUsuario();


        private void Operaciones_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = nombrePersona;

            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRA DESCUENTO", "<=50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRA UN DESUENTO DEL 0.05 ", ">50 and <100");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRA UN DESUENTO DEL 0.10 ", ">= 100 and <101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRA UN DESUENTO DEL 0.20 ", ">101 and <150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRA UN DESUENTO DEL 0.50 ", ">150");

            if (nombrePersona == "Carlos" || nombrePersona == "Eva")
            {
                txtProducto.Text = "LAPTOP";
                txtProducto.Enabled = false;
                txtIva.Text = "0.13";
                txtIva.Enabled = false;
                txtCantidad.Text = "1";
                txtPrecio.Text = "100";
            }


        }

            private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                ClsOps administrador = new ClsOps();
                ClsOperaciones cls1 = new ClsOperaciones();

                administrador.PrecioDelProducto = Convert.ToDouble(value: txtPrecio.Text);
                administrador.Cantidad = Convert.ToDouble(value: txtCantidad.Text);
                double resultado1 = cls1.ca1(administrador);
                lblSinIVA.Text = resultado1.ToString();
            }

            {
                ClsOps administrador = new ClsOps();
                ClsOperaciones cls2 = new ClsOperaciones();

                administrador.PrecioDelProducto = Convert.ToDouble(value: txtPrecio.Text);
                administrador.Cantidad = Convert.ToDouble(value: txtCantidad.Text);
                administrador.Iva = Convert.ToDouble(value: txtIva.Text);
                double resultado1 = cls2.ca2(administrador);
                lblTotalInicial.Text = resultado1.ToString();
            }
            {
                ClsOps administrador = new ClsOps();
                ClsOperaciones cls3 = new ClsOperaciones();

                administrador.NombreDelProducto = Convert.ToString(value: txtProducto.Text);
                String resultado1 = cls3.ca3(administrador);
                lblNombreProducto.Text = resultado1.ToString();
            }
            {
                ClsOps administrador = new ClsOps();
                ClsOperaciones cls4 = new ClsOperaciones();

                administrador.PrecioDelProducto = Convert.ToDouble(value: txtPrecio.Text);
                administrador.Iva = Convert.ToDouble(value: txtIva.Text);
                double resultado1 = cls4.ca4(administrador);
                lblAgregarIVA.Text = resultado1.ToString();
            }

            {
                ClsOps administrador = new ClsOps();
                ClsOperaciones cls5 = new ClsOperaciones();

                administrador.PrecioDelProducto = Convert.ToDouble(value: txtPrecio.Text);
                double productoPrecio = administrador.PrecioDelProducto;
                administrador.Cantidad = Convert.ToDouble(value: txtCantidad.Text);
                administrador.Iva = Convert.ToDouble(value: txtIva.Text);
                double resultado1 = cls5.ca2(administrador);

                if (productoPrecio <= 50)
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1);
                    lblFinal.Text = totalFinal.ToString();

                }
                else if (productoPrecio > 50 && resultado1 < 100)
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1) - (0.05 * Convert.ToDouble(resultado1)); //Bug
                    lblFinal.Text = totalFinal.ToString();

                }
                else if (productoPrecio >= 100 && resultado1 < 101)
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1) - (0.10 * Convert.ToDouble(resultado1));
                    lblFinal.Text = totalFinal.ToString();
                }
                else if (productoPrecio >= 101 && resultado1 < 150)
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1) - (0.20 * Convert.ToDouble(resultado1));  //bug
                    lblFinal.Text = totalFinal.ToString();
                }
                else
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1) - (0.50 * Convert.ToDouble(resultado1)); //BUG
                    lblFinal.Text = totalFinal.ToString();

                }
            }

        }


    }
}







