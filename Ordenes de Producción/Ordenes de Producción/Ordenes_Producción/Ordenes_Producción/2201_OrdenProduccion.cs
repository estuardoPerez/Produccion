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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 datosIn = new Form2();
            datosIn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 datosEd = new Form2();
            datosEd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/User/Desktop/Ordenes de Producción/Ayuda/ayudaGeneral.chm", "general.html");
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/User/Desktop/Ordenes de Producción/Ayuda/ayudaGeneral.chm", "general.html");
        }
    }
}
