using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenes_Producción
{
    public partial class Produccion_2000 : Form
    {
        public Produccion_2000()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ordenDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenProduccion_2201 ordenes = new OrdenProduccion_2201();
                ordenes.Show();
        }

        private void Produccion_2000_Load(object sender, EventArgs e)
        {
            Tmr_tiempo.Start();
            Lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();

            MdiClient ctiMDI;
            foreach(Control cti in this.Controls)
            {
                try
                {
                    ctiMDI = (MdiClient)cti;
                    cti.BackColor = this.BackColor;

                }
                catch(InvalidCastException exc)
                {

                }
            }
        }

        private void Tmr_tiempo_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
            Tmr_tiempo.Start();
        }
    }
}
