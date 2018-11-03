using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MateriaPrima datos = new MateriaPrima();
            datos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTipoCama datos = new frmTipoCama();
            datos.Show();
        }
    }
}
