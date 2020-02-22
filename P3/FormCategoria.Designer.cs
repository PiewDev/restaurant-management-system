namespace P3
{
    partial class FormCategoria
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
            this.groupBox_Categoria = new System.Windows.Forms.GroupBox();
            this.button_Agregar_Categoria = new System.Windows.Forms.Button();
            this.button_Cancelar_Categoria = new System.Windows.Forms.Button();
            this.button_Guardar_Modificado_Categoria = new System.Windows.Forms.Button();
            this.textBox_Nombre_Categoria = new System.Windows.Forms.TextBox();
            this.textBox_ID_Categoria = new System.Windows.Forms.TextBox();
            this.label_Nombre_Categoria = new System.Windows.Forms.Label();
            this.label_ID_Categoria = new System.Windows.Forms.Label();
            this.dataGridView_Categoria = new System.Windows.Forms.DataGridView();
            this.button_Eliminar_Categoria = new System.Windows.Forms.Button();
            this.button_Modificar_Categoria = new System.Windows.Forms.Button();
            this.label_Buscar_Categoria = new System.Windows.Forms.Label();
            this.textBox_Buscar_Categoria = new System.Windows.Forms.TextBox();
            this.button_Buscar_Categoria = new System.Windows.Forms.Button();
            this.label_simple_compuesto = new System.Windows.Forms.Label();
            this.textBox_simple_compuesto = new System.Windows.Forms.TextBox();
            this.groupBox_Categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Categoria
            // 
            this.groupBox_Categoria.Controls.Add(this.textBox_simple_compuesto);
            this.groupBox_Categoria.Controls.Add(this.label_simple_compuesto);
            this.groupBox_Categoria.Controls.Add(this.button_Agregar_Categoria);
            this.groupBox_Categoria.Controls.Add(this.button_Cancelar_Categoria);
            this.groupBox_Categoria.Controls.Add(this.button_Guardar_Modificado_Categoria);
            this.groupBox_Categoria.Controls.Add(this.textBox_Nombre_Categoria);
            this.groupBox_Categoria.Controls.Add(this.textBox_ID_Categoria);
            this.groupBox_Categoria.Controls.Add(this.label_Nombre_Categoria);
            this.groupBox_Categoria.Controls.Add(this.label_ID_Categoria);
            this.groupBox_Categoria.Location = new System.Drawing.Point(461, 23);
            this.groupBox_Categoria.Name = "groupBox_Categoria";
            this.groupBox_Categoria.Size = new System.Drawing.Size(327, 219);
            this.groupBox_Categoria.TabIndex = 0;
            this.groupBox_Categoria.TabStop = false;
            this.groupBox_Categoria.Text = "Categoria";
            // 
            // button_Agregar_Categoria
            // 
            this.button_Agregar_Categoria.Location = new System.Drawing.Point(27, 172);
            this.button_Agregar_Categoria.Name = "button_Agregar_Categoria";
            this.button_Agregar_Categoria.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar_Categoria.TabIndex = 6;
            this.button_Agregar_Categoria.Text = "Agregar";
            this.button_Agregar_Categoria.UseVisualStyleBackColor = true;
            this.button_Agregar_Categoria.Click += new System.EventHandler(this.button_Agregar_Categoria_Click);
            // 
            // button_Cancelar_Categoria
            // 
            this.button_Cancelar_Categoria.Location = new System.Drawing.Point(108, 172);
            this.button_Cancelar_Categoria.Name = "button_Cancelar_Categoria";
            this.button_Cancelar_Categoria.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_Categoria.TabIndex = 5;
            this.button_Cancelar_Categoria.Text = "Cancelar";
            this.button_Cancelar_Categoria.UseVisualStyleBackColor = true;
            this.button_Cancelar_Categoria.Click += new System.EventHandler(this.button_Cancelar_Categoria_Click);
            // 
            // button_Guardar_Modificado_Categoria
            // 
            this.button_Guardar_Modificado_Categoria.Location = new System.Drawing.Point(189, 172);
            this.button_Guardar_Modificado_Categoria.Name = "button_Guardar_Modificado_Categoria";
            this.button_Guardar_Modificado_Categoria.Size = new System.Drawing.Size(112, 23);
            this.button_Guardar_Modificado_Categoria.TabIndex = 4;
            this.button_Guardar_Modificado_Categoria.Text = "Guardar Modificado";
            this.button_Guardar_Modificado_Categoria.UseVisualStyleBackColor = true;
            this.button_Guardar_Modificado_Categoria.Click += new System.EventHandler(this.button_Guardar_Modificado_Categoria_Click);
            // 
            // textBox_Nombre_Categoria
            // 
            this.textBox_Nombre_Categoria.Location = new System.Drawing.Point(154, 82);
            this.textBox_Nombre_Categoria.Name = "textBox_Nombre_Categoria";
            this.textBox_Nombre_Categoria.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre_Categoria.TabIndex = 3;
            // 
            // textBox_ID_Categoria
            // 
            this.textBox_ID_Categoria.Location = new System.Drawing.Point(154, 40);
            this.textBox_ID_Categoria.Name = "textBox_ID_Categoria";
            this.textBox_ID_Categoria.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_Categoria.TabIndex = 2;
            // 
            // label_Nombre_Categoria
            // 
            this.label_Nombre_Categoria.AutoSize = true;
            this.label_Nombre_Categoria.Location = new System.Drawing.Point(58, 85);
            this.label_Nombre_Categoria.Name = "label_Nombre_Categoria";
            this.label_Nombre_Categoria.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre_Categoria.TabIndex = 1;
            this.label_Nombre_Categoria.Text = "Nombre";
            // 
            // label_ID_Categoria
            // 
            this.label_ID_Categoria.AutoSize = true;
            this.label_ID_Categoria.Location = new System.Drawing.Point(64, 40);
            this.label_ID_Categoria.Name = "label_ID_Categoria";
            this.label_ID_Categoria.Size = new System.Drawing.Size(18, 13);
            this.label_ID_Categoria.TabIndex = 0;
            this.label_ID_Categoria.Text = "ID";
            // 
            // dataGridView_Categoria
            // 
            this.dataGridView_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categoria.Location = new System.Drawing.Point(12, 62);
            this.dataGridView_Categoria.Name = "dataGridView_Categoria";
            this.dataGridView_Categoria.Size = new System.Drawing.Size(428, 180);
            this.dataGridView_Categoria.TabIndex = 1;
            // 
            // button_Eliminar_Categoria
            // 
            this.button_Eliminar_Categoria.Location = new System.Drawing.Point(357, 33);
            this.button_Eliminar_Categoria.Name = "button_Eliminar_Categoria";
            this.button_Eliminar_Categoria.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar_Categoria.TabIndex = 2;
            this.button_Eliminar_Categoria.Text = "Eliminar";
            this.button_Eliminar_Categoria.UseVisualStyleBackColor = true;
            this.button_Eliminar_Categoria.Click += new System.EventHandler(this.button_Eliminar_Categoria_Click);
            // 
            // button_Modificar_Categoria
            // 
            this.button_Modificar_Categoria.Location = new System.Drawing.Point(276, 33);
            this.button_Modificar_Categoria.Name = "button_Modificar_Categoria";
            this.button_Modificar_Categoria.Size = new System.Drawing.Size(75, 23);
            this.button_Modificar_Categoria.TabIndex = 3;
            this.button_Modificar_Categoria.Text = "Modificar";
            this.button_Modificar_Categoria.UseVisualStyleBackColor = true;
            this.button_Modificar_Categoria.Click += new System.EventHandler(this.button_Modificar_Categoria_Click);
            // 
            // label_Buscar_Categoria
            // 
            this.label_Buscar_Categoria.AutoSize = true;
            this.label_Buscar_Categoria.Location = new System.Drawing.Point(13, 33);
            this.label_Buscar_Categoria.Name = "label_Buscar_Categoria";
            this.label_Buscar_Categoria.Size = new System.Drawing.Size(52, 13);
            this.label_Buscar_Categoria.TabIndex = 4;
            this.label_Buscar_Categoria.Text = "Categoria";
            // 
            // textBox_Buscar_Categoria
            // 
            this.textBox_Buscar_Categoria.Location = new System.Drawing.Point(71, 30);
            this.textBox_Buscar_Categoria.Name = "textBox_Buscar_Categoria";
            this.textBox_Buscar_Categoria.Size = new System.Drawing.Size(100, 20);
            this.textBox_Buscar_Categoria.TabIndex = 5;
            this.textBox_Buscar_Categoria.TextChanged += new System.EventHandler(this.textBox_Buscar_Categoria_TextChanged);
            // 
            // button_Buscar_Categoria
            // 
            this.button_Buscar_Categoria.Location = new System.Drawing.Point(177, 30);
            this.button_Buscar_Categoria.Name = "button_Buscar_Categoria";
            this.button_Buscar_Categoria.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_Categoria.TabIndex = 6;
            this.button_Buscar_Categoria.Text = "Buscar";
            this.button_Buscar_Categoria.UseVisualStyleBackColor = true;
            this.button_Buscar_Categoria.Click += new System.EventHandler(this.button_Buscar_Categoria_Click);
            // 
            // label_simple_compuesto
            // 
            this.label_simple_compuesto.AutoSize = true;
            this.label_simple_compuesto.Location = new System.Drawing.Point(45, 124);
            this.label_simple_compuesto.Name = "label_simple_compuesto";
            this.label_simple_compuesto.Size = new System.Drawing.Size(103, 13);
            this.label_simple_compuesto.TabIndex = 7;
            this.label_simple_compuesto.Text = "Simple o Compuesto";
            // 
            // textBox_simple_compuesto
            // 
            this.textBox_simple_compuesto.Location = new System.Drawing.Point(154, 116);
            this.textBox_simple_compuesto.Name = "textBox_simple_compuesto";
            this.textBox_simple_compuesto.Size = new System.Drawing.Size(100, 20);
            this.textBox_simple_compuesto.TabIndex = 8;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.button_Buscar_Categoria);
            this.Controls.Add(this.textBox_Buscar_Categoria);
            this.Controls.Add(this.label_Buscar_Categoria);
            this.Controls.Add(this.button_Modificar_Categoria);
            this.Controls.Add(this.button_Eliminar_Categoria);
            this.Controls.Add(this.dataGridView_Categoria);
            this.Controls.Add(this.groupBox_Categoria);
            this.Name = "FormCategoria";
            this.Text = "FormCategoria";
            this.groupBox_Categoria.ResumeLayout(false);
            this.groupBox_Categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Categoria;
        private System.Windows.Forms.Button button_Agregar_Categoria;
        private System.Windows.Forms.Button button_Cancelar_Categoria;
        private System.Windows.Forms.Button button_Guardar_Modificado_Categoria;
        private System.Windows.Forms.TextBox textBox_Nombre_Categoria;
        private System.Windows.Forms.TextBox textBox_ID_Categoria;
        private System.Windows.Forms.Label label_Nombre_Categoria;
        private System.Windows.Forms.Label label_ID_Categoria;
        private System.Windows.Forms.DataGridView dataGridView_Categoria;
        private System.Windows.Forms.Button button_Eliminar_Categoria;
        private System.Windows.Forms.Button button_Modificar_Categoria;
        private System.Windows.Forms.Label label_Buscar_Categoria;
        private System.Windows.Forms.TextBox textBox_Buscar_Categoria;
        private System.Windows.Forms.Button button_Buscar_Categoria;
        private System.Windows.Forms.Label label_simple_compuesto;
        private System.Windows.Forms.TextBox textBox_simple_compuesto;
    }
}