using LaboratorioProgramacionUno.DOMINIO;
using LaboratorioProgramacionUno.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno.VISTA
{
    public partial class frmLoginUsuario : Form
    {
        public frmLoginUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DOMINIO.Login log = new DOMINIO.Login();

            log.Usuario = txtUsuario.Text;
            log.Password = txtContraseña.Text;

            ClsLoginUsuario cls = new ClsLoginUsuario();

            int evaluacion = cls.acceso(log);

            if (evaluacion ==1) {

               MessageBox.Show("Bienvenido" + txtUsuario.Text );

                FrmOperaciones frmop = new FrmOperaciones();
                frmop.Show();
            } else
            {

                MessageBox.Show("Los datos ingresados son incorrectos");

            }
              
        

            
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLoginUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

  