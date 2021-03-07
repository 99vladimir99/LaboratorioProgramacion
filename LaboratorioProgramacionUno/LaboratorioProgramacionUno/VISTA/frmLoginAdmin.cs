using System;
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
using LaboratorioProgramacionUno.VISTA;


namespace LaboratorioProgramacionUno.VISTA
{
    public partial class FrmLoginAdmin : Form
    {
        public FrmLoginAdmin()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DOMINIO.Login log = new DOMINIO.Login();

            log.Administrador = txtAdmin.Text;
            log.AdminPassword = txtAdminPass.Text;

            ClsLoginAdmin cls = new ClsLoginAdmin();

            int evaluacion = cls.acceso(log);

            if (evaluacion == 1)
            {

                MessageBox.Show("Bienvenido " + txtAdmin.Text);

                FrmOperaciones frmop = new FrmOperaciones();
                frmop.nombrePersona = txtAdmin.Text;
                frmop.Show();
            }
            else
            {

                MessageBox.Show("Los datos ingresados son incorrectos");
            }

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
