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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }
        public String usuarioEstado;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtOperaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)

        {
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR O IGUAL 50 TENDRA UN DESCUENTO", "<=50");
            dataGridView1.Show();
        }  

        private void Operaciones_Load(object sender, EventArgs e)
        {


            label1.Text = usuarioEstado;

        }

    }

}
    



