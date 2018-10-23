namespace Ordenes_Producción
{
    partial class Productos_2250
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
            this.Dgv_producto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_producto
            // 
            this.Dgv_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_producto.Location = new System.Drawing.Point(1, 1);
            this.Dgv_producto.Name = "Dgv_producto";
            this.Dgv_producto.Size = new System.Drawing.Size(530, 277);
            this.Dgv_producto.TabIndex = 0;
            this.Dgv_producto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_producto_CellDoubleClick);
            // 
            // Productos_2250
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 279);
            this.Controls.Add(this.Dgv_producto);
            this.Name = "Productos_2250";
            this.Text = "Productos_2250";
            this.Load += new System.EventHandler(this.Productos_2250_Load);
            this.DoubleClick += new System.EventHandler(this.Productos_2250_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_producto;
    }
}