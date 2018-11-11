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

namespace Recetas
{
    public partial class produccion_2102 : Form
    {
        produccion_2101 anterior;
        public produccion_2102(produccion_2101 anterior)
        {
            this.anterior = anterior;
            InitializeComponent();
            getDatos();
        }

        private void getCampos(String Query, ComboBox cmb_temp)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: obtiene los campos de la tabla seleccionada
             */
            try
            {
                OdbcConnection conexion = CapaDatos.getConnection(); // obtiene conexion con la DB // obtiene conexion con la DB
                OdbcCommand cmd = new OdbcCommand(Query, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                cmb_temp.SelectedIndex = -1;
                cmb_temp.Items.Clear();
                while (reader.Read())
                {
                    cmb_temp.Items.Add(reader.GetString(0)); // agrega los campos a cbo_temp
                }
                conexion.Close(); // cierre de conexion con la DB // cierre de conexion con la DB
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getTexto(String Query, TextBox txt_temp)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: obtiene los campos de la tabla seleccionada
             */
            try
            {
                OdbcConnection conexion = CapaDatos.getConnection(); // obtiene conexion con la DB // obtiene conexion con la DB
                OdbcCommand cmd = new OdbcCommand(Query, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_temp.Text = reader.GetString(0);
                }
                conexion.Close(); // cierre de conexion con la DB // cierre de conexion con la DB
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void getDatos()
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: obtiene los campos de la tabla seleccionada
             */
            string Query = string.Format("SELECT PK_Codigo_Producto FROM TBL_Producto;"); // query
            getCampos(Query, cbo_productos);
            Query = string.Format("SELECT PK_Codigo_Producto FROM TBL_Producto;"); // query
            getCampos(Query, cbo_materia);
            Query = string.Format("SELECT UnidadDeMedida FROM TBL_unidaddemedidabase;"); // query
            getCampos(Query, cbo_unidad);

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: cierre de formulario
             */
            if (anterior != null)
                anterior.Show();
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: minimiza el formulario
             */
            this.WindowState = FormWindowState.Minimized;
        }

        private void produccion_2102_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: obtiene HTML de ayuda
             */
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas_DLL/ayuda/ayuda.chm", "nueva_receta.html");
        }

        private void lbl_costo_total_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: 
             */

        }

        private void btn_eliminar_campo_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: 
             */

        }

        private void btn_agregar_campo_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: 
             */
            if (cbo_materia.SelectedIndex != -1 && txt_cantidad.Text != "" && cbo_unidad.SelectedIndex != -1)
            {
                dgv_materia.Rows.Add(cbo_materia.Text,txt_materia.Text,txt_cantidad.Text,cbo_unidad.Text);
            }

        }

        private void btn_salir_nav_Click(object sender, EventArgs e)
        {
            /* 
             * programador: Josue Roberto Ponciaco Del Cid
             * descripcion: cierre de formulario
             */
            if (anterior != null)
                anterior.Show();
            this.Close();
        }

        private void pnl_borde_superior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_productos.SelectedIndex != -1)
            {
                 /* 
                 * programador: Josue Roberto Ponciaco Del Cid
                 * descripcion: obtiene los campos de la tabla seleccionada
                 */
                string Query = string.Format("SELECT Descripcion_Producto FROM TBL_Producto WHERE PK_Codigo_Producto = " + cbo_productos.Text + " AND FK_Tipo_Producto = 1;"); // query
                getTexto(Query, txt_producto);
                toolTip1.SetToolTip(cbo_productos, txt_producto.Text);
            }
            else
            {
                txt_producto.Text = "";
            }
        }

        private void cbo_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_materia.SelectedIndex != -1)
            {
                /* 
                 * programador: Josue Roberto Ponciaco Del Cid
                 * descripcion: obtiene los campos de la tabla seleccionada
                 */
                string Query = string.Format("SELECT Descripcion_Producto FROM TBL_Producto WHERE PK_Codigo_Producto = " + cbo_materia.Text + " AND FK_Tipo_Producto = 1;"); // query
                getTexto(Query, txt_materia);
                toolTip1.SetToolTip(cbo_materia, txt_materia.Text);
            }
            else {
                txt_materia.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 & e.KeyChar < 58)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/chopes/Documents/Visual Studio 2015/Projects/Recetas_DLL/ayuda/ayuda.chm", "nueva_receta.html");
        }
    }
}
