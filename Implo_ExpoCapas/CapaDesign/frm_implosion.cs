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
    public partial class frm_implosion : Form
    {
        public frm_implosion()
        {
            InitializeComponent();
        }

        private void btn_implosionMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_implosionSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
