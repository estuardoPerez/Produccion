﻿namespace RRHH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lbl_gestionFormatos = new System.Windows.Forms.Label();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_produccion = new System.Windows.Forms.Button();
            this.Lbl_Ingreso = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Llbl_nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lbl_Area = new System.Windows.Forms.Label();
            this.Cmb_Area = new System.Windows.Forms.ComboBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Dtp_ingreso = new System.Windows.Forms.DateTimePicker();
            this.dgv_ingreso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmb_Horario = new System.Windows.Forms.ComboBox();
            this.Lbl_horario = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Lbl_horainicio = new System.Windows.Forms.Label();
            this.Lbl_horafin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingreso)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_gestionFormatos
            // 
            this.Lbl_gestionFormatos.AutoSize = true;
            this.Lbl_gestionFormatos.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gestionFormatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_gestionFormatos.Location = new System.Drawing.Point(363, 138);
            this.Lbl_gestionFormatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_gestionFormatos.Name = "Lbl_gestionFormatos";
            this.Lbl_gestionFormatos.Size = new System.Drawing.Size(222, 26);
            this.Lbl_gestionFormatos.TabIndex = 96;
            this.Lbl_gestionFormatos.Text = "Ingreso de Personal";
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.Panel_arriba.Controls.Add(this.Btn_minimizar);
            this.Panel_arriba.Controls.Add(this.Btn_cerrar);
            this.Panel_arriba.Controls.Add(this.Btn_produccion);
            this.Panel_arriba.Controls.Add(this.Lbl_Ingreso);
            this.Panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.Panel_arriba.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(933, 42);
            this.Panel_arriba.TabIndex = 97;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(880, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(41, 41);
            this.Btn_minimizar.TabIndex = 99;
            this.toolTip1.SetToolTip(this.Btn_minimizar, "Minimizar");
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.Btn_cerrar.Location = new System.Drawing.Point(833, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(41, 41);
            this.Btn_cerrar.TabIndex = 98;
            this.toolTip1.SetToolTip(this.Btn_cerrar, "Cerrar");
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_produccion
            // 
            this.Btn_produccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_produccion.BackgroundImage")));
            this.Btn_produccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_produccion.FlatAppearance.BorderSize = 0;
            this.Btn_produccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_produccion.Location = new System.Drawing.Point(3, 1);
            this.Btn_produccion.Name = "Btn_produccion";
            this.Btn_produccion.Size = new System.Drawing.Size(41, 41);
            this.Btn_produccion.TabIndex = 100;
            this.Btn_produccion.UseVisualStyleBackColor = true;
            // 
            // Lbl_Ingreso
            // 
            this.Lbl_Ingreso.AutoSize = true;
            this.Lbl_Ingreso.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ingreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Ingreso.Location = new System.Drawing.Point(47, 1);
            this.Lbl_Ingreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Ingreso.Name = "Lbl_Ingreso";
            this.Lbl_Ingreso.Size = new System.Drawing.Size(426, 39);
            this.Lbl_Ingreso.TabIndex = 98;
            this.Lbl_Ingreso.Text = "2601_Ingreso de personal";
            this.Lbl_Ingreso.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 22);
            this.textBox1.TabIndex = 98;
            this.textBox1.Tag = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Llbl_nombre
            // 
            this.Llbl_nombre.AutoSize = true;
            this.Llbl_nombre.Location = new System.Drawing.Point(47, 180);
            this.Llbl_nombre.Name = "Llbl_nombre";
            this.Llbl_nombre.Size = new System.Drawing.Size(58, 17);
            this.Llbl_nombre.TabIndex = 99;
            this.Llbl_nombre.Text = "Nombre";
            this.Llbl_nombre.Click += new System.EventHandler(this.Llbl_nombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 101;
            this.label2.Tag = "";
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(304, 22);
            this.textBox2.TabIndex = 100;
            this.textBox2.Tag = "2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Lbl_Area
            // 
            this.Lbl_Area.AutoSize = true;
            this.Lbl_Area.Location = new System.Drawing.Point(47, 238);
            this.Lbl_Area.Name = "Lbl_Area";
            this.Lbl_Area.Size = new System.Drawing.Size(122, 17);
            this.Lbl_Area.TabIndex = 102;
            this.Lbl_Area.Tag = "";
            this.Lbl_Area.Text = "Puesto designado";
            // 
            // Cmb_Area
            // 
            this.Cmb_Area.FormattingEnabled = true;
            this.Cmb_Area.Location = new System.Drawing.Point(185, 235);
            this.Cmb_Area.Name = "Cmb_Area";
            this.Cmb_Area.Size = new System.Drawing.Size(304, 24);
            this.Cmb_Area.TabIndex = 103;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(47, 267);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(119, 17);
            this.Lbl_fecha.TabIndex = 104;
            this.Lbl_fecha.Tag = "";
            this.Lbl_fecha.Text = "Fecha asignación";
            // 
            // Dtp_ingreso
            // 
            this.Dtp_ingreso.Location = new System.Drawing.Point(185, 265);
            this.Dtp_ingreso.Name = "Dtp_ingreso";
            this.Dtp_ingreso.Size = new System.Drawing.Size(304, 22);
            this.Dtp_ingreso.TabIndex = 105;
            // 
            // dgv_ingreso
            // 
            this.dgv_ingreso.AllowUserToAddRows = false;
            this.dgv_ingreso.AllowUserToDeleteRows = false;
            this.dgv_ingreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgv_ingreso.Location = new System.Drawing.Point(127, 374);
            this.dgv_ingreso.Name = "dgv_ingreso";
            this.dgv_ingreso.ReadOnly = true;
            this.dgv_ingreso.RowTemplate.Height = 24;
            this.dgv_ingreso.Size = new System.Drawing.Size(681, 254);
            this.dgv_ingreso.TabIndex = 106;
            this.dgv_ingreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Area designada";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de asignación";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 170;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Horario";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Cmb_Horario
            // 
            this.Cmb_Horario.FormattingEnabled = true;
            this.Cmb_Horario.Location = new System.Drawing.Point(185, 293);
            this.Cmb_Horario.Name = "Cmb_Horario";
            this.Cmb_Horario.Size = new System.Drawing.Size(304, 24);
            this.Cmb_Horario.TabIndex = 110;
            // 
            // Lbl_horario
            // 
            this.Lbl_horario.AutoSize = true;
            this.Lbl_horario.Location = new System.Drawing.Point(47, 296);
            this.Lbl_horario.Name = "Lbl_horario";
            this.Lbl_horario.Size = new System.Drawing.Size(55, 17);
            this.Lbl_horario.TabIndex = 109;
            this.Lbl_horario.Tag = "";
            this.Lbl_horario.Text = "Horario";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(126, 22);
            this.textBox3.TabIndex = 111;
            this.textBox3.Tag = "1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(489, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(126, 22);
            this.textBox4.TabIndex = 112;
            this.textBox4.Tag = "1";
            // 
            // Lbl_horainicio
            // 
            this.Lbl_horainicio.AutoSize = true;
            this.Lbl_horainicio.Location = new System.Drawing.Point(47, 326);
            this.Lbl_horainicio.Name = "Lbl_horainicio";
            this.Lbl_horainicio.Size = new System.Drawing.Size(75, 17);
            this.Lbl_horainicio.TabIndex = 113;
            this.Lbl_horainicio.Tag = "";
            this.Lbl_horainicio.Text = "Hora inicio";
            // 
            // Lbl_horafin
            // 
            this.Lbl_horafin.AutoSize = true;
            this.Lbl_horafin.Location = new System.Drawing.Point(376, 326);
            this.Lbl_horafin.Name = "Lbl_horafin";
            this.Lbl_horafin.Size = new System.Drawing.Size(58, 17);
            this.Lbl_horafin.TabIndex = 114;
            this.Lbl_horafin.Tag = "";
            this.Lbl_horafin.Text = "Hora fin";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(854, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 85);
            this.button1.TabIndex = 115;
            this.button1.Text = "ayuda";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_horafin);
            this.Controls.Add(this.Lbl_horainicio);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Cmb_Horario);
            this.Controls.Add(this.Lbl_horario);
            this.Controls.Add(this.dgv_ingreso);
            this.Controls.Add(this.Dtp_ingreso);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Cmb_Area);
            this.Controls.Add(this.Lbl_Area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Llbl_nombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Lbl_gestionFormatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_arriba.ResumeLayout(false);
            this.Panel_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_gestionFormatos;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.Label Lbl_Ingreso;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_produccion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Llbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lbl_Area;
        private System.Windows.Forms.ComboBox Cmb_Area;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.DateTimePicker Dtp_ingreso;
        private System.Windows.Forms.DataGridView dgv_ingreso;
        private System.Windows.Forms.ComboBox Cmb_Horario;
        private System.Windows.Forms.Label Lbl_horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Lbl_horainicio;
        private System.Windows.Forms.Label Lbl_horafin;
        private System.Windows.Forms.Button button1;
    }
}

