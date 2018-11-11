using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recetas;
using I_E_DLL;
using CapaDiseno;

namespace OrdenesProd
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void ordenesDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenesProduccion_2201 nuevo = new OrdenesProduccion_2201();
            nuevo.Show();
        }

        private void Trm_tiempo_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
            Trm_tiempo.Start();
        }

        private void MDI_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void recetasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void implosiónExplosiónDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_explosion nuevo3 = new frm_explosion();
            nuevo3.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            produccion_2101 nuevo2 = new produccion_2101();
            nuevo2.Show();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            produccion_2102 nuevo2 = new produccion_2102(null);
            nuevo2.Show();
        }
    }
}
