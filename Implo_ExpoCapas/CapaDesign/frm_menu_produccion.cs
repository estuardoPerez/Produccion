using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace CapaDesign
{
    public partial class Produccion_2000 : Form
    {
        public Produccion_2000()
        {
            InitializeComponent();
        }

        private void Produccion_2000_Load(object sender, EventArgs e)
        {
            Trm_tiempo.Start();
            Lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();

            MdiClient ctiMDI;
            foreach (Control cti in this.Controls)
            {
                try
                {
                    ctiMDI = (MdiClient)cti;
                    cti.BackColor = this.BackColor;

                }
                catch (InvalidCastException ecx)
                {

                }
            }
        }

        private void Trm_tiempo_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
            Trm_tiempo.Start();
        }

        private void implosiónExplosiónDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_menu_prueba enviar = new frm_menu_prueba();
            enviar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
