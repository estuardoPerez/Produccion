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
    public partial class frmCostos : Form
    {
        public frmCostos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridCosteProduccion.DataSource = conn.verCostesProduccion();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBoxCosteProduccion.Text == "")
            {
                MessageBox.Show("campo vacio ingrese un valor");
            }

            else if (comboBoxCosteProduccion.Text == "Ascendente")
            {
                dataGridCosteProduccion.DataSource = conn.verCostesProduccionAscendente();
            }
            else if (comboBoxCosteProduccion.Text == "Descendente")
            {
                dataGridCosteProduccion.DataSource = conn.verCostesProduccionDescendente();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridCosteProduccion.DataSource = conn.verCostesProduccion();

        }
        private void Trm_tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void frmCostos_Load(object sender, EventArgs e)
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

        private void frmCostos_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda produccion/Manual de usuario.chm", "ayuda frmProductosTerminados.html");

        }
    }
}
