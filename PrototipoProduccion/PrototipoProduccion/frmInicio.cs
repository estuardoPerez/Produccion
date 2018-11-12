using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PrototipoProduccion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOrdenes datos = new frmOrdenes();
            datos.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmInicio_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/echeverr.i16825/Desktop/Proyecto Analisis de Sistema/Ayuda Producción/AYUDA/Producción Ayuda.chm", "ayuda.html");

        }

        private void label1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmConceptoProduccion datos = new frmConceptoProduccion();
            datos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProcesos datos = new frmProcesos();
            datos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_CosteProduccion datos = new frm_CosteProduccion();
            datos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.ProbarConexion();
        }
    }
}
