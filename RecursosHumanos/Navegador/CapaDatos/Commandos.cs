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
        OdbcTransaction transaction = null;
        public void pubInsertData(string sParametro)
        {
            try
            {
                var resultado = nuevo.ObtenerConexion();
                OdbcTransaction transaction = resultado.Item2;
                OdbcCommand cmd = resultado.Item1.CreateCommand();
                cmd.Transaction = transaction;

                cmd.CommandText = sParametro;
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al realizar esta accíon " + ex);
                try
                {
                    transaction.Rollback();
                    Console.WriteLine("Se realizo Rollback");
                }
                catch (Exception)
                {
                    Console.WriteLine("no se pudo realizar Rollback");
                }
            }
        }

        public DataTable pubSeleccionarData(string sParametro)
        {
            var resultado = nuevo2.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand comando = new OdbcCommand(sParametro, resultado.Item1);
            comando.Transaction = transaction;
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            try
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, tabla inexistente");
                return null;
            }
        }

        public DataTable pubSeleccionarCampos(string sParametro)
        {
            var resultado = nuevo3.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand comando = new OdbcCommand(sParametro, resultado.Item1);
            comando.Transaction = transaction;
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            try
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, Campos inexistentes");
                return null;
            }
        }

        public DataSet pubObtenerDatos(string sParametro, string campo)
        {
            var resultado = nuevo4.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand comando = new OdbcCommand(sParametro, resultado.Item1);
            comando.Transaction = transaction;
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            try
            {
                DataSet tabla = new DataSet();
                adaptador.Fill(tabla, campo);
                return tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, Campos inexistentes para combobox");
                return null;
            }
        }
    }
}
