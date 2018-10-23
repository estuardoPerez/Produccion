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

namespace Ordenes_Producción
{
    public partial class Productos_2250 : Form
    {
        

        public Productos_2250()
        {
            InitializeComponent();
            llenar_dgv();
            
        }

           //LLENAR EL DATAGRID CON DATOS DE LA BD
        public void llenar_dgv()
        {
            OdbcConnection connection = ConexionBD.getDB();
            try
            {
                string Query = string.Format("SELECT IDTBL_PRODUCTO as CODIGO ,DESCRIPCION_PRODUCTO AS DESCRIPCION,EXISTENCIA_PRODUCTO as EXISTENCIA FROM TBL_PRODUCTO;");
                OdbcCommand cmd = new OdbcCommand(Query, connection);

                OdbcDataAdapter adpter = new OdbcDataAdapter();
                adpter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                adpter.Fill(dTable);
                Dgv_producto.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void Productos_2250_Load(object sender, EventArgs e)
        {
        }

        private void Productos_2250_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Dgv_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DatosGenerales_2202 datosgenerales = new DatosGenerales_2202();
            if (Dgv_producto.CurrentRow == null)
                return;

            DataGridViewRow row = Dgv_producto.CurrentRow;

            datosgenerales.textBox6.Text = row.Cells[0].Value.ToString();
            datosgenerales.textBox3.Text = row.Cells[1].Value.ToString();

            datosgenerales.Show();
            this.Hide();
        }
    }
}
