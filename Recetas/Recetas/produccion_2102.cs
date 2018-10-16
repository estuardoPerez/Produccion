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
    public partial class produccion_2102 : Form
    {
        produccion_2101 anterior;
        public produccion_2102(produccion_2101 anterior)
        {
            this.anterior = anterior;
            InitializeComponent();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas/ayuda/ayuda.chm", "nueva_receta.html");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_tabla1_Click(object sender, EventArgs e)
        {

        }

        private void produccion_2102_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas/ayuda/ayuda.chm", "nueva_receta.html");
        }
    }
}
