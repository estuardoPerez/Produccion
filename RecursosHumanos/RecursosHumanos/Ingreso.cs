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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            Id();
            Estado_emp();
            Estado_proc();
            Empleado();
            actualizar();
            Procesos();
        }

        private void actualizar()//carga los datos de la tabla al datagrid
        {
            OdbcConnection conexion = CapaDatos.getDB();
            try
            {
                string sql = string.Format("SELECT TBL_Empleado_idTBL_Empleado, TBL_Estado_proceso_idTBL_Estado_proceso, TBL_Estado_idTBL_Estado, TBL_Proceso_idTBL_Proceso, Fecha_inicio, Fecha_final_contemplada from TBL_Insercion_empleado_proceso;");
                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                OdbcDataReader reader = cmd.ExecuteReader();
                dgv_ingreso.Rows.Clear();
                while (reader.Read())
                {
                    dgv_ingreso.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexion.Close();
        }

        public void Id()//carga el ID del empleado al combobox
        {
            OdbcConnection conecction = CapaDatos.getDB();
            try
            {
                string Query = string.Format("SELECT ID_Empleado FROM tbl_empleados;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_Area.SelectedIndex = -1;
                Cmb_Area.Items.Clear();
                while (reader.Read())
                {
                    Cmb_Area.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        public void Empleado()//carga a un textbox el nombre seleccionado desde el combobox
        {
            if (Cmb_Area.SelectedIndex!=-1) {
                OdbcConnection conecction = CapaDatos.getDB();
                try
                {
                    string Query = string.Format("SELECT Nombre FROM tbl_empleados WHERE ID_Empleado= {0};", Cmb_Area.Text);
                    OdbcCommand cmd = new OdbcCommand(Query, conecction);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_InNom.Text = reader.GetString(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conecction.Close();
            }
          
        }

        public void Empleado_()//carga el appelido a un textbox desde la eleccion del combobox
        {
            if (Cmb_Area.SelectedIndex != -1)
            {
                OdbcConnection conecction = CapaDatos.getDB();
                try
                {
                    string Query = string.Format("SELECT Apellido FROM tbl_empleados WHERE ID_Empleado={0};", Cmb_Area.Text);
                    OdbcCommand cmd = new OdbcCommand(Query, conecction);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_InAp.Text = reader.GetString(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conecction.Close();
            }
        }

        public void Estado_proc()//carga el id del estado del proceso a un combobox
        {
            OdbcConnection conecction = CapaDatos.getDB();
            try
            {
                string Query = string.Format("SELECT idTBL_Estado_proceso FROM TBL_Estado_proceso;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                cmbProc.SelectedIndex = -1;
                cmbProc.Items.Clear();
                while (reader.Read())
                {
                    cmbProc.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        public void proceso_()//carga el proceso de eleccion del combobox
        {
            if (Cmb_Area.SelectedIndex != -1)
            {
                OdbcConnection conecction = CapaDatos.getDB();
                try
                {
                    string Query = string.Format("SELECT Nombre FROM TBL_Estado_proceso WHERE idTBL_Estado_proceso={0};", cmbProc.Text);
                    OdbcCommand cmd = new OdbcCommand(Query, conecction);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtproc.Text = reader.GetString(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conecction.Close();
            }
        }

        public void Estado_emp()//carga el id del estado del empleado a un combobox
        {
            OdbcConnection conecction = CapaDatos.getDB();
            try
            {
                string Query = string.Format("SELECT idTBL_Estado FROM TBL_Estado_empleado");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                cmbEst.SelectedIndex = -1;
                cmbEst.Items.Clear();
                while (reader.Read())
                {
                    cmbEst.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        public void empleado_()//carga el proceso de eleccion del combobox
        {
            if (Cmb_Area.SelectedIndex != -1)
            {
                OdbcConnection conecction = CapaDatos.getDB();
                try
                {
                    string Query = string.Format("SELECT Descripcion FROM TBL_Estado_empleado WHERE idTBL_Estado={0};", cmbEst.Text);
                    OdbcCommand cmd = new OdbcCommand(Query, conecction);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtemp.Text = reader.GetString(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conecction.Close();
            }
        }

        public void Procesos()//carga el ID del empleado al combobox
        {
            OdbcConnection conecction = CapaDatos.getDB();
            try
            {
                string Query = string.Format("SELECT idTBL_Proceso FROM TBL_Proceso;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                cmbP.SelectedIndex = -1;
                cmbP.Items.Clear();
                while (reader.Read())
                {
                    cmbP.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }

        public void Procesos_()//carga el proceso de eleccion del combobox
        {
            if (Cmb_Area.SelectedIndex != -1)
            {
                OdbcConnection conecction = CapaDatos.getDB();
                try
                {
                    string Query = string.Format("SELECT Nombre_proceso FROM TBL_Proceso WHERE idTBL_Proceso={0};", cmbP.Text);
                    OdbcCommand cmd = new OdbcCommand(Query, conecction);
                    OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtproce.Text = reader.GetString(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conecction.Close();
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_InNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            proceso_();
        }

        private void Cmb_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleado();
            Empleado_();
        }

        private void cmbEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            empleado_();
        }

        private void dgv_ingreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           Cmb_Area.Text= this.dgv_ingreso.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_ingreso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (Cmb_Area.Text != "" && cmbProc.Text != "" && cmbEst.Text != "" && cmbP.Text!="" && dtp_inicio.Text != "" && dtp_final.Text != "")//ingresa campos a la tabla
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    string sql = string.Format("INSERT INTO TBL_Insercion_empleado_proceso VALUES({0},{1},{2},{3},'{4}','{5}'); ", Cmb_Area.Text, cmbProc.Text, cmbEst.Text, cmbP.Text,dtp_inicio.Text, dtp_final.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    Cmb_Area.SelectedIndex = -1;
                    txtemp.Text = "";
                    txtproc.Text = "";
                    txtproce.Text = "";
                    txt_InAp.Text = "";
                    txt_InNom.Text = "";
                    cmbProc.SelectedIndex = -1;
                    cmbEst.SelectedIndex = -1;
                    cmbP.SelectedIndex = -1;
                    dtp_inicio.Text = "";
                    dtp_final.Text = "";
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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
        if (Cmb_Area.Text != "" && cmbProc.Text != "" && cmbEst.Text != "" && cmbP.Text != "" && dtp_inicio.Text != "" && dtp_final.Text != "")//proceso que edita la tabla en si
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    string sql = string.Format("UPDATE  TBL_Insercion_empleado_proceso SET  TBL_Estado_proceso_idTBL_Estado_proceso ={0}, TBL_Estado_idTBL_Estado = {1}, TBL_Proceso_idTBL_Proceso = {2} ,Fecha_inicio = '{3}',Fecha_final_contemplada= '{4}'WHERE TBL_Empleado_idTBL_Empleado ={5}",cmbProc.Text, cmbEst.Text, cmbP.Text, dtp_inicio.Text, dtp_final.Text, Cmb_Area.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbProc.SelectedIndex = -1;
                    cmbEst.SelectedIndex = -1;
                    cmbP.SelectedIndex = -1;
                    txtemp.Text = "";
                    txtproc.Text = "";
                    txtproce.Text = "";
                    txt_InAp.Text = "";
                    txt_InNom.Text = "";
                    Cmb_Area.SelectedIndex = -1;
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
            if (Cmb_Area.Text != "")//sirve para elmininar datos de la tabla
            {
                OdbcConnection conexion = CapaDatos.getDB();
                try
                {
                    string sql = string.Format("DELETE FROM  TBL_Insercion_empleado_proceso WHERE TBL_Empleado_idTBL_Empleado = {0}", Cmb_Area.Text);
                    OdbcCommand cmd = new OdbcCommand(sql, conexion);
                    int ban = cmd.ExecuteNonQuery();
                    if (ban == 1)
                    {
                        MessageBox.Show("Ingreso eliminado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actualizar();
                        Cmb_Area.SelectedIndex = -1;
                        txtemp.Text = "";
                        txtproc.Text = "";
                        txtproce.Text = "";
                        txt_InAp.Text = "";
                        txt_InNom.Text = "";
                    }
                    else
                        MessageBox.Show("Ingreso no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cmb_Area.SelectedIndex = -1;
                    Cmb_Area.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un Ingreso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_Area.Focus();
            }
        }

        private void cmbP_SelectedIndexChanged(object sender, EventArgs e)
        {
            Procesos_();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            String id_usuario = "1";
            String[] tablas = { " TBL_Proceso", "TBL_Insercion_empleado_proceso", "TBL_Receta_Detalle","TBL_Operacion" };
            Consulta nuevo = new Consulta(id_usuario, tablas);
            nuevo.abrir();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"");
        }
    }
}
