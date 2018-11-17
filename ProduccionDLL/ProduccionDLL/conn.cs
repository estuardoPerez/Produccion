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
using System.Data.Odbc;
namespace ProduccionDLL
{

    public class conn
    {

        public static DataTable verCostesProduccion()
        {
            DataTable costeProduccion = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            OdbcDataAdapter verprocesoEnProceso = new OdbcDataAdapter("select * from TBL_ConceptosCosteProduccion", cnx);
            try

            {
                cnx.Open();
                verprocesoEnProceso.Fill(costeProduccion);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return costeProduccion;

        }//fin del metodo mostrar costes


        public static DataTable verCostesProduccionAscendente()
        {
            DataTable costeProduccion = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            OdbcDataAdapter verCostesDeProduccion = new OdbcDataAdapter("select * from TBL_ConceptosCosteProduccion order by costo_total ASC", cnx);
            try

            {
                cnx.Open();
                verCostesDeProduccion.Fill(costeProduccion);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return costeProduccion;

        }//fin del metodo mostrar costes ascendente

        public static DataTable verCostesProduccionDescendente()
        {
            DataTable costeProduccion = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            OdbcDataAdapter verCostesDeProduccionDesc = new OdbcDataAdapter("select * from TBL_ConceptosCosteProduccion order by costo_total DESC", cnx);
            try

            {
                cnx.Open();
                verCostesDeProduccionDesc.Fill(costeProduccion);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return costeProduccion;

        }//fin del metodo mostrar costes descendente


        public static DataTable verProductosTerminados()
        {
            DataTable productosTerminados = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            OdbcDataAdapter verProductosTerminados = new OdbcDataAdapter("select * from TBL_ConceptoProductosTerminados", cnx);
            try
            {
                cnx.Open();
                verProductosTerminados.Fill(productosTerminados);
                cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally { cnx.Close(); }
            return productosTerminados;

        }//fin del metodo mostrar ordenes de produccion



        public static DataTable verProcesoTerminado()
        {

            DataTable verProcesoTerminado = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            OdbcDataAdapter procesoTerminado = new OdbcDataAdapter("select * from TBL_ConceptoProduccionArea", cnx);

            try

            {
                cnx.Open();
                procesoTerminado.Fill(verProcesoTerminado);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return verProcesoTerminado;

        }//fin del metodo mostrar procesos terminados

        public static DataTable verProcesoPendiente()
        {
            DataTable procesoPendiente = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            OdbcDataAdapter verProcesoPendiente = new OdbcDataAdapter("select * from TBL_ConceptoProduccionArea", cnx);
            try

            {
                cnx.Open();
                verProcesoPendiente.Fill(procesoPendiente);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return procesoPendiente;

        }//fin del metodo mostrar procesos Sin empezar



        public static DataTable verProcesoEnProceso()

        {
            DataTable procesoEnProceso = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            OdbcDataAdapter verprocesoEnProceso = new OdbcDataAdapter("select * from TBL_ConceptoProduccionArea", cnx);
            try

            {
                cnx.Open();
                verprocesoEnProceso.Fill(procesoEnProceso);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return procesoEnProceso;

        }//fin del metodo mostrar procesos en proceso

        public static DataTable verConceptoDeProduccion()
        {
            DataTable conceptoDeProduccion = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            OdbcDataAdapter verConceptoProduccion = new OdbcDataAdapter("select * from TBL_ConceptoProduccionArea", cnx);
            try

            {
                cnx.Open();
                verConceptoProduccion.Fill(conceptoDeProduccion);
                cnx.Close();
            }

            catch (Exception r)

            {

                MessageBox.Show(r.Message);
            }

            finally { cnx.Close(); }
            return conceptoDeProduccion;

        }//fin del metodo mostrar concepto de produccion



        


    }// fin de la clase conn





}
