using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultasInteligentes;

namespace RecursosHumanos
{
    public partial class _2603_Proceso : Form
    {
        public _2603_Proceso()
        {
            InitializeComponent();
            actualizar();
            Receta_designada();
        }

        public void Receta_designada()
        {
            OdbcConnection conecction = CapaDatos.getDB();
            try
            {
                string Query = string.Format("SELECT PK_Receta_Detalle FROM TBL_Receta_Detalle;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                cmbRec.SelectedIndex = -1;
                cmbRec.Items.Clear();
                while (reader.Read())
                {
                    cmbRec.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        private void actualizar()//carga los datos de la tabla al datagrid
        {
            OdbcConnection conexion = CapaDatos.getDB();
            try
            {
                string sql = string.Format("SELECT idTBL_Proceso, TBL_Operacion_idTBL_Operacion,Nombre_proceso,Descripcion,pk_id_receta_materia from TBL_Proceso");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dgv_ingreso.Rows.Clear();
                while (reader.Read())
                {
                    dgv_ingreso.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2),reader.GetString(3),reader.GetString(4));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
        }


        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (txt_idProc.Text != "" && txtid.Text!="" && txtnom.Text != "" && txtdes.Text != "" && cmbRec.Text!="" )//ingresa campos a la tabla
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    string sql = string.Format("INSERT INTO TBL_Proceso VALUES({0}, {1},'{2}','{3}',{4},NULL); ", txt_idProc.Text, txtid.Text, txtnom.Text, txtdes.Text, cmbRec.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    txt_idProc.Text = "";
                    txtid.Text = "";
                    txtnom.Text = "";
                    txtdes.Text = "";
                    cmbRec.SelectedIndex = -1;
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

        private void dgv_ingreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idProc.Text = this.dgv_ingreso.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_idProc.Text != "" && txtnom.Text != "" && txtdes.Text != "" && cmbRec.Text != "")//proceso que edita la tabla en si
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    string sql = string.Format("UPDATE TBL_Proceso SET TBL_Operacion_idTBL_Operacion = {0}, Nombre_proceso= '{1}', Descripcion='{2}', pk_id_receta_materia={3} WHERE idTBL_Proceso = {4}", txtid.Text, txtnom.Text, txtdes.Text, cmbRec.Text, txt_idProc.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtid.Text = ""; 
                    txt_idProc.Text = "";
                    txtnom.Text = "";
                    txtdes.Text = "";
                    cmbRec.SelectedIndex = -1;
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

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txt_idProc.Text != "")//sirve para elmininar datos de la tabla
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    string sql = string.Format("DELETE FROM TBL_Proceso WHERE idTBL_Proceso = {0}", txt_idProc.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    int ban = cmd.ExecuteNonQuery();
                    if (ban == 1)
                    {
                        MessageBox.Show("Proceso eliminado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizar();
                    }
                    else
                        MessageBox.Show("Proceso no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_idProc.Text = "";
                    txt_idProc.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Escriba un proceso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idProc.Focus();
            }
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
