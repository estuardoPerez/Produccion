using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmInicio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {

            ProduccionDLL.frmConceptoDeProduccion datos = new ProduccionDLL.frmConceptoDeProduccion();
            datos.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProduccionDLL.frmCostos datos = new ProduccionDLL.frmCostos();
            datos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProduccionDLL.frmProductosTerminados datos = new ProduccionDLL.frmProductosTerminados();
            datos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             ProduccionDLL.frmProcesos datos = new ProduccionDLL.frmProcesos();
            datos.Show();
        }
        private void Trm_tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            timer1.Start();

        }
        private void frmInicio_Load(object sender, EventArgs e)
        
        {
            timer1.Start();


            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
  
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

        private void frmInicio_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda produccion/Manual de usuario.chm", "ayuda frmProductosTerminados.html");

        }
    }
}

