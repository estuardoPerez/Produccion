﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using CapaLogica;
using DLL__Reporteador;
using ConsultasInteligentes;
using BITACORA;

namespace CapaDiseno
{
    public partial class Navegador : UserControl
    {

        private int sBanIngresar = 0;
        private int nControl;
        static int cantidadCampos = 0;
        static int cantidadAcciones = 0;
        static string tabla;
        static string estado;
        static string[] camposTabla;
        static bool existEstatus = false;
        Logica lo = new Logica();
        Flechas fle = new Flechas();

        //Ayuda nombre CHM
        string sNombrechm;
        [Description("Nombre de la Forma")]
        [DisplayName("Nombre CHM")]
        [Category("Objeto Navegador")]
        public string pubNombrechm
        {
            get { return sNombrechm; }
            set { sNombrechm = value; }
        }

        string sNombrehtml;
        [Description("Nombre de la Forma")]
        [DisplayName("Nombre HTML")]
        [Category("Objeto Navegador")]
        public string pubNombreHtml
        {
            get { return sNombrehtml; }
            set { sNombrehtml = value; }
        }

        //PEDIR NOMBRE DE LA FORMA
        static Form forma;
        [Description("Nombre de la Forma")]
        [DisplayName("Form")]
        [Category("Objeto Navegador")]
        public Form Forma
        {
            get { return forma; }
            set { forma = value; }
        }

        //PEDIR NOMBRE DE LOS PROCEDIMIENTOS--------------------------------RAMAS-----
        // comentario....
        string procedimiento;
        [Description("Nombre del Procedimiento")]
        [DisplayName("Procedimiento")]
        [Category("Objeto Navegador")]
        public string Procedimiento
        {
            get { return procedimiento; }
            set { procedimiento = value; }
        }

        //DATAGRID----------------------------------------------------------------
        static DataGridView dataGr;
        [Description("Nombre del DataGridView")]
        [DisplayName("DataGridView")]
        [Category("Objeto Navegador")]
        public DataGridView DataGr
        {
            get { return dataGr; }
            set { dataGr = value; }
        }

        ///private string[] list;
        public Navegador()
        {
            InitializeComponent();
            Btn_guardar.Enabled = false;
            Btn_cancelar.Enabled = false;
        }
        public void nombreForm(Form fm)
        {
            forma = fm;
        }

        public void deshabilitarComponentes()
        {
            foreach (Control componente in forma.Controls)
            {
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    componente.Enabled = false;
                }
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            if (forma.CanSelect)
            {
                Help.ShowHelp(this, "C:\\Ayuda\\" + sNombrechm, sNombrehtml);
                //MessageBox.Show(sNombrechm);
            }
        }
        public void dgv_datos(DataGridView aux)
        {
            dataGr = aux;
            this.cargarCampos();
        }
        static int x = 0, y=0;
        static string[] tablas= new string[100];
        static TextBox[,] camposT= new TextBox[100,100];
        static int banderaOtras=0;
        
        public void otrasTablas(string tbl, params TextBox[] cmps)
        {
            banderaOtras = 1;
            tablas[x] = tbl;
            y = cmps.Length;
           // MessageBox.Show("cantidad: " + y);
            for(int i=0; i<cmps.Length; i++)
            {
               // MessageBox.Show("Texto: " + x +" "+cmps[i].Name);
                camposT[x,i] = cmps[i];
            }
            x++;    
        }

        public void ingresarTabla(string table)
        {
            cantidadCampos = 0;
            tabla = table;
            List<string> camposTabla2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(tabla);
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTabla2.Add(table2.Rows[i][0].ToString());
            }
            camposTabla = camposTabla2.ToArray();
            for (int i = 0; i < camposTabla.Length; i++)
            {
                if (camposTabla[i].Equals("estatus"))
                {
                    existEstatus = true;
                    cantidadCampos = camposTabla.Length - 1;
                }
                else
                {
                    cantidadCampos = camposTabla.Length;
                }
            }
            deshabilitarComponentes();
        }

