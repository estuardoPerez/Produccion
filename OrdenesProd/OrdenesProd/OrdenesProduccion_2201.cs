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
using CapaDiseno;

namespace OrdenesProd
{
    public partial class OrdenesProduccion_2201 : Form
    {
        ConexionBD connection = new ConexionBD();
        Navegador nv = new Navegador();
        private readonly object Txt_codigo;

        public OrdenesProduccion_2201()
        {
            InitializeComponent();
            llenarDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //new DatosOrdenes_2202(dataGridView1).Show();
            DatosOrdenes_2202 datosordenes = new DatosOrdenes_2202(dataGridView1);
            if (dataGridView1.CurrentRow == null)
                return;
            DataGridViewRow row = dataGridView1.CurrentRow;
            datosordenes.Txt_norden.Text = row.Cells[0].Value.ToString();
            datosordenes.Txt_encargado.Text = row.Cells[1].Value.ToString();
            datosordenes.Cmb_producto.Text = row.Cells[2].Value.ToString();
            datosordenes.Txt_cantidad.Text = row.Cells[3].Value.ToString();
            datosordenes.Txt_fechainicio.Text = row.Cells[4].Value.ToString();
            datosordenes.Cmb_prioridad.Text = row.Cells[5].Value.ToString();
            datosordenes.Txt_costo.Text = row.Cells[6].Value.ToString();
            datosordenes.Show();
         datosordenes.Txt_norden.ReadOnly = true;
        datosordenes.Txt_encargado.ReadOnly = true;
        datosordenes.Txt_fechainicio.ReadOnly = true;
        datosordenes.Txt_fechafin.ReadOnly = true;
        datosordenes.Txt_codigo.ReadOnly = true;
        datosordenes.Txt_costo.ReadOnly = true;
        datosordenes.Txt_cantidad.ReadOnly = true;
            datosordenes.Cmb_prioridad.Enabled = false;
            datosordenes.Cmb_avance.Enabled = false;
            datosordenes.Cmb_producto.Enabled = false;
        }




        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Ayudas/ordenes/ayudaGeneral.chm", "general.html");
        }

        /*llena el datagrid*/
        public void llenarDGV()
        {
            String query = "SELECT TBL_Orden_Produccion.idTBL_Orden_Produccion as 'No. Orden',TBL_Orden_Produccion.Creador_orden as 'Encargado',TBL_Producto.Descripcion_Producto as 'Producto',TBL_Orden_Detalle.cantidad_prod as'Cantidad Producto',TBL_Orden_Produccion.Fecha_Inicio as 'Fecha de Inicio',TBL_Prioridad.descripcion_Prioridad as 'Prioridad',TBL_Orden_Detalle.costoTotal as 'Costo Producto' from TBL_Orden_Produccion inner join TBL_Prioridad on TBL_Prioridad.idTBL_Prioridad = TBL_Orden_Produccion.TBL_Prioridad_idTBL_Prioridad inner join TBL_Orden_Detalle on TBL_Orden_Detalle.TBL_Orden_Produccion_idTBL_Orden_Produccion = TBL_Orden_Produccion.idTBL_Orden_Produccion inner join TBL_Producto on TBL_Orden_Detalle.TBL_Producto_PK_Codigo_Producto = TBL_Producto.PK_Codigo_Producto; ";
            connection.llenarDGV(query, dataGridView1);
        }

        private void Btn_nueva_Click(object sender, EventArgs e)
        {
            new DatosOrdenes_2202(dataGridView1).Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
