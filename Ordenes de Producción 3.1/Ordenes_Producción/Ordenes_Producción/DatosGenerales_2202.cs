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
using CapaDiseno;

/* AUTOR: ESTUARDO PÉREZ
 * 
 * PARA PODER VISUALIZAR LA AYUDA DESDE EL BOTON DEL NAVEGADOR DE DEBE TENER LA CARPETA DE AYUDA DENTRO DEL
 * DISCO LOCAL C */
namespace Ordenes_Producción
{
    public partial class DatosGenerales_2202 : Form
    {
         Navegador nv = new Navegador();
     

        Validacion v = new Validacion();
        int contador;
        ConexionBD connection = new ConexionBD();
         
        // NO ORDEN SE GENERA AUTOMATICAMENTE, EMPIEZA DESDE 100 Y AUMENTA DE UNO EN UNO
        public DatosGenerales_2202(DataGridView Dgv_prod)
       
        {
            InitializeComponent();
            nv.dgv_datos(Dgv_prod);
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

       //LLENADO DE COMBOBOX 
        private void DatosGenerales_2202_Load(object sender, EventArgs e)
        {
            //ingresar  en más tablas
            nv.otrasTablas("tbl_orden_detalle",Txt_norden,Txt_codigo,Txt_cantidad);

            //cargar un combobox, mandar como parametros nombre de la tabla y nombre del campo que se quiere cargar
            DataSet dt = nv.cargarCombobox("tbl_producto", "nombre");
            Cbo_prod.DataSource = dt.Tables[0].DefaultView;
            Cbo_prod.ValueMember = "nombre";

            DataSet dt2 = nv.cargarCombobox("tbl_prioridad", "descripcion_Prioridad");
            Cbo_prioridad.DataSource = dt2.Tables[0].DefaultView;
            Cbo_prioridad.ValueMember = "descripcion_Prioridad";
        }
        
      

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_norden_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda/ayudaGeneral.chm", "datos.html#Ayuda1");
        }

        //MENSAJE PRUEBA PARA VER SI EXISTEN MATERIALES O NO
        private void button2_Click(object sender, EventArgs e)
        {
          
            if (Txt_cantidad.Text == "15"){
                MessageBox.Show("La cantidad si existe");
            }
            else
            {
                MessageBox.Show("La cantidad no existe, solicitar material");
            }
        }

        private void textBox6_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda/ayudaGeneral.chm", "datos.html#Ayuda2");
        }

        //MUESTRA LA AYUDA AL PRESIONAR CTRL + F1 O SOLO F1 CUANDO SE TIENE SELECCIONADO EL TEXTBOX NO ORDEN
        private void Txt_cantidad_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda/ayudaGeneral.chm", "datos.html#Ayuda4");
        }

       //VALIDA EL TEXTBOX PARA INGRESAR UNICAMENTE NUMEROS ENTEROS Y POSITIVOS
        private void Txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        //VALIDA EL TEXTBOX PARA INGRESAR UNICAMENTE LETRAS
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

        //LLENA EL TEXTBOX DEL CODIGO AUTOMATICAMENTE CUANDO SE SELECCIONA UN PRODUCTO DEL COMBOBOX
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection conectar = ConexionBD.getDB();
            try
            {
                string query = string.Format("SELECT * FROM TBL_PRODUCTO WHERE NOMBRE ='" + Cbo_prod.Text + "'");
                OdbcCommand cmd = new OdbcCommand(query, conectar);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    Txt_codigo.Text = reader["PK_CODIGO_PRODUCTO"].ToString();
                }
                else
                {
                    Txt_codigo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
