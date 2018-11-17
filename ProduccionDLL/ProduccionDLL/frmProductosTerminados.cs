using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProduccionDLL
{
    public partial class frmProductosTerminados : Form
    {
        public frmProductosTerminados()
        {
            InitializeComponent();
        }
        private void Trm_tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void frmProductosTerminados_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewProductosTerminados.DataSource = conn.verProductosTerminados();

        }

        private void frmProductosTerminados_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda produccion/Manual de usuario.chm", "ayuda frmProductosTerminados.html");

        }
    }
}
