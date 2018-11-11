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
    public partial class frm_Explosion : Form
    {
        public frm_Explosion()
        {
            InitializeComponent();
        }

        private void btn_ayudaExplosion_Click(object sender, EventArgs e)
        {

        }

        private void Explosion_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this,"C:/Users/Javiman/Documents/MaterialesAyuda.chm", "explosion.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_explosionMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btn_cancelarExplosion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_prueba menu = new Menu_prueba();
            menu.Show();
        }
    }
}
