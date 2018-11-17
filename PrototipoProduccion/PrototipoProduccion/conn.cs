using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PrototipoProduccion
{
    public class conn
    {

        public static void ProbarConexion()
        {
            MySqlConnection cnx = new MySqlConnection("server = 127.0.0.1; database=producciones Uid=root; pwd=abc123**");

            try

            {
                cnx.Open();
                MessageBox.Show("conectado");
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
        }// fin del metodo probar conexión


        public static DataTable verOrdenes() {
            DataTable ordenes = new DataTable();
            MySqlConnection cnx = new MySqlConnection("server = 127.0.0.1; database=producciones Uid=root; pwd=abc123**");
            MySqlDataAdapter verorden = new MySqlDataAdapter("select * from TBL_ConceptoProducciónArea", cnx);
            try

            {
                cnx.Open();
                verorden.Fill(ordenes);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return ordenes;

        }//fin del metodo mostrar ordenes



        public static DataTable verCostesProduccion()
        {
            DataTable costeProduccion = new DataTable();
            MySqlConnection cnx = new MySqlConnection("server = 127.0.0.1; database=producciones Uid=root; pwd=abc123**");
            MySqlDataAdapter verorden = new MySqlDataAdapter("select * from TBL_ConceptoCostoProduccionGeneral", cnx);
            try

            {
                cnx.Open();
                verorden.Fill(costeProduccion);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return costeProduccion;

        }//fin del metodo mostrar costes


        public static DataTable verProductosTerminados()
        {
            DataTable productosTerminados = new DataTable();
            MySqlConnection cnx = new MySqlConnection("server = 127.0.0.1; database=producciones Uid=root; pwd=abc123**");
            MySqlDataAdapter verorden = new MySqlDataAdapter("select * from TBL_ConceptoCostoProduccionGeneral", cnx);
            try

            {
                cnx.Open();
                verorden.Fill(productosTerminados);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return productosTerminados;

        }//fin del metodo mostrar ordenes




    }// fin de la clase conn

}// fin del namespace



