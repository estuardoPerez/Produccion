using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                catch (InvalidCastException exc)
                {

                }
            }
        }

        private void Trm_tiempo_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
            Trm_tiempo.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void implosiónExplosiónDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