        private void priInsertar()
        {
            List<string> campos = new List<string>();
            sBanIngresar = 1;
            lo.insertar(tabla, camposTabla);
            bool verificarIngreso = true;
            int j = 0, auxI;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = componente.Tag.ToString();
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                       // MessageBox.Show("Numeros: " + auxI);
                        campos.Add("");
                        j++;
                    }
                }
            }
            nControl = j;
            string[] arrayCampos = campos.ToArray();
            
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux =  componente.Tag.ToString();
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        try
                        {
                            if (componente is DateTimePicker)
                            {


                                string num = componente.Tag.ToString();
                                int numero = Convert.ToInt32(num) - 1;

                                string fecha = componente.Text;
                                string dia = fecha.Substring(0, fecha.IndexOf('/'));
                                string complemento = fecha.Substring((fecha.IndexOf('/')+1), 7);
                                string mes = complemento.Substring(0, complemento.IndexOf('/'));
                                string resto = complemento.Substring((complemento.IndexOf('/') + 1), (complemento.Length - 3));
                                string anio = resto.Substring(0, resto.Length);

                                if(dia.Length == 1)
                                {
                                    dia = "0" + dia;
                                }
                                string fechaFinal = anio + mes + dia;
                                arrayCampos[numero] = fechaFinal;
                                componente.Text = "";
                            }
                            else
                            {

                                string num = componente.Tag.ToString();
                                int numero = Convert.ToInt32(num) - 1;
                                Console.WriteLine("tagI: " + componente.Name + num);
                                arrayCampos[numero] = componente.Text;
                                componente.Text = "";

                            }
                        }
                        catch (Exception)
                        {
                            verificarIngreso = false;
                            MessageBox.Show("No se ha ingresado el Tag del elemento " + componente.Name);
                        }
                    }
                }
            }

            for (int i = 0; i < arrayCampos.Length; i++)
            {
                lo.insertarCampos(arrayCampos[i]);
                arrayCampos[i] = "";
                //MessageBox.Show("Tamaño: "+arrayCampos.Length);
            }

            if (verificarIngreso)
            {
                if (existEstatus)
                {
                    lo.terminarSentencia();
                }
                else
                {
                    lo.terminarSentenciaSinEstatus();
                }
            }
        }
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            int j = 0;
            sBanIngresar = 1;
            Btn_ingresar.Enabled = false;
            foreach (Control componente in forma.Controls)
            { 
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    componente.Text = "";
                    componente.Enabled = true;
                    j++;
                }
            }
            nControl = j;
                estado = "insertar";
                Btn_guardar.Enabled = true;
                Btn_cancelar.Enabled = true;

                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = false;
                Btn_imprimir.Enabled = false;
                Btn_refrescar.Enabled = false;
                Btn_inicio.Enabled = false;
                Btn_anterior.Enabled = false;
                Btn_siguiente.Enabled = false;
                Btn_final.Enabled = false;
        }

        private void priGuardar()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            sBanIngresar = 0;
            try
            {
                lo.pubInsertarDatos();
                if (cantidadAcciones == 1)
                {
                    MessageBox.Show("Guardado Exitosamente");
                }
                cantidadAcciones++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void priSentenciaOtras(string tbl, params string[] cmps)
        {
             string sql=sentenciaInsertar(tbl, cmps);
                    lo.ejecutarQuery(sql);
        }
        private void priGuardarOtras()
        {
            if (banderaOtras == 1)
            {
                for (int i = 0; i <x; i++)          //filas
                {
                    String[] cmpss = new String[y];
                    for (int ii=0; ii<y; ii++)         //columnas
                    {
                        if ((camposT[i, ii] != null) && (!camposT[i, ii].Equals("")))
                        {
                            cmpss[ii] = camposT[i, ii].Text;
                        }   
                    }
                    if (!cmpss[0].Equals("")){
                        priSentenciaOtras(tablas[i], cmpss);
                    }
                    for (int ii = 0; ii < y; ii++)         //columnas
                    {
                        camposT[i, ii].Text = "";
                    }
                }     
            }

        }
        private void priEditarOtras()
        {
            if (banderaOtras == 1)
            {
                for (int i = 0; i < x; i++)          //filas
                {
                    String[] cmpss = new String[y];
                    for (int ii = 0; ii < y; ii++)         //columnas
                    {
                        if ((camposT[i, ii] != null) && (!camposT[i, ii].Equals("")))
                        {
                            cmpss[ii] = camposT[i, ii].Text;
                        }
                    }
                    priSentenciaEOtras(tablas[i], cmpss);
                }

            }
        }
        private void priSentenciaEOtras(string tbl, params string[] cmps)
        {
            string nuevaTabla = tbl;
            string[] camposTable;
            List<string> camposTable2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(nuevaTabla);
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTable2.Add(table2.Rows[i][0].ToString());
            }
            camposTable = camposTable2.ToArray();

            lo.actualizar(tbl, camposTable);
            for (int i=1; i < cmps.Length; i++)
            {
                    lo.modificarCampos(cmps[i]);     
            }
            lo.terminarSentenciaModificar(cmps[0]);
            lo.pubInsertarDatos();
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (estado.Equals("insertar"))
            {
                priInsertar();
                priGuardar();
                priGuardarOtras();

                Btn_guardar.Enabled = false;
                Btn_cancelar.Enabled = false;

                Btn_ingresar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                Btn_imprimir.Enabled = true;
                Btn_refrescar.Enabled = true;
                Btn_inicio.Enabled = true;
                Btn_anterior.Enabled = true;
                Btn_siguiente.Enabled = true;
                Btn_final.Enabled = true;
                deshabilitarComponentes();
            }else if (estado.Equals("editar")){
                priEditar();
                priGuardar();
                priEditarOtras();

                Btn_guardar.Enabled = false;
                Btn_cancelar.Enabled = false;

                Btn_ingresar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                Btn_imprimir.Enabled = true;
                Btn_refrescar.Enabled = true;
                Btn_inicio.Enabled = true;
                Btn_anterior.Enabled = true;
                Btn_siguiente.Enabled = true;
                Btn_final.Enabled = true;
                deshabilitarComponentes();
            }
            cantidadAcciones = 0;
        }

        private void priEditar()
        {
            string dato = "";
            List<string> campos = new List<string>();
            lo.actualizar(null, null);
            lo.actualizar(tabla, camposTabla);
            bool verificarIngreso = true;
            int j = 0, auxI;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = componente.Tag.ToString();
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        campos.Add("");
                        j++;
                    }
                }
            }
            nControl = j;
                string[] arrayCampos = campos.ToArray();

                foreach (Control componente in forma.Controls)
                {
                    auxI = 0;
                    if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                    {
                        string aux = componente.Tag.ToString();
                        if (!aux.Equals(""))
                        {
                            auxI = Convert.ToInt32(aux);
                        }
                        if (auxI > 0 && auxI <= 999)
                        {
                            try
                            {
                                if (componente is DateTimePicker)
                                {
                                    string num = componente.Tag.ToString();
                                    int numero = Convert.ToInt32(num) - 1;
                                    Console.WriteLine("tag: " + num);

                                    string fecha = componente.Text;
                                    string dia = fecha.Substring(0, fecha.IndexOf('/'));
                                    string complemento = fecha.Substring((fecha.IndexOf('/') + 1), 7);
                                    string mes = complemento.Substring(0, complemento.IndexOf('/'));
                                    string resto = complemento.Substring((complemento.IndexOf('/') + 1), (complemento.Length - 3));
                                    string anio = resto.Substring(0, resto.Length);

                                    if (dia.Length == 1)
                                    {
                                        dia = "0" + dia;
                                    }
                                    string fechaFinal = anio + mes + dia;
                                    arrayCampos[numero] = fechaFinal;
                                    componente.Text = "";
                                }
                                else
                                {
                                    string num = componente.Tag.ToString();
                                    int numero = Convert.ToInt32(num) - 1;
                                    arrayCampos[numero] = componente.Text;
                                    componente.Text = "";
                                }
                            }
                            catch (Exception)
                            {
                                verificarIngreso = false;
                                MessageBox.Show("No se ha ingresado el Tag del elemento " + componente.Name);
                            }
                        }
                    }
                }

                for (int i = 0; i < arrayCampos.Length; i++)
                {
                    if (i == 0)
                    {
                        dato = arrayCampos[i];
                        arrayCampos[i] = "";
                    }
                    else
                    {
                        lo.modificarCampos(arrayCampos[i]);
                        arrayCampos[i] = "";
                    }
                }

                if (verificarIngreso)
                {
                    lo.terminarSentenciaModificar(dato);
                }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
