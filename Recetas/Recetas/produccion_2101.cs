using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetas
{
    public partial class produccion_2101 : Form
    {
        public produccion_2101()
        {
            InitializeComponent();
        }

        private void produccion_2101_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            produccion_2102 nuevo = new produccion_2102(this);
            nuevo.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            produccion_2103 nuevo = new produccion_2103(this);
            nuevo.Show();
            this.Hide();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas/ayuda/ayuda.chm", "ayuda_general.html");
        }

        private void produccion_2101_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas/ayuda/ayuda.chm", "ayuda_general.html");
        }
    }
}
