using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace OrdenesProd
{
    class ConexionBD
    {
        static OdbcConnection cnx = null;
        OdbcCommand comando;
        OdbcDataAdapter da;

        public static OdbcConnection getDB()
        {
            try
            {
               cnx = new OdbcConnection("Dsn=colchoneria");
                cnx.Open();
                return cnx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
    


        public void ordenes(TextBox name)
        {
            string Query = string.Format("SELECT MAX(idTBL_Orden_Produccion) AS idOrden FROM TBL_Orden_Produccion;");
            OdbcCommand cmd = new OdbcCommand(Query, ConexionBD.getDB());
            ConexionBD.getDB();
            OdbcDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                name.Text = reader["idOrden"].ToString();
            }
        }

        public void detalle(TextBox name)
        {
            string Query = string.Format("SELECT MAX(idTBL_Orden_Detalle) AS idDetalle FROM TBL_Orden_Detalle;");
            OdbcCommand cmd = new OdbcCommand(Query, ConexionBD.getDB());
            ConexionBD.getDB();
            OdbcDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                name.Text = reader["idDetalle"].ToString();
            }
        }

        public void insertar(string query)
        {

            try
            {
                comando = new OdbcCommand();
                comando.Connection = cnx;

                comando.CommandText = query;
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos Insertados");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error:" + ex);
            }

        }

        public void llenarDGV(String sql, DataGridView dataGridView1)
        {
            getDB();
            try
            {
                comando = new OdbcCommand(sql, cnx);
                da = new OdbcDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el Datagridview" + ex.ToString());
            }
            //cerrar conexion
            getDB().Close();
        }
    }
}
