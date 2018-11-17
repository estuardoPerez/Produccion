using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using System.Data.Odbc;
using DLL__Reporteador;
/*AUTOR: ESTUARDO PÉREZ*
 * 
 * TENER LA AYUDA EN DISCO LOCAL C PARA VISUALIZARLA*/

namespace OrdenesProd
{
    public partial class DatosOrdenes_2202 : Form
    {
        Navegador nv = new Navegador();
        ConexionBD connection = new ConexionBD();
        Validacion v = new Validacion();


        int contador;
        int contadordet;
        int cont;
        int contd;

        public DatosOrdenes_2202(DataGridView dataGridView1)
        {
            InitializeComponent();
            producto();
            prioridad();
            estado();

            connection.ordenes(Txt_norden);

            if (Txt_norden.Text == "")
            {

                Txt_norden.Text = "100";
            }
            else
            {
                contador = Convert.ToInt32(Txt_norden.Text);
                contador = contador + 1;
                Txt_norden.Text = contador.ToString();
            }

            connection.detalle(Txt_iddetalle);

            if (Txt_iddetalle.Text == "")
            {
                Txt_iddetalle.Text = "10";
            }
            else
            {
                contadordet = Convert.ToInt32(Txt_iddetalle.Text);
                contadordet = contadordet + 1;
                Txt_iddetalle.Text = contadordet.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txt_encargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
        }

        private void Txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Ayudas/ordenes/ayudaGeneral.chm", "general2.html");
        }

