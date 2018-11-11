namespace CapaDesign
{
    partial class frm_explosion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_explosion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_explosionSalir = new System.Windows.Forms.Button();
            this.btn_explosionMinimizar = new System.Windows.Forms.Button();
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_detallesExplosion = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requerido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvFabrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_maxFabricar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "2402_Explosión de Materiales";
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
            this.btn_explosionSalir.Click += new System.EventHandler(this.btn_explosionSalir_Click);
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
            this.btn_explosionMinimizar.Click += new System.EventHandler(this.btn_explosionMinimizar_Click);
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.label4);
            this.Gb_Datos.Controls.Add(this.dgv_detallesExplosion);
            this.Gb_Datos.Controls.Add(this.txt_maxFabricar);
            this.Gb_Datos.Controls.Add(this.label6);
            this.Gb_Datos.Controls.Add(this.textBox1);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.label7);
            this.Gb_Datos.Controls.Add(this.textBox2);
            this.Gb_Datos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Datos.Location = new System.Drawing.Point(3, 142);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Size = new System.Drawing.Size(909, 494);
            this.Gb_Datos.TabIndex = 30;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre de Producto";
            // 
            // dgv_detallesExplosion
            // 
            this.dgv_detallesExplosion.AllowUserToOrderColumns = true;
            this.dgv_detallesExplosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallesExplosion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripción,
            this.Cantidad,
            this.Stock,
            this.Costo,
            this.UM,
            this.Column1,
            this.Requerido,
            this.Existencias,
            this.InvFabrica,
            this.Faltante,
            this.Column2});
            this.dgv_detallesExplosion.Location = new System.Drawing.Point(17, 139);
            this.dgv_detallesExplosion.Name = "dgv_detallesExplosion";
            this.dgv_detallesExplosion.Size = new System.Drawing.Size(886, 349);
            this.dgv_detallesExplosion.TabIndex = 23;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 110;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad requerida";
            this.Cantidad.Name = "Cantidad";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Por fabricar";
            this.Costo.Name = "Costo";
            // 
            // UM
            // 
            this.UM.HeaderText = "UM.";
            this.UM.Name = "UM";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Terminado";
            this.Column1.Name = "Column1";
            // 
            // Requerido
            // 
            this.Requerido.HeaderText = "Requerido";
            this.Requerido.Name = "Requerido";
            // 
            // Existencias
            // 
            this.Existencias.HeaderText = "Existencias";
            this.Existencias.Name = "Existencias";
            // 
            // InvFabrica
            // 
            this.InvFabrica.HeaderText = "Inv. Fabrica.";
            this.InvFabrica.Name = "InvFabrica";
            // 
            // Faltante
            // 
            this.Faltante.HeaderText = "Faltante";
            this.Faltante.Name = "Faltante";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Costo Estimado";
            this.Column2.Name = "Column2";
            // 
            // txt_maxFabricar
            // 
            this.txt_maxFabricar.Location = new System.Drawing.Point(156, 59);
            this.txt_maxFabricar.Name = "txt_maxFabricar";
            this.txt_maxFabricar.Size = new System.Drawing.Size(120, 23);
            this.txt_maxFabricar.TabIndex = 17;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(156, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Detalles de Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Código de Producto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(435, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 23);
            this.textBox2.TabIndex = 5;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Forma = null;
            this.navegador1.Location = new System.Drawing.Point(20, 63);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 31;
            // 
            // Explosion_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Explosion_Materiales";
            this.Text = "Explosion_Materiales";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_detallesExplosion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requerido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvFabrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txt_maxFabricar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private CapaDiseno.Navegador navegador1;
    }
}