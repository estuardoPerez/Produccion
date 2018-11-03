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
    public partial class MateriaPrima : Form
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }

        private void MateriaPrima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Users/echeverr.i16825/Desktop/Proyecto Analisis de Sistema/Ayuda Producción/AYUDA/Producción Ayuda.chm", "tipoCama.html");

        }
    }
}
