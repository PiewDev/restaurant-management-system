namespace P3
{
    partial class FormQueProducto
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
            this.button_producto_simple = new System.Windows.Forms.Button();
            this.button_producto_compuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_producto_simple
            // 
            this.button_producto_simple.Location = new System.Drawing.Point(212, 158);
            this.button_producto_simple.Name = "button_producto_simple";
            this.button_producto_simple.Size = new System.Drawing.Size(125, 23);
            this.button_producto_simple.TabIndex = 0;
            this.button_producto_simple.Text = "Producto Simple";
            this.button_producto_simple.UseVisualStyleBackColor = true;
            this.button_producto_simple.Click += new System.EventHandler(this.button_producto_simple_Click);
            // 
            // button_producto_compuesto
            // 
            this.button_producto_compuesto.Location = new System.Drawing.Point(393, 158);
            this.button_producto_compuesto.Name = "button_producto_compuesto";
            this.button_producto_compuesto.Size = new System.Drawing.Size(136, 23);
            this.button_producto_compuesto.TabIndex = 1;
            this.button_producto_compuesto.Text = "Producto Compuesto";
            this.button_producto_compuesto.UseVisualStyleBackColor = true;
            this.button_producto_compuesto.Click += new System.EventHandler(this.button_producto_compuesto_Click);
            // 
            // FormQueProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_producto_compuesto);
            this.Controls.Add(this.button_producto_simple);
            this.Name = "FormQueProducto";
            this.Text = "FormQueProducto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_producto_simple;
        private System.Windows.Forms.Button button_producto_compuesto;
    }
}