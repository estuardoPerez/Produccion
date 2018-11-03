using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Implosion_y_Explosion_Materiales
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


    }
}
