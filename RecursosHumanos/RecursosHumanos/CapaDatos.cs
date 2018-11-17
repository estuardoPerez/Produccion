using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos
{
    class CapaDatos
    {
        public static OdbcConnection getDB()
        {
            OdbcConnection cnx = new OdbcConnection(Properties.Settings.Default.ruta);
            cnx.Open();
            return cnx;
        }
    }
}
