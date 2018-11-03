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
    public partial class Menu_prueba : Form
    {
        public Menu_prueba()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Implosion frm_implosion1 = new frm_Implosion();
            frm_implosion1.Show();
        }

        private void btn_Explosion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Explosion frm_explosion1 = new frm_Explosion();
            frm_explosion1.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
             frm_peticion_Materia frm_peticion = new frm_peticion_Materia();
            frm_peticion.Show();
        }
    }
}
