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
 * INCLUYE DLL NAVEGADOR, RECETAS E IMPLOSIÓN/EXPLOSIÓN
 * 
 * PARA PODER VISUALIZAR LA AYUDA DESDE EL BOTON DEL NAVEGADOR DE DEBE TENER LA CARPETA DE AYUDA DENTRO DEL
 * DISCO LOCAL C */
namespace OrdenesProd
{
    public partial class DatosOrdenes_2202 : Form
    {
        Navegador nv = new Navegador();
        int contador;
        ConexionBD connection = new ConexionBD();
        Validacion v = new Validacion();

        // NO ORDEN SE GENERA AUTOMATICAMENTE, EMPIEZA DESDE 100 Y AUMENTA DE UNO EN UNO
        public DatosOrdenes_2202(DataGridView dataGridView1)
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
        }


        //LLENADO DE COMBOBOX 
        private void DatosOrdenes_2202_Load(object sender, EventArgs e)
        {
           

            //cargar un combobox, mandar como parametros nombre de la tabla y nombre del campo que se quiere cargar
            DataSet dt = nv.cargarCombobox("tbl_producto", "nombre");
            Cbo_prod.DataSource = dt.Tables[0].DefaultView;
            Cbo_prod.ValueMember = "nombre";

            DataSet dt2 = nv.cargarCombobox("tbl_prioridad", "descripcion_Prioridad");
            Cbo_prioridad.DataSource = dt2.Tables[0].DefaultView;
            Cbo_prioridad.ValueMember = "descripcion_Prioridad";

            DataSet dt3 = nv.cargarCombobox("tbl_estado_avance", "Estado_Avance");
            Cbo_avance.DataSource = dt3.Tables[0].DefaultView;
            Cbo_avance.ValueMember = "Estado_Avance";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //LLENA EL TEXTBOX DEL CODIGO AUTOMATICAMENTE CUANDO SE SELECCIONA UN PRODUCTO DEL COMBOBOX
        private void Cmb_producto_SelectedIndexChanged(object sender, EventArgs e)
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

      
        private void Txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void Txt_encargado_TextChanged(object sender, EventArgs e)
        {
            
        }

        //VALIDA EL TEXTBOX PARA INGRESAR UNICAMENTE NUMEROS ENTEROS Y POSITIVOS
        private void Txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        //VALIDA EL TEXTBOX PARA INGRESAR UNICAMENTE LETRAS
        private void Txt_encargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

        private void Txt_encargado_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda/ayudaGeneral.chm", "datos.html");
        }
    }
    
}
