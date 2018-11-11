namespace Implosion_y_Explosion_Materiales
{
    partial class frm_peticion_Materia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peticion_Materia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_explosionSalir = new System.Windows.Forms.Button();
            this.btn_explosionMinimizar = new System.Windows.Forms.Button();
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_entregaPeticion = new System.Windows.Forms.DateTimePicker();
            this.dtp_emisionPeticion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_detallesExplosion = new System.Windows.Forms.DataGridView();
            this.cod_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_usuarioPeticion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numeroPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallesExplosion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_explosionSalir);
            this.panel1.Controls.Add(this.btn_explosionMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 45);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "2403_Peticion de Materiales ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_explosionSalir
            // 
            this.btn_explosionSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btn_explosionSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_explosionSalir.BackgroundImage")));
            this.btn_explosionSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_explosionSalir.FlatAppearance.BorderSize = 0;
            this.btn_explosionSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_explosionSalir.Location = new System.Drawing.Point(887, 0);
            this.btn_explosionSalir.Name = "btn_explosionSalir";
            this.btn_explosionSalir.Size = new System.Drawing.Size(41, 41);
            this.btn_explosionSalir.TabIndex = 1;
            this.btn_explosionSalir.UseVisualStyleBackColor = false;
            // 
            // btn_explosionMinimizar
            // 
            this.btn_explosionMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btn_explosionMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_explosionMinimizar.BackgroundImage")));
            this.btn_explosionMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_explosionMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_explosionMinimizar.FlatAppearance.BorderSize = 0;
            this.btn_explosionMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_explosionMinimizar.Location = new System.Drawing.Point(846, 0);
            this.btn_explosionMinimizar.Name = "btn_explosionMinimizar";
            this.btn_explosionMinimizar.Size = new System.Drawing.Size(41, 41);
            this.btn_explosionMinimizar.TabIndex = 1;
            this.btn_explosionMinimizar.UseVisualStyleBackColor = false;
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.label3);
            this.Gb_Datos.Controls.Add(this.dtp_entregaPeticion);
            this.Gb_Datos.Controls.Add(this.dtp_emisionPeticion);
            this.Gb_Datos.Controls.Add(this.label4);
            this.Gb_Datos.Controls.Add(this.dgv_detallesExplosion);
            this.Gb_Datos.Controls.Add(this.txt_usuarioPeticion);
            this.Gb_Datos.Controls.Add(this.label6);
            this.Gb_Datos.Controls.Add(this.txt_numeroPedido);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.label7);
            this.Gb_Datos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Datos.Location = new System.Drawing.Point(3, 169);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Size = new System.Drawing.Size(909, 494);
            this.Gb_Datos.TabIndex = 31;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fecha de Entrega";
            // 
            // dtp_entregaPeticion
            // 
            this.dtp_entregaPeticion.Location = new System.Drawing.Point(439, 59);
            this.dtp_entregaPeticion.Name = "dtp_entregaPeticion";
            this.dtp_entregaPeticion.Size = new System.Drawing.Size(200, 23);
            this.dtp_entregaPeticion.TabIndex = 29;
            // 
            // dtp_emisionPeticion
            // 
            this.dtp_emisionPeticion.Location = new System.Drawing.Point(439, 30);
            this.dtp_emisionPeticion.Name = "dtp_emisionPeticion";
            this.dtp_emisionPeticion.Size = new System.Drawing.Size(200, 23);
            this.dtp_emisionPeticion.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha de Emisión";
            // 
            // dgv_detallesExplosion
            // 
            this.dgv_detallesExplosion.AllowUserToOrderColumns = true;
            this.dgv_detallesExplosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallesExplosion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_mat,
            this.articulo,
            this.cantidad_materia});
            this.dgv_detallesExplosion.Location = new System.Drawing.Point(17, 139);
            this.dgv_detallesExplosion.Name = "dgv_detallesExplosion";
            this.dgv_detallesExplosion.Size = new System.Drawing.Size(886, 349);
            this.dgv_detallesExplosion.TabIndex = 23;
            // 
            // cod_mat
            // 
            this.cod_mat.HeaderText = "Codigo Materia ";
            this.cod_mat.Name = "cod_mat";
            // 
            // articulo
            // 
            this.articulo.HeaderText = "Descripción del Articulo ";
            this.articulo.Name = "articulo";
            // 
            // cantidad_materia
            // 
            this.cantidad_materia.HeaderText = "Cantidad Requerida";
            this.cantidad_materia.Name = "cantidad_materia";
            // 
            // txt_usuarioPeticion
            // 
            this.txt_usuarioPeticion.Location = new System.Drawing.Point(156, 59);
            this.txt_usuarioPeticion.Name = "txt_usuarioPeticion";
            this.txt_usuarioPeticion.Size = new System.Drawing.Size(120, 23);
            this.txt_usuarioPeticion.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario";
            // 
            // txt_numeroPedido
            // 
            this.txt_numeroPedido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_numeroPedido.Location = new System.Drawing.Point(156, 28);
            this.txt_numeroPedido.Name = "txt_numeroPedido";
            this.txt_numeroPedido.ReadOnly = true;
            this.txt_numeroPedido.Size = new System.Drawing.Size(120, 23);
            this.txt_numeroPedido.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Detalles de Pedido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Numero de Pedido";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(30, 76);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 32;
            // 
            // Peticion_Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Peticion_Materia";
            this.Text = "Peticion Materia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallesExplosion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_explosionSalir;
        private System.Windows.Forms.Button btn_explosionMinimizar;
        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_entregaPeticion;
        private System.Windows.Forms.DateTimePicker dtp_emisionPeticion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_detallesExplosion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_materia;
        private System.Windows.Forms.TextBox txt_usuarioPeticion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numeroPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private CapaDiseno.Navegador navegador1;
    }
}