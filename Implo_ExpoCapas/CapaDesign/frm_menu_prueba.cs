using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDesign
{
    public partial class frm_menu_prueba : Form
    {
        public frm_menu_prueba()
        {
            InitializeComponent();
        }

        private void btn_explosionMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_explosionSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Implosion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_implosion frm_implosion1 = new frm_implosion();
            frm_implosion1.Show();
        }

        private void btn_Explosion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_explosion frm_explosion1 = new frm_explosion();
            frm_explosion1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_peticion_materia frm_peticion1 = new frm_peticion_materia();
            frm_peticion1.Show();
        }
    }
}
