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
    public partial class frm_explosion : Form
    {
        public frm_explosion()
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
    }
}
