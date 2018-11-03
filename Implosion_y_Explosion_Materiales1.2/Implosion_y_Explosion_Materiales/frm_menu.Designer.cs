namespace Implosion_y_Explosion_Materiales
{
    partial class Menu_prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_prueba));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_explosionMinimizar = new System.Windows.Forms.Button();
            this.btn_explosionSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Implosion = new System.Windows.Forms.Button();
            this.btn_Explosion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_explosionMinimizar);
            this.panel1.Controls.Add(this.btn_explosionSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 58);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU DE PRUEBA";
            // 
            // btn_explosionMinimizar
            // 
            this.btn_explosionMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btn_explosionMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_explosionMinimizar.BackgroundImage")));
            this.btn_explosionMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_explosionMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_explosionMinimizar.FlatAppearance.BorderSize = 0;
            this.btn_explosionMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_explosionMinimizar.Location = new System.Drawing.Point(293, 7);
            this.btn_explosionMinimizar.Name = "btn_explosionMinimizar";
            this.btn_explosionMinimizar.Size = new System.Drawing.Size(41, 41);
            this.btn_explosionMinimizar.TabIndex = 1;
            this.btn_explosionMinimizar.UseVisualStyleBackColor = false;
            this.btn_explosionMinimizar.Click += new System.EventHandler(this.btn_explosionMinimizar_Click);
            // 
            // btn_explosionSalir
            // 
            this.btn_explosionSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btn_explosionSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_explosionSalir.BackgroundImage")));
            this.btn_explosionSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_explosionSalir.FlatAppearance.BorderSize = 0;
            this.btn_explosionSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_explosionSalir.Location = new System.Drawing.Point(334, 7);
            this.btn_explosionSalir.Name = "btn_explosionSalir";
            this.btn_explosionSalir.Size = new System.Drawing.Size(41, 41);
            this.btn_explosionSalir.TabIndex = 1;
            this.btn_explosionSalir.UseVisualStyleBackColor = false;
            this.btn_explosionSalir.Click += new System.EventHandler(this.btn_explosionSalir_Click);
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
            // btn_Implosion
            // 
            this.btn_Implosion.Location = new System.Drawing.Point(145, 130);
            this.btn_Implosion.Name = "btn_Implosion";
            this.btn_Implosion.Size = new System.Drawing.Size(109, 67);
            this.btn_Implosion.TabIndex = 3;
            this.btn_Implosion.Text = "Implosion de Materiales";
            this.btn_Implosion.UseVisualStyleBackColor = true;
            this.btn_Implosion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Explosion
            // 
            this.btn_Explosion.Location = new System.Drawing.Point(145, 233);
            this.btn_Explosion.Name = "btn_Explosion";
            this.btn_Explosion.Size = new System.Drawing.Size(109, 67);
            this.btn_Explosion.TabIndex = 4;
            this.btn_Explosion.Text = "Explosion de Materiales";
            this.btn_Explosion.UseVisualStyleBackColor = true;
            this.btn_Explosion.Click += new System.EventHandler(this.btn_Explosion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Peticion de Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Explosion);
            this.Controls.Add(this.btn_Implosion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_prueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_explosionSalir;
        private System.Windows.Forms.Button btn_explosionMinimizar;
        private System.Windows.Forms.Button btn_Implosion;
        private System.Windows.Forms.Button btn_Explosion;
        private System.Windows.Forms.Button button1;
    }
}