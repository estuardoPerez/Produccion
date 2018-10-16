using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Implosion_y_Explosion_Materiales
{
    public partial class frm_Implosion : Form
    {
        public frm_Implosion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Implosion_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/Javiman/Documents/MaterialesAyuda.chm", "materiales.html");
        }

        private void btn_implosionSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_implosionMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cancelarImplosion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