        //LLENADO DE COMBOBOX PRIORIDAD
        public void prioridad()
        {
            OdbcConnection conecction = ConexionBD.getDB();
            try
            {
                string Query = string.Format("SELECT descripcion_Prioridad FROM TBL_Prioridad;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_prioridad.SelectedIndex = -1;
                Cmb_prioridad.Items.Clear();
                while (reader.Read())
                {
                    Cmb_prioridad.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conecction.Close();
        }
        //LLENADO DE COMBOBOX PRODUCTO
        public void producto()
        {
            OdbcConnection conecction = ConexionBD.getDB();
            try
            {
                string Query = string.Format("SELECT Descripcion_Producto FROM TBL_Producto;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_producto.SelectedIndex = -1;
                Cmb_producto.Items.Clear();
                while (reader.Read())
                {
                    Cmb_producto.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conecction.Close();
        }

        //LLENADO DE COMBOBOX ESTADO AVANCE
        public void estado()
        {
            OdbcConnection conecction = ConexionBD.getDB();
            try
            {
                string Query = string.Format("SELECT Estado_Avance FROM TBL_Estado_Avance;");
                OdbcCommand cmd = new OdbcCommand(Query, conecction);
                OdbcDataReader reader = cmd.ExecuteReader();
                Cmb_avance.SelectedIndex = -1;
                Cmb_avance.Items.Clear();
                while (reader.Read())
                {
                    Cmb_avance.Items.Add(reader.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conecction.Close();
        }

        //LLENADO AUTOMATICO DEL CODIGO PRODUCTO Y COSTO PRODUCTO AL ELEGEIR UN PRODUCTO DEL COMBOBOX
        private void Cmb_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection conectar = ConexionBD.getDB();

            try
            {
                string query = string.Format("SELECT * FROM TBL_Producto WHERE Descripcion_Producto ='" + Cmb_producto.Text + "'");
                OdbcCommand cmd = new OdbcCommand(query, conectar);
                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {

                    Txt_codigo.Text = reader["PK_Codigo_Producto"].ToString();
                    Txt_costo.Text = reader["costo"].ToString();

                }
                else
                {
                    Txt_codigo.Text = "";
                    Txt_costo.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dtp_inicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechainicio = Dtp_inicio.Value;
            Txt_fechainicio.Text = fechainicio.ToString();
        }

        //LLENADO AUTOMATICO DEL ID DE PRIORIDAD EN EL TXT
        private void Cmb_prioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection conectar = ConexionBD.getDB();

            try
            {
                string query = string.Format("SELECT * FROM TBL_Prioridad WHERE descripcion_Prioridad ='" + Cmb_prioridad.Text + "'");
                OdbcCommand cmd = new OdbcCommand(query, conectar);
                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    Txt_idprioridad.Text = reader["idTBL_Prioridad"].ToString();
                }
                else
                {
                    Txt_idprioridad.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //LLENADO AUTOMATICO  DEL ID DE AVANCE EN EL TXT
        private void Cmb_avance_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection conectar = ConexionBD.getDB();

            try
            {
                string query = string.Format("SELECT * FROM TBL_Estado_Avance WHERE Estado_Avance ='" + Cmb_avance.Text + "'");
                OdbcCommand cmd = new OdbcCommand(query, conectar);
                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    Txt_idavance.Text = reader["idTBL_Estado_Avance"].ToString();
                }
                else
                {
                    Txt_idavance.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dtp_fin_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechafin = Dtp_fin.Value;
            Txt_fechafin.Text = fechafin.ToString();
        }

        //INSERTAR DATOS
        int id;
        int codigo;
        int cantidad;
        private void INSERTAR_Click(object sender, EventArgs e)
        {
            int orden = Convert.ToInt32(Txt_norden.Text);
            string creador = Txt_encargado.Text;
            int prioridad = Convert.ToInt32(Txt_idprioridad.Text);
            int estado = Convert.ToInt32(Txt_idavance.Text);

            String año, mes, dia, fechainicio;
            año = Dtp_inicio.Value.Year.ToString();
            mes = Dtp_inicio.Value.Month.ToString();
            dia = Dtp_inicio.Value.Day.ToString();
            fechainicio = año + "/" + mes + "/" + dia;

            String añof, mesf, diaf, fechafin;
            añof = Dtp_fin.Value.Year.ToString();
            mesf = Dtp_fin.Value.Month.ToString();
            diaf = Dtp_fin.Value.Day.ToString();
            fechafin = añof + "/" + mesf + "/" + diaf;


            string query = "INSERT INTO TBL_Orden_Produccion (idTBL_Orden_Produccion,Creador_orden,Fecha_inicio,Fecha_finalizacion,TBL_Prioridad_idTBL_Prioridad,TBL_Estado_Avance_idTBL_Estado_Avance) " +
                   "values (" + orden + ",'" + creador + "','" + fechainicio + "','" + fechafin + "'," + prioridad + "," + estado + ")";

            connection.insertar(query);
            //MessageBox.Show("Datos ingresados correctamente");



            id = int.Parse(Txt_norden.Text);
            codigo = int.Parse(Txt_codigo.Text);
            cantidad = int.Parse(Txt_cantidad.Text);
            Dgv_prod.Rows.Add(id, codigo, cantidad);
        }

        //GUARDAR DATOS
        private void GUARDAR_Click(object sender, EventArgs e)
        {
            int codigodetalle = Convert.ToInt32(Txt_iddetalle.Text);
            int orden = Convert.ToInt32(Txt_norden.Text);
            int idproducto = Convert.ToInt32(Txt_codigo.Text);
            int cantidad = Convert.ToInt32(Txt_cantidad.Text);
            int costo = Convert.ToInt32(Txt_costo.Text);


            string query = "INSERT INTO TBL_Orden_Detalle (idTBL_Orden_Detalle,TBL_Orden_Produccion_idTBL_Orden_Produccion,TBL_Producto_PK_Codigo_Producto,Cantidad_prod,costoTotal) " +
                   "values (" + codigodetalle + "," + orden + "," + idproducto + "," + cantidad + "," + costo + ")";

            connection.insertar(query);
            MessageBox.Show("Datos ingresados correctamente");

            Txt_cantidad.Text = "";
            Txt_codigo.Text = "";
            Txt_encargado.Text = "";
            Txt_fechafin.Text = "";
            Txt_fechainicio.Text = "";
            Txt_idavance.Text = "";
            Txt_iddetalle.Text = "";
            Txt_idprioridad.Text = "";
            Txt_norden.Text = "";
            Cmb_avance.Text = "";
            Cmb_prioridad.Text = "";
            Cmb_producto.Text = "";

            connection.ordenes(Txt_norden);


            if (Txt_norden.Text == "")
            {

                Txt_norden.Text = "100";
            }
            else
            {

                cont = Convert.ToInt32(Txt_norden.Text);
                cont = cont + 1;
                Txt_norden.Text = cont.ToString();
            }
            connection.detalle(Txt_iddetalle);
            if (Txt_iddetalle.Text == "")
            {

                Txt_iddetalle.Text = "10";
            }
            else
            {

                contd = Convert.ToInt32(Txt_iddetalle.Text);
                contd = contd + 1;
                Txt_iddetalle.Text = contd.ToString();
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
        
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            Visualizador reporte = new Visualizador();
            reporte.AbrirReporte(2201);
        }

        //LIMPIAR DATOS DEL FORM
        private void button2_Click(object sender, EventArgs e)
        {
            Txt_cantidad.Text = Txt_codigo.Text = Txt_fechainicio.Text = Txt_costo.Text = Txt_fechafin.Text = Txt_idavance.Text = Txt_idprioridad.Text = Txt_iddetalle.Text = Txt_encargado.Text = "";
            Cmb_producto.SelectedIndex = -1;
            Cmb_avance.SelectedIndex = -1;
            Cmb_prioridad.SelectedIndex = -1;
            Dgv_prod.Rows.Clear();
        }
    }
}
