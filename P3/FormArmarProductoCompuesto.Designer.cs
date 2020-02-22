namespace P3
{
    partial class FormArmarProductoCompuesto
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
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_agregar_ingredientes = new System.Windows.Forms.Button();
            this.dataGridView_armar = new System.Windows.Forms.DataGridView();
            this.id_materiaprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label_categoria = new System.Windows.Forms.Label();
            this.label_costo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_costo = new System.Windows.Forms.TextBox();
            this.textBox_precio_venta = new System.Windows.Forms.TextBox();
            this.comboBox_categorias = new System.Windows.Forms.ComboBox();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_armar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_eliminar);
            this.groupBox1.Controls.Add(this.button_agregar_ingredientes);
            this.groupBox1.Controls.Add(this.dataGridView_armar);
            this.groupBox1.Location = new System.Drawing.Point(95, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes";
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(589, 55);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 2;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            // 
            // button_agregar_ingredientes
            // 
            this.button_agregar_ingredientes.Location = new System.Drawing.Point(281, 45);
            this.button_agregar_ingredientes.Name = "button_agregar_ingredientes";
            this.button_agregar_ingredientes.Size = new System.Drawing.Size(145, 23);
            this.button_agregar_ingredientes.TabIndex = 1;
            this.button_agregar_ingredientes.Text = "Agregar Ingredientes";
            this.button_agregar_ingredientes.UseVisualStyleBackColor = true;
            this.button_agregar_ingredientes.Click += new System.EventHandler(this.button_agregar_ingredientes_Click);
            // 
            // dataGridView_armar
            // 
            this.dataGridView_armar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_armar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materiaprima,
            this.cantidad});
            this.dataGridView_armar.Location = new System.Drawing.Point(6, 84);
            this.dataGridView_armar.Name = "dataGridView_armar";
            this.dataGridView_armar.Size = new System.Drawing.Size(667, 236);
            this.dataGridView_armar.TabIndex = 0;
            this.dataGridView_armar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_materiaprima
            // 
            this.id_materiaprima.HeaderText = "id_materiaprima";
            this.id_materiaprima.Name = "id_materiaprima";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Location = new System.Drawing.Point(37, 87);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(52, 13);
            this.label_categoria.TabIndex = 1;
            this.label_categoria.Text = "Categoria";
            // 
            // label_costo
            // 
            this.label_costo.AutoSize = true;
            this.label_costo.Location = new System.Drawing.Point(37, 128);
            this.label_costo.Name = "label_costo";
            this.label_costo.Size = new System.Drawing.Size(34, 13);
            this.label_costo.TabIndex = 2;
            this.label_costo.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Venta";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(111, 50);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 4;
            // 
            // textBox_costo
            // 
            this.textBox_costo.Location = new System.Drawing.Point(111, 128);
            this.textBox_costo.Name = "textBox_costo";
            this.textBox_costo.Size = new System.Drawing.Size(100, 20);
            this.textBox_costo.TabIndex = 5;
            // 
            // textBox_precio_venta
            // 
            this.textBox_precio_venta.Location = new System.Drawing.Point(111, 164);
            this.textBox_precio_venta.Name = "textBox_precio_venta";
            this.textBox_precio_venta.Size = new System.Drawing.Size(100, 20);
            this.textBox_precio_venta.TabIndex = 6;
            // 
            // comboBox_categorias
            // 
            this.comboBox_categorias.FormattingEnabled = true;
            this.comboBox_categorias.Location = new System.Drawing.Point(111, 87);
            this.comboBox_categorias.Name = "comboBox_categorias";
            this.comboBox_categorias.Size = new System.Drawing.Size(121, 21);
            this.comboBox_categorias.TabIndex = 7;
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(54, 218);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar.TabIndex = 8;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(157, 218);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 9;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_cancelar);
            this.groupBox2.Controls.Add(this.label_categoria);
            this.groupBox2.Controls.Add(this.button_aceptar);
            this.groupBox2.Controls.Add(this.label_costo);
            this.groupBox2.Controls.Add(this.textBox_precio_venta);
            this.groupBox2.Controls.Add(this.comboBox_categorias);
            this.groupBox2.Controls.Add(this.textBox_costo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_nombre);
            this.groupBox2.Location = new System.Drawing.Point(874, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 280);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre Producto";
            // 
            // FormArmarProductoCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormArmarProductoCompuesto";
            this.Text = "FormArmarProductoCompuesto";
            this.Load += new System.EventHandler(this.FormArmarProductoCompuesto_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_armar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Label label_costo;
        private System.Windows.Forms.TextBox textBox_precio_venta;
        private System.Windows.Forms.ComboBox comboBox_categorias;
        private System.Windows.Forms.TextBox textBox_costo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_agregar_ingredientes;
        public System.Windows.Forms.DataGridView dataGridView_armar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materiaprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}