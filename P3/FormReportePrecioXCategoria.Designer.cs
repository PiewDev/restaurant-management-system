namespace P3
{
    partial class FormReportePrecioXCategoria
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
            this.dataGridView_Categoria_Precio = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Buscar_Categoria_Producto_Simple = new System.Windows.Forms.Button();
            this.label_simple_compuesto = new System.Windows.Forms.Label();
            this.textBox_simple_compuesto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categoria_Precio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Categoria_Precio
            // 
            this.dataGridView_Categoria_Precio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categoria_Precio.Location = new System.Drawing.Point(25, 67);
            this.dataGridView_Categoria_Precio.Name = "dataGridView_Categoria_Precio";
            this.dataGridView_Categoria_Precio.Size = new System.Drawing.Size(575, 183);
            this.dataGridView_Categoria_Precio.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_simple_compuesto);
            this.groupBox1.Controls.Add(this.label_simple_compuesto);
            this.groupBox1.Controls.Add(this.button_Buscar_Categoria_Producto_Simple);
            this.groupBox1.Controls.Add(this.dataGridView_Categoria_Precio);
            this.groupBox1.Location = new System.Drawing.Point(262, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 285);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto Simple";
            // 
            // button_Buscar_Categoria_Producto_Simple
            // 
            this.button_Buscar_Categoria_Producto_Simple.Location = new System.Drawing.Point(237, 27);
            this.button_Buscar_Categoria_Producto_Simple.Name = "button_Buscar_Categoria_Producto_Simple";
            this.button_Buscar_Categoria_Producto_Simple.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_Categoria_Producto_Simple.TabIndex = 5;
            this.button_Buscar_Categoria_Producto_Simple.Text = "Buscar";
            this.button_Buscar_Categoria_Producto_Simple.UseVisualStyleBackColor = true;
            this.button_Buscar_Categoria_Producto_Simple.Click += new System.EventHandler(this.button_Buscar_Categoria_Producto_Simple_Click);
            // 
            // label_simple_compuesto
            // 
            this.label_simple_compuesto.AutoSize = true;
            this.label_simple_compuesto.Location = new System.Drawing.Point(22, 32);
            this.label_simple_compuesto.Name = "label_simple_compuesto";
            this.label_simple_compuesto.Size = new System.Drawing.Size(103, 13);
            this.label_simple_compuesto.TabIndex = 6;
            this.label_simple_compuesto.Text = "Simple o Compuesto";
            // 
            // textBox_simple_compuesto
            // 
            this.textBox_simple_compuesto.Location = new System.Drawing.Point(131, 29);
            this.textBox_simple_compuesto.Name = "textBox_simple_compuesto";
            this.textBox_simple_compuesto.Size = new System.Drawing.Size(100, 20);
            this.textBox_simple_compuesto.TabIndex = 7;
            // 
            // FormReportePrecioXCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 608);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportePrecioXCategoria";
            this.Text = "FormReportePrecioXCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categoria_Precio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Categoria_Precio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Buscar_Categoria_Producto_Simple;
        private System.Windows.Forms.TextBox textBox_simple_compuesto;
        private System.Windows.Forms.Label label_simple_compuesto;
    }
}