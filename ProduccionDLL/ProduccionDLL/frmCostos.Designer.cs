namespace ProduccionDLL
{
    partial class frmCostos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCostos));
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxCosteProduccion = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridCosteProduccion = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCosteProduccion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(311, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ordenar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxCosteProduccion
            // 
            this.comboBoxCosteProduccion.FormattingEnabled = true;
            this.comboBoxCosteProduccion.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.comboBoxCosteProduccion.Location = new System.Drawing.Point(127, 28);
            this.comboBoxCosteProduccion.Name = "comboBoxCosteProduccion";
            this.comboBoxCosteProduccion.Size = new System.Drawing.Size(178, 25);
            this.comboBoxCosteProduccion.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBoxCosteProduccion);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(172, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 73);
            this.panel1.TabIndex = 0;
            // 
            // dataGridCosteProduccion
            // 
            this.dataGridCosteProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCosteProduccion.Location = new System.Drawing.Point(3, 13);
            this.dataGridCosteProduccion.Name = "dataGridCosteProduccion";
            this.dataGridCosteProduccion.Size = new System.Drawing.Size(707, 150);
            this.dataGridCosteProduccion.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridCosteProduccion);
            this.panel2.Location = new System.Drawing.Point(15, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 167);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "23012_Sistema de costos de producción";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Location = new System.Drawing.Point(14, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Buscar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 316);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 17);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(15, 339);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 17);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora";
            // 
            // frmCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(750, 366);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCostos";
            this.Text = "frmCostos";
            this.Load += new System.EventHandler(this.frmCostos_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmCostos_HelpRequested);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCosteProduccion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxCosteProduccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridCosteProduccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}