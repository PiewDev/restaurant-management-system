namespace P3
{
    partial class FormListaProductoSimple
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
            this.groupBox_producto_simple = new System.Windows.Forms.GroupBox();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.label_categoria = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            this.dataGridView_producto_simple = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mozo = new System.Windows.Forms.TextBox();
            this.groupBox_producto_simple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_producto_simple)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_producto_simple
            // 
            this.groupBox_producto_simple.Controls.Add(this.textBox_mozo);
            this.groupBox_producto_simple.Controls.Add(this.label2);
            this.groupBox_producto_simple.Controls.Add(this.comboBox_categoria);
            this.groupBox_producto_simple.Controls.Add(this.label_categoria);
            this.groupBox_producto_simple.Controls.Add(this.button_buscar);
            this.groupBox_producto_simple.Controls.Add(this.button_cancelar);
            this.groupBox_producto_simple.Controls.Add(this.button_agregar);
            this.groupBox_producto_simple.Controls.Add(this.dataGridView_producto_simple);
            this.groupBox_producto_simple.Location = new System.Drawing.Point(258, 63);
            this.groupBox_producto_simple.Name = "groupBox_producto_simple";
            this.groupBox_producto_simple.Size = new System.Drawing.Size(658, 433);
            this.groupBox_producto_simple.TabIndex = 0;
            this.groupBox_producto_simple.TabStop = false;
            this.groupBox_producto_simple.Text = "Producto Simple";
            this.groupBox_producto_simple.Enter += new System.EventHandler(this.groupBox_producto_simple_Enter);
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Location = new System.Drawing.Point(98, 124);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_categoria.TabIndex = 7;
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Location = new System.Drawing.Point(40, 127);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(52, 13);
            this.label_categoria.TabIndex = 6;
            this.label_categoria.Text = "Categoria";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(225, 122);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 5;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(508, 373);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 2;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(413, 373);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 1;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // dataGridView_producto_simple
            // 
            this.dataGridView_producto_simple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_producto_simple.Location = new System.Drawing.Point(43, 151);
            this.dataGridView_producto_simple.Name = "dataGridView_producto_simple";
            this.dataGridView_producto_simple.Size = new System.Drawing.Size(540, 194);
            this.dataGridView_producto_simple.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mozo";
            // 
            // textBox_mozo
            // 
            this.textBox_mozo.Location = new System.Drawing.Point(98, 48);
            this.textBox_mozo.Name = "textBox_mozo";
            this.textBox_mozo.Size = new System.Drawing.Size(100, 20);
            this.textBox_mozo.TabIndex = 15;
            // 
            // FormListaProductoSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 578);
            this.Controls.Add(this.groupBox_producto_simple);
            this.Name = "FormListaProductoSimple";
            this.Text = "FormListaProductoSimple";
            this.groupBox_producto_simple.ResumeLayout(false);
            this.groupBox_producto_simple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_producto_simple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_producto_simple;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.Label label_categoria;
        public System.Windows.Forms.DataGridView dataGridView_producto_simple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mozo;
    }
}