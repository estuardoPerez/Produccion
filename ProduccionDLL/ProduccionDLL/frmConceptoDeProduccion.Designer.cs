namespace ProduccionDLL
{
    partial class frmConceptoDeProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConceptoDeProduccion));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewConceptoDeProduccion = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConceptoDeProduccion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "23011_Sistema de producción";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(20, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(57, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 69);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewConceptoDeProduccion
            // 
            this.dataGridViewConceptoDeProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConceptoDeProduccion.Location = new System.Drawing.Point(20, 16);
            this.dataGridViewConceptoDeProduccion.Name = "dataGridViewConceptoDeProduccion";
            this.dataGridViewConceptoDeProduccion.Size = new System.Drawing.Size(703, 150);
            this.dataGridViewConceptoDeProduccion.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewConceptoDeProduccion);
            this.panel2.Location = new System.Drawing.Point(57, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 193);
            this.panel2.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(54, 326);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 17);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(54, 349);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 17);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora";
            // 
            // frmConceptoDeProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(828, 392);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConceptoDeProduccion";
            this.Text = "frmConceptoDeProduccion";
            this.Load += new System.EventHandler(this.frmConceptoDeProduccion_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmConceptoDeProduccion_HelpRequested);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConceptoDeProduccion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewConceptoDeProduccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}