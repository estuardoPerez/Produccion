using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Ordenes_Producción
{
    public partial class DatosGenerales_2202 : Form
    {

        int contador;
        ConexionBD connection = new ConexionBD();
         
        public DatosGenerales_2202()
        {
            InitializeComponent();
            connection.ordenes(Txt_norden);
            if (Txt_norden.Text == "")
            {
                Txt_norden.Text = "100";
            }
            else
            {
                contador = Convert.ToInt32(Txt_norden.Text);
                contador = contador + 1;
                Txt_norden.Text = contador.ToString();
            }
           
            prioridad();
            linea();
            lotes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

       
        private void DatosGenerales_2202_Load(object sender, EventArgs e)
        {
           
    }
        //LLENADO DE COMBOBOX DE PRIORIDAD CON DATOS DE LA DB/
        public void prioridad()
        {
            OdbcConnection conecction = ConexionBD.getDB();
            try
            {
                string Query = string.Format("SELECT DESCRIPCION_PRIORIDAD FROM TBL_PRIORIDAD;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_prioridad.SelectedIndex = -1;
                Cmb_prioridad.Items.Clear();
                while (reader.Read())
                {
                    Cmb_prioridad.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        //LLENADO DE COMBOBOX DE LINEA CON DATOS DE LA DB
        public void linea()
        {
            OdbcConnection conecction = ConexionBD.getDB();
            try
            {
                string Query = string.Format("SELECT DESCRIPCION_LINEA FROM TBL_LINEA;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_linea.SelectedIndex = -1;
                Cmb_linea.Items.Clear();
                while (reader.Read())
                {
                    Cmb_linea.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        //LLENADO DE COMBOBOX DE NO.LOTE CON DATOS DE LA DB
        public void lotes()
        {
            OdbcConnection conecction = ConexionBD.getDB();
            try
            {
                string Query = string.Format("SELECT NO_LOTE FROM TBL_LOTE;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_lote.SelectedIndex = -1;
                Cmb_lote.Items.Clear();
                while (reader.Read())
                {
                    Cmb_lote.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Productos_2250 verProd = new Productos_2250();
            verProd.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
