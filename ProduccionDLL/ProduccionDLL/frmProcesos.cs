using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace ProduccionDLL
{
    public partial class frmProcesos : Form
    {
        public frmProcesos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (comboBoxCosteEstadoProceso.Text == "")
            {
                MessageBox.Show("campo vacio ingrese un valor");
            }
            else if (comboBoxCosteEstadoProceso.Text == "Terminado")
            {
                dataGridEstadoProceso.DataSource = conn.verProcesoTerminado();
            }
            else if (comboBoxCosteEstadoProceso.Text == "En proceso")
            {
                dataGridEstadoProceso.DataSource = conn.verProcesoEnProceso();
            }
            else if (comboBoxCosteEstadoProceso.Text == "Pendiente")

            {
                dataGridEstadoProceso.DataSource = conn.verProcesoPendiente();
            }
        }
        private void Trm_tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        private void frmProcesos_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();

            MdiClient ctiMDI;
            foreach (Control cti in this.Controls)
            {
                try
                {
                    ctiMDI = (MdiClient)cti;
                    cti.BackColor = this.BackColor;

                }
                catch (InvalidCastException exc)
                {

                }
            }
        }

        private void frmProcesos_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:/Ayuda produccion/Manual de usuario.chm", "ayuda frmProductosTerminados.html");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable conceptoDeProduccion = new DataTable();
            OdbcConnection cnx = new OdbcConnection("Dsn=colchoneria");
            String update = "update TBL_ConceptoProduccionArea set estatus=" + comboBoxActualizar.Text + " where PK_ProduccionArea=" + text1.Text;
            OdbcDataAdapter verConceptoProduccion = new OdbcDataAdapter(update, cnx);
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

        }//fin del metodo mostrar concepto de produccion



            
        }
    }

