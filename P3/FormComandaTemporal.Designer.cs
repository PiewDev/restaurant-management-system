namespace P3
{
    partial class FormComandaTemporal
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Nro_Comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label_valor_nro_mesa = new System.Windows.Forms.Label();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Comanda,
            this.Cod_Producto,
            this.Nombre,
            this.Tipo,
            this.Precio,
            this.Subtotal});
            this.dataGridViewProductos.Location = new System.Drawing.Point(32, 127);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProductos.Size = new System.Drawing.Size(643, 176);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_temporal_CellContentClick);
            // 
            // Nro_Comanda
            // 
            this.Nro_Comanda.HeaderText = "N° Comanda";
            this.Nro_Comanda.Name = "Nro_Comanda";
            this.Nro_Comanda.ReadOnly = true;
            // 
            // Cod_Producto
            // 
            this.Cod_Producto.HeaderText = "Cod. Producto";
            this.Cod_Producto.Name = "Cod_Producto";
            this.Cod_Producto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoría: ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(61, 591);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Generar Comanda";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(542, 591);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(129, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar Comanda";
            this.buttonCancelar.UseMnemonic = false;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button6_Click);
            // 
            // label_valor_nro_mesa
            // 
            this.label_valor_nro_mesa.AutoSize = true;
            this.label_valor_nro_mesa.Location = new System.Drawing.Point(310, 18);
            this.label_valor_nro_mesa.Name = "label_valor_nro_mesa";
            this.label_valor_nro_mesa.Size = new System.Drawing.Size(35, 13);
            this.label_valor_nro_mesa.TabIndex = 31;
            this.label_valor_nro_mesa.Text = "label1";
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(28, 86);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategorias.TabIndex = 32;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(190, 322);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 33;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(383, 322);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitar.TabIndex = 33;
            this.buttonQuitar.Text = "Quitar";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            // 
            // FormComandaTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 671);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.label_valor_nro_mesa);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "FormComandaTemporal";
            this.Text = "Comanda";
            this.Load += new System.EventHandler(this.FormComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label_valor_nro_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonQuitar;
    }
}