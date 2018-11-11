using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Commandos
    {
        Conexion nuevo = new Conexion();
        Conexion nuevo2 = new Conexion();
        Conexion nuevo3 = new Conexion();
        Conexion nuevo4 = new Conexion();
        public void pubInsertData(string sParametro)
        {
            try
            {
                OdbcCommand cmd = nuevo.ObtenerConexion().CreateCommand();
                cmd.CommandText = sParametro;
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                MessageBox.Show("Error al realizar esta accíon"+e);
            }
        }

        public DataTable pubSeleccionarData(string sParametro)
        {
            OdbcCommand comando = new OdbcCommand(sParametro,nuevo2.ObtenerConexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            try
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Error, tabla inexistente");
                return null;
            }
        }

        public DataTable pubSeleccionarCampos(string sParametro)
        {
            OdbcCommand comando = new OdbcCommand(sParametro, nuevo3.ObtenerConexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public DataSet pubObtenerDatos(string sParametro, string campo)
        {
            OdbcCommand comando = new OdbcCommand(sParametro, nuevo4.ObtenerConexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            DataSet tabla = new DataSet();
            adaptador.Fill(tabla,campo);
            return tabla;
        }
    }
}