#pragma warning disable CS0219 // La variable 'auxI' está asignada pero su valor nunca se usa
            int j = 0, auxI;
#pragma warning restore CS0219 // La variable 'auxI' está asignada pero su valor nunca se usa
            sBanIngresar = 1;
            Btn_editar.Enabled = false;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    
                        j++;
                        componente.Enabled = true;
                    
                }
            }
            nControl = j;
                estado = "editar";
                Btn_guardar.Enabled = true;
                Btn_cancelar.Enabled = true;
                
                Btn_ingresar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = false;
                Btn_imprimir.Enabled = false;
                Btn_refrescar.Enabled = false;
                Btn_inicio.Enabled = false;
                Btn_anterior.Enabled = false;
                Btn_siguiente.Enabled = false;
                Btn_final.Enabled = false;
        }



        private void Btn_salir_Click(object sender, EventArgs e)
        {
            if (sBanIngresar == 1)
            {
                DialogResult res = MessageBox.Show("¿Desea guardar los datos?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    if (estado.Equals("insertar"))
                    {
                        priInsertar();
                        priGuardar();
                        Btn_guardar.Enabled = false;
                        Btn_cancelar.Enabled = false;

                        Btn_editar.Enabled = true;
                        Btn_borrar.Enabled = true;
                        Btn_consultar.Enabled = true;
                        Btn_imprimir.Enabled = true;
                        Btn_refrescar.Enabled = true;
                        Btn_inicio.Enabled = true;
                        Btn_anterior.Enabled = true;
                        Btn_siguiente.Enabled = true;
                        Btn_final.Enabled = true;
                    }
                    else if (estado.Equals("editar"))
                    {
                        priEditar();
                        priGuardar();
                        Btn_guardar.Enabled = false;
                        Btn_cancelar.Enabled = false;

                        Btn_ingresar.Enabled = true;
                        Btn_borrar.Enabled = true;
                        Btn_consultar.Enabled = true;
                        Btn_imprimir.Enabled = true;
                        Btn_refrescar.Enabled = true;
                        Btn_inicio.Enabled = true;
                        Btn_anterior.Enabled = true;
                        Btn_siguiente.Enabled = true;
                        Btn_final.Enabled = true;
                    }
                    forma.Close();
                }
                else if (res == DialogResult.No)
                {
                    sBanIngresar = 0;
                    forma.Close();                 
                }               
            }else
            {
                forma.Close();
            }
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            //Manda el número de flecha al que pertenece este botón para saber hacia donde moverse.
            int flecha = 2, auxI;
            fle.movimiento(flecha,dataGr);
            int fila = DataGr.CurrentRow.Index;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = componente.Tag.ToString();
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            int flecha = 1, auxI;
            fle.movimiento(flecha, dataGr);
            int fila = DataGr.CurrentRow.Index;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux =  componente.Tag.ToString();
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }

        private void Btn_final_Click(object sender, EventArgs e)
        {
            int flecha = 3, auxI;
            fle.movimiento(flecha,dataGr);
            int fila = DataGr.CurrentRow.Index;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = componente.Tag.ToString();
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            int flecha = 0, auxI;
            fle.movimiento(flecha,dataGr);
            int fila = DataGr.CurrentRow.Index;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = componente.Tag.ToString();
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Btn_guardar.Enabled = false;
       
            
            DialogResult res = MessageBox.Show("¿Desea cancelar la accion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Btn_cancelar.Enabled = false;
                Btn_ingresar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                Btn_imprimir.Enabled = true;
                Btn_refrescar.Enabled = true;
                Btn_inicio.Enabled = true;
                Btn_anterior.Enabled = true;
                Btn_siguiente.Enabled = true;
                Btn_final.Enabled = true;
                sBanIngresar = 0;
                foreach (Control componente in forma.Controls)
                {

                    if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                    {
                        componente.Text = "";
                    }
                }
                deshabilitarComponentes();
                MessageBox.Show("Accion Cancelada");
            }
            else if (res == DialogResult.No)
            {

            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Administrador reportes = new Administrador();
            reportes.AbrirAdministrador();
            /*Reporteador frmMSG = new Reporteador();
            frmMSG.Show();*/
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            int fila = DataGr.CurrentRow.Index;
            string id = dataGr.Rows[fila].Cells[0].Value.ToString();
            if (existEstatus)
            {
                lo.pubEliminar(tabla, id, camposTabla);
            }
            else
            {
                lo.pubEliminarSinEstatus(tabla, id, camposTabla);
            }
        }
        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            if (existEstatus)
            {
                DataTable table = lo.refrescar(tabla, camposTabla);
                DataGr.DataSource = table;
            }
            else
            {
                DataTable table = lo.refrescarSinEstatus(tabla, camposTabla);
                DataGr.DataSource = table;
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            String[] tablas = { "TBL_Operador", "TBL_Tipo_Operador" };
            Consulta cn = new Consulta("1",tablas);
            cn.abrir();
        }

        public DataTable cargarDatos(string table)
        {
            bool existEstatus2 = false;
            string nuevaTabla = table;
            string[] camposTable;
            List<string> camposTable2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(nuevaTabla);
            DataTable nuevaTabla2;
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTable2.Add(table2.Rows[i][0].ToString());
            }
            camposTable = camposTable2.ToArray();
            for (int i = 0; i < camposTable.Length; i++)
            {
                string comparar = camposTable[i];
                if (comparar.Equals("estatus"))
                {
                    existEstatus2 = true;
                }
            }
            if (existEstatus2)
            {
                nuevaTabla2 = lo.refrescar(nuevaTabla, camposTable);
            }
            else
            {
                nuevaTabla2 = lo.refrescarSinEstatus(nuevaTabla, camposTable);
            }
            return nuevaTabla2;
        }
        public void cargarCampos()
        {
            int fila = dataGr.CurrentRow.Index, auxI;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {

                    string aux = componente.Tag.ToString();
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }


        public string sentenciaInsertar(string tbl, params string[] cmps)
        {
            string nuevaTabla = tbl;
            string[] camposTable;
            List<string> camposTable2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(nuevaTabla);
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTable2.Add(table2.Rows[i][0].ToString());
            }
            camposTable = camposTable2.ToArray();

            string sql = "INSERT INTO " + nuevaTabla + " (";
            for (int i = 0; i < camposTable.Length; i++)
            {
                sql = sql + camposTable[i] + ", ";
            }
            char[] quitar = { ',', ' ' };
            sql = sql.TrimEnd(quitar);
            sql = sql + ") VALUES (";

            for (int i = 0; i < cmps.Length; i++)
            {
                if (cmps[i] != null)
                {
                    sql = sql + "'" + cmps[i] + "', ";
                }
            }
            sql = sql.TrimEnd(quitar);
            sql = sql + ");";
            return sql;
        }

        public DataSet cargarCombobox(string tbl, params string[] cmps)
        {
            DataSet dt =  lo.cargarCombobox(tbl, cmps);
            return dt;
        }
    }    
}
