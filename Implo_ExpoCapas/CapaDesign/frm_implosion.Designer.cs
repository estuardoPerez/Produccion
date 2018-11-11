namespace CapaDesign
{
    partial class frm_implosion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_implosion));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_implosionSalir = new System.Windows.Forms.Button();
            this.btn_implosionMinimizar = new System.Windows.Forms.Button();
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maxFabricar = new System.Windows.Forms.TextBox();
            this.dgv_detallesImplosion = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_codigoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.Gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallesImplosion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-130, -94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "2401_Implosion de Materiales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-175, -97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "2401_Implosión de Materiales";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_implosionSalir);
            this.panel1.Controls.Add(this.btn_implosionMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 45);
            this.panel1.TabIndex = 15;
            // 
            // btn_implosionSalir
            // 
            this.btn_implosionSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btn_implosionSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_implosionSalir.BackgroundImage")));
            this.btn_implosionSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_implosionSalir.FlatAppearance.BorderSize = 0;
            this.btn_implosionSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_implosionSalir.Location = new System.Drawing.Point(887, 0);
            this.btn_implosionSalir.Name = "btn_implosionSalir";
            this.btn_implosionSalir.Size = new System.Drawing.Size(41, 41);
            this.btn_implosionSalir.TabIndex = 1;
            this.btn_implosionSalir.UseVisualStyleBackColor = false;
            this.btn_implosionSalir.Click += new System.EventHandler(this.btn_implosionSalir_Click);
            // 
            // btn_implosionMinimizar
            // 
            this.btn_implosionMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btn_implosionMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_implosionMinimizar.BackgroundImage")));
            this.btn_implosionMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_implosionMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_implosionMinimizar.FlatAppearance.BorderSize = 0;
            this.btn_implosionMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_implosionMinimizar.Location = new System.Drawing.Point(846, 0);
            this.btn_implosionMinimizar.Name = "btn_implosionMinimizar";
            this.btn_implosionMinimizar.Size = new System.Drawing.Size(41, 41);
            this.btn_implosionMinimizar.TabIndex = 1;
            this.btn_implosionMinimizar.UseVisualStyleBackColor = false;
            this.btn_implosionMinimizar.Click += new System.EventHandler(this.btn_implosionMinimizar_Click);
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.label3);
            this.Gb_Datos.Controls.Add(this.txt_maxFabricar);
            this.Gb_Datos.Controls.Add(this.dgv_detallesImplosion);
            this.Gb_Datos.Controls.Add(this.label6);
            this.Gb_Datos.Controls.Add(this.txt_codigoProducto);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Controls.Add(this.txt_nombreProducto);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Datos.Location = new System.Drawing.Point(13, 148);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Size = new System.Drawing.Size(874, 446);
            this.Gb_Datos.TabIndex = 16;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre de Producto";
            // 
            // txt_maxFabricar
            // 
            this.txt_maxFabricar.Location = new System.Drawing.Point(156, 59);
            this.txt_maxFabricar.Name = "txt_maxFabricar";
            this.txt_maxFabricar.Size = new System.Drawing.Size(120, 23);
            this.txt_maxFabricar.TabIndex = 17;
            // 
            // dgv_detallesImplosion
            // 
            this.dgv_detallesImplosion.AllowUserToOrderColumns = true;
            this.dgv_detallesImplosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallesImplosion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Descripción,
            this.Column3,
            this.Column2,
            this.Column1});
            this.dgv_detallesImplosion.Location = new System.Drawing.Point(25, 130);
            this.dgv_detallesImplosion.Name = "dgv_detallesImplosion";
            this.dgv_detallesImplosion.Size = new System.Drawing.Size(839, 218);
            this.dgv_detallesImplosion.TabIndex = 16;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Código";
            this.Clave.Name = "Clave";
            // 
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Requerido";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Existencias";
            this.Column1.Name = "Column1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Maximo a Fabricar";
            // 
            // txt_codigoProducto
            // 
            this.txt_codigoProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_codigoProducto.Location = new System.Drawing.Point(156, 28);
            this.txt_codigoProducto.Name = "txt_codigoProducto";
            this.txt_codigoProducto.ReadOnly = true;
            this.txt_codigoProducto.Size = new System.Drawing.Size(120, 23);
            this.txt_codigoProducto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código de Producto";
            // 
            // txt_nombreProducto
            // 
            this.txt_nombreProducto.Location = new System.Drawing.Point(435, 28);
            this.txt_nombreProducto.Name = "txt_nombreProducto";
            this.txt_nombreProducto.Size = new System.Drawing.Size(249, 23);
            this.txt_nombreProducto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detalles de Fabricación ";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(30, 64);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 17;
            // 
            // Implosion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Implosion";
            this.Text = "Implosion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallesImplosion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_implosionSalir;
        private System.Windows.Forms.Button btn_implosionMinimizar;
        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maxFabricar;
        private System.Windows.Forms.DataGridView dgv_detallesImplosion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_codigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombreProducto;
        private System.Windows.Forms.Label label2;
        private CapaDiseno.Navegador navegador1;
    }
}