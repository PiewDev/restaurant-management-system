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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_agregar_ingredientes = new System.Windows.Forms.Button();
            this.dataGridView_armar = new System.Windows.Forms.DataGridView();
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
            this.LabelCosto = new System.Windows.Forms.Label();
            this.test_Final_Programacion_3DataSet = new P3.Test_Final_Programacion_3DataSet();
            this.materiaPrima2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaPrima2TableAdapter = new P3.Test_Final_Programacion_3DataSetTableAdapters.MateriaPrima2TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_armar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_Final_Programacion_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrima2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LabelCosto);
            this.groupBox1.Controls.Add(this.comboBoxMateria);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.button_eliminar);
            this.groupBox1.Controls.Add(this.button_agregar_ingredientes);
            this.groupBox1.Controls.Add(this.dataGridView_armar);
            this.groupBox1.Location = new System.Drawing.Point(6, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes";
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBoxMateria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materiaPrima2BindingSource, "costo", true));
            this.comboBoxMateria.DataSource = this.materiaPrima2BindingSource;
            this.comboBoxMateria.DisplayMember = "nombre";
            this.comboBoxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(24, 30);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxMateria.Size = new System.Drawing.Size(93, 21);
            this.comboBoxMateria.TabIndex = 5;
            this.comboBoxMateria.ValueMember = "costo";
            this.comboBoxMateria.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateria_SelectedIndexChanged);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(140, 31);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(39, 20);
            this.textBoxCantidad.TabIndex = 3;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress_1);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(242, 309);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 2;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click_1);
            // 
            // button_agregar_ingredientes
            // 
            this.button_agregar_ingredientes.Location = new System.Drawing.Point(199, 30);
            this.button_agregar_ingredientes.Name = "button_agregar_ingredientes";
            this.button_agregar_ingredientes.Size = new System.Drawing.Size(118, 23);
            this.button_agregar_ingredientes.TabIndex = 1;
            this.button_agregar_ingredientes.Text = "Agregar Ingredientes";
            this.button_agregar_ingredientes.UseVisualStyleBackColor = true;
            this.button_agregar_ingredientes.Click += new System.EventHandler(this.button_agregar_ingredientes_Click);
            // 
            // dataGridView_armar
            // 
            this.dataGridView_armar.AllowUserToAddRows = false;
            this.dataGridView_armar.AllowUserToDeleteRows = false;
            this.dataGridView_armar.AllowUserToResizeColumns = false;
            this.dataGridView_armar.AllowUserToResizeRows = false;
            this.dataGridView_armar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_armar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView_armar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_armar.Location = new System.Drawing.Point(25, 67);
            this.dataGridView_armar.MultiSelect = false;
            this.dataGridView_armar.Name = "dataGridView_armar";
            this.dataGridView_armar.ReadOnly = true;
            this.dataGridView_armar.Size = new System.Drawing.Size(286, 236);
            this.dataGridView_armar.TabIndex = 0;
            this.dataGridView_armar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Location = new System.Drawing.Point(62, 74);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(52, 13);
            this.label_categoria.TabIndex = 1;
            this.label_categoria.Text = "Categoria";
            // 
            // label_costo
            // 
            this.label_costo.AutoSize = true;
            this.label_costo.Location = new System.Drawing.Point(62, 115);
            this.label_costo.Name = "label_costo";
            this.label_costo.Size = new System.Drawing.Size(61, 13);
            this.label_costo.TabIndex = 2;
            this.label_costo.Text = "Costo Extra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Venta";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(136, 34);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(121, 20);
            this.textBox_nombre.TabIndex = 4;
            this.textBox_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombre_KeyPress);
            // 
            // textBox_costo
            // 
            this.textBox_costo.Location = new System.Drawing.Point(136, 112);
            this.textBox_costo.Name = "textBox_costo";
            this.textBox_costo.Size = new System.Drawing.Size(49, 20);
            this.textBox_costo.TabIndex = 5;
            this.textBox_costo.TextChanged += new System.EventHandler(this.textBox_costo_TextChanged);
            this.textBox_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress_1);
            // 
            // textBox_precio_venta
            // 
            this.textBox_precio_venta.Location = new System.Drawing.Point(136, 155);
            this.textBox_precio_venta.Name = "textBox_precio_venta";
            this.textBox_precio_venta.Size = new System.Drawing.Size(49, 20);
            this.textBox_precio_venta.TabIndex = 6;
            this.textBox_precio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precio_venta_KeyPress);
            // 
            // comboBox_categorias
            // 
            this.comboBox_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_categorias.FormattingEnabled = true;
            this.comboBox_categorias.Location = new System.Drawing.Point(136, 71);
            this.comboBox_categorias.Name = "comboBox_categorias";
            this.comboBox_categorias.Size = new System.Drawing.Size(121, 21);
            this.comboBox_categorias.TabIndex = 7;
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(264, 568);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar.TabIndex = 8;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(166, 568);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 9;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 603);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre Producto";
            // 
            // LabelCosto
            // 
            this.LabelCosto.BackColor = System.Drawing.SystemColors.Window;
            this.LabelCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCosto.Location = new System.Drawing.Point(30, 324);
            this.LabelCosto.Name = "LabelCosto";
            this.LabelCosto.Size = new System.Drawing.Size(85, 20);
            this.LabelCosto.TabIndex = 10;
            this.LabelCosto.Text = "       ";
            // 
            // test_Final_Programacion_3DataSet
            // 
            this.test_Final_Programacion_3DataSet.DataSetName = "Test_Final_Programacion_3DataSet";
            this.test_Final_Programacion_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaPrima2BindingSource
            // 
            this.materiaPrima2BindingSource.DataMember = "MateriaPrima2";
            this.materiaPrima2BindingSource.DataSource = this.test_Final_Programacion_3DataSet;
            // 
            // materiaPrima2TableAdapter
            // 
            this.materiaPrima2TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Costo Total";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormArmarProductoCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 615);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormArmarProductoCompuesto";
            this.Text = "FormArmarProductoCompuesto";
            this.Load += new System.EventHandler(this.FormArmarProductoCompuesto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_armar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_Final_Programacion_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrima2BindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label LabelCosto;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private Test_Final_Programacion_3DataSet test_Final_Programacion_3DataSet;
        private System.Windows.Forms.BindingSource materiaPrima2BindingSource;
        private Test_Final_Programacion_3DataSetTableAdapters.MateriaPrima2TableAdapter materiaPrima2TableAdapter;
        private System.Windows.Forms.Label label2;
    }
}