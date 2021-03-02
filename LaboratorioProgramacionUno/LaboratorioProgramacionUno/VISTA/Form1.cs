using LaboratorioProgramacionUno.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno
{
    public partial class frmMenú : Form
    {
        public frmMenú()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLoginAdmin frmAdmin = new FrmLoginAdmin();
           frmAdmin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoginUsuario frmUser = new frmLoginUsuario();
            frmUser.Show();
            this.Hide();
        }
    }
}
