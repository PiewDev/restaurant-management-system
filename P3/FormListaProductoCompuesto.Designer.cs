namespace P3
{
    partial class FormListaProductoCompuesto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_buscar = new System.Windows.Forms.Button();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.label_categoria = new System.Windows.Forms.Label();
            this.dataGridView_lista_producto_compuesto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre_producto_compuesto = new System.Windows.Forms.TextBox();
            this.button_buscar_nombre_producto_compuesto = new System.Windows.Forms.Button();
            this.Mozo = new System.Windows.Forms.Label();
            this.textBox_mozo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista_producto_compuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_mozo);
            this.groupBox1.Controls.Add(this.Mozo);
            this.groupBox1.Controls.Add(this.button_buscar_nombre_producto_compuesto);
            this.groupBox1.Controls.Add(this.textBox_nombre_producto_compuesto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_cancelar);
            this.groupBox1.Controls.Add(this.button_agregar);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.comboBox_categoria);
            this.groupBox1.Controls.Add(this.label_categoria);
            this.groupBox1.Controls.Add(this.dataGridView_lista_producto_compuesto);
            this.groupBox1.Location = new System.Drawing.Point(300, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto Compuesto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(615, 400);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 7;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(523, 400);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 6;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(191, 115);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 5;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Location = new System.Drawing.Point(64, 117);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_categoria.TabIndex = 4;
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Location = new System.Drawing.Point(6, 120);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(52, 13);
            this.label_categoria.TabIndex = 2;
            this.label_categoria.Text = "Categoria";
            // 
            // dataGridView_lista_producto_compuesto
            // 
            this.dataGridView_lista_producto_compuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lista_producto_compuesto.Location = new System.Drawing.Point(6, 146);
            this.dataGridView_lista_producto_compuesto.Name = "dataGridView_lista_producto_compuesto";
            this.dataGridView_lista_producto_compuesto.Size = new System.Drawing.Size(725, 237);
            this.dataGridView_lista_producto_compuesto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // textBox_nombre_producto_compuesto
            // 
            this.textBox_nombre_producto_compuesto.Location = new System.Drawing.Point(449, 115);
            this.textBox_nombre_producto_compuesto.Name = "textBox_nombre_producto_compuesto";
            this.textBox_nombre_producto_compuesto.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre_producto_compuesto.TabIndex = 9;
            // 
            // button_buscar_nombre_producto_compuesto
            // 
            this.button_buscar_nombre_producto_compuesto.Location = new System.Drawing.Point(555, 115);
            this.button_buscar_nombre_producto_compuesto.Name = "button_buscar_nombre_producto_compuesto";
            this.button_buscar_nombre_producto_compuesto.Size = new System.Drawing.Size(75, 23);
            this.button_buscar_nombre_producto_compuesto.TabIndex = 10;
            this.button_buscar_nombre_producto_compuesto.Text = "Buscar";
            this.button_buscar_nombre_producto_compuesto.UseVisualStyleBackColor = true;
            this.button_buscar_nombre_producto_compuesto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mozo
            // 
            this.Mozo.AutoSize = true;
            this.Mozo.Location = new System.Drawing.Point(15, 64);
            this.Mozo.Name = "Mozo";
            this.Mozo.Size = new System.Drawing.Size(33, 13);
            this.Mozo.TabIndex = 11;
            this.Mozo.Text = "Mozo";
            // 
            // textBox_mozo
            // 
            this.textBox_mozo.Location = new System.Drawing.Point(64, 64);
            this.textBox_mozo.Name = "textBox_mozo";
            this.textBox_mozo.Size = new System.Drawing.Size(100, 20);
            this.textBox_mozo.TabIndex = 12;
            // 
            // FormListaProductoCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 613);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormListaProductoCompuesto";
            this.Text = "FormListaProductoCompuesto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista_producto_compuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.Label label_categoria;
        public System.Windows.Forms.DataGridView dataGridView_lista_producto_compuesto;
        private System.Windows.Forms.Button button_buscar_nombre_producto_compuesto;
        private System.Windows.Forms.TextBox textBox_nombre_producto_compuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mozo;
        private System.Windows.Forms.TextBox textBox_mozo;
    }
}