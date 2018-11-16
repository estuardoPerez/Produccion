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
using ConsultasInteligentes;

namespace RecursosHumanos
{
    public partial class _2602_Operaciones : Form
    {
        public _2602_Operaciones()
        {
            InitializeComponent();
            actualizar();
        }

        private void actualizar()//carga los datos de la tabla al datagrid
        {
            OdbcConnection conexion = CapaDatos.getDB();
            try
            {
                string sql = string.Format("SELECT idTBL_Operacion,Nombre_operacion,Descripcion from TBL_Operacion");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dgv_ingreso.Rows.Clear();
                while (reader.Read())
                {
                    dgv_ingreso.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
        }



        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void _2602_Operaciones_Load(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txt_idOpe.Text != "")//sirve para elmininar datos de la tabla
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    string sql = string.Format("DELETE FROM TBL_Operacion WHERE idTBL_Operacion = {0}", txt_idOpe.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    int ban = cmd.ExecuteNonQuery();
                    if (ban == 1)
                    {
                        MessageBox.Show("Operacion eliminada", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizar();
                    }
                    else
                        MessageBox.Show("Operacion no encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_idOpe.Text = "";
                    txt_idOpe.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Escriba una operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idOpe.Focus();
            }
        }

        private void dgv_ingreso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgv_ingreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idOpe.Text = this.dgv_ingreso.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_idOpe.Text!= "" && txtnom.Text != "" && txtdes.Text != "")//proceso que edita la tabla en si
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    txt_idOpe.ReadOnly = true;
                    string sql = string.Format("UPDATE TBL_Operacion SET Nombre_operacion = '{0}', Descripcion = '{1}'WHERE idTBL_Operacion = {2}", txtnom.Text, txtdes.Text,txt_idOpe.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_idOpe.Text = "";
                    txtnom.Text = "";
                    txtdes.Text = "";
                    actualizar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (txt_idOpe.Text != "" && txtnom.Text != "" && txtdes.Text != "")//ingresa campos a la tabla
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    string sql = string.Format("INSERT INTO TBL_Operacion VALUES({0}, '{1}','{2}'); ", txt_idOpe.Text, txtnom.Text, txtdes.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    txt_idOpe.Text = "";
                    txtnom.Text = "";
                    txtdes.Text = "";
                    MessageBox.Show("GUARDADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    actualizar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            String id_usuario = "1";
            String[] tablas = { " TBL_Proceso", "TBL_Insercion_empleado_proceso", "TBL_Receta_Detalle", "TBL_Operacion" };
            Consulta nuevo = new Consulta(id_usuario, tablas);
            nuevo.abrir();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "");
        }
    }
}
