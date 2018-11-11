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


        public static OdbcConnection getDB()
        {
            cnx = new OdbcConnection(Properties.Settings.Default.ruta);
            cnx.Open();
            return cnx;
        }


        public void ordenes(TextBox name)
        {
            string Query = string.Format("SELECT MAX(IDTBL_ORDEN_PRODUCCION) AS IDORDEN FROM TBL_ORDEN_PRODUCCION;");
            OdbcCommand cmd = new OdbcCommand(Query, ConexionBD.getDB());
            ConexionBD.getDB();
            OdbcDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                name.Text = reader["IDORDEN"].ToString();
            }
        }
    }
}
