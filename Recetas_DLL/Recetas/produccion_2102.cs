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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: cierre de formulario
             */
            if (anterior != null)
                anterior.Show();
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: minimiza el formulario
             */
            this.WindowState = FormWindowState.Minimized;
        }

        private void produccion_2102_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: obtiene HTML de ayuda
             */
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas_DLL/ayuda/ayuda.chm", "nueva_receta.html");
        }

        private void lbl_costo_total_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: 
             */

        }

        private void btn_eliminar_campo_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: 
             */

        }

        private void btn_agregar_campo_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: 
             */

        }
    }
}
