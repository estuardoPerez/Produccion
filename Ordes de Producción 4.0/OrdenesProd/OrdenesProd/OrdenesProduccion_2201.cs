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

namespace OrdenesProd
{
    public partial class OrdenesProduccion_2201 : Form
    {
        Navegador nv = new Navegador();
        public OrdenesProduccion_2201()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new DatosOrdenes_2202(dataGridView1).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Ayuda/ayudaGeneral.chm", "general.html");
        }
    }
}
