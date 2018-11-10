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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas_DLL/ayuda/ayuda.chm", "ayuda_general.html");
        }

        private void produccion_2101_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas_DLL/ayuda/ayuda.chm", "ayuda_general.html");
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            produccion_2102 nuevo = new produccion_2102(this);
            nuevo.ShowDialog();
            //this.Hide();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            produccion_2102 nuevo = new produccion_2102(this);
            nuevo.ShowDialog();
            //this.Hide();
        }
    }
}
