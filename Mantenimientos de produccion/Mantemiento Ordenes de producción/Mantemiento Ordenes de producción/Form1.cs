using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantemiento_Ordenes_de_producción
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _2040_Agregar_Linea f = new _2040_Agregar_Linea();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _2050_Agregar_Lote f = new _2050_Agregar_Lote();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _2020_Agregar_Prioridad f = new _2020_Agregar_Prioridad();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _2030_Agregar_Estado f = new _2030_Agregar_Estado();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _2060_Agregar_Materia f = new _2060_Agregar_Materia();
            f.Show();
        }
    }
}
