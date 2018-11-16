namespace ProduccionDLL
{
    partial class frmProcesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesos));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCosteEstadoProceso = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxActualizar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridEstadoProceso = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadoProceso)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(341, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el estado del proceso";
            // 
            // comboBoxCosteEstadoProceso
            // 
            this.comboBoxCosteEstadoProceso.FormattingEnabled = true;
            this.comboBoxCosteEstadoProceso.Items.AddRange(new object[] {
            "Pendiente",
            "En proceso",
            "Terminado"});
            this.comboBoxCosteEstadoProceso.Location = new System.Drawing.Point(215, 27);
            this.comboBoxCosteEstadoProceso.Name = "comboBoxCosteEstadoProceso";
            this.comboBoxCosteEstadoProceso.Size = new System.Drawing.Size(121, 25);
            this.comboBoxCosteEstadoProceso.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBoxActualizar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxCosteEstadoProceso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(63, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 139);
            this.panel1.TabIndex = 0;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(303, 66);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(139, 22);
            this.text1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(143, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Actualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxActualizar
            // 
            this.comboBoxActualizar.FormattingEnabled = true;
            this.comboBoxActualizar.Items.AddRange(new object[] {
            "Pendiente",
            "En proceso",
            "Terminado"});
            this.comboBoxActualizar.Location = new System.Drawing.Point(7, 99);
            this.comboBoxActualizar.Name = "comboBoxActualizar";
            this.comboBoxActualizar.Size = new System.Drawing.Size(121, 25);
            this.comboBoxActualizar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese el Id de proceso que desea actualizar";
            // 
            // dataGridEstadoProceso
            // 
            this.dataGridEstadoProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadoProceso.Location = new System.Drawing.Point(18, 16);
            this.dataGridEstadoProceso.Name = "dataGridEstadoProceso";
            this.dataGridEstadoProceso.Size = new System.Drawing.Size(690, 124);
            this.dataGridEstadoProceso.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridEstadoProceso);
            this.panel2.Location = new System.Drawing.Point(63, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 152);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "23013_Sistema de procesos de produccion";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(60, 349);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 17);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(60, 372);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 17);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora";
            // 
            // frmProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(809, 393);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProcesos";
            this.Text = "frmProcesos";
            this.Load += new System.EventHandler(this.frmProcesos_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmProcesos_HelpRequested);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadoProceso)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCosteEstadoProceso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridEstadoProceso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}