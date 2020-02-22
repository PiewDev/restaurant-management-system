namespace P3
{
    partial class FormMateriaPrima
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
            this.groupBox_Materia_Prima = new System.Windows.Forms.GroupBox();
            this.textBox_nombre_materia_prima = new System.Windows.Forms.TextBox();
            this.label_nombre_materia_prima = new System.Windows.Forms.Label();
            this.label_Cantidad_Materia_Prima = new System.Windows.Forms.Label();
            this.textBox_Cantidad_Materia_Prima = new System.Windows.Forms.TextBox();
            this.textBox_Costo_Materia_Prima = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion_Materia_Prima = new System.Windows.Forms.TextBox();
            this.label_Costo_Materia_Prima = new System.Windows.Forms.Label();
            this.label_Descripcion_Materia_Prima = new System.Windows.Forms.Label();
            this.textBox_ID_Materia_Prima = new System.Windows.Forms.TextBox();
            this.label_ID_Materia_Prima = new System.Windows.Forms.Label();
            this.button_Agregar_Materia_Prima = new System.Windows.Forms.Button();
            this.button_Cancelar_Materia_Prima = new System.Windows.Forms.Button();
            this.button_Guardar_Modificado_Materia_Prima = new System.Windows.Forms.Button();
            this.dataGridView_Materias_Primas = new System.Windows.Forms.DataGridView();
            this.button_Eliminar_Materia_Prima = new System.Windows.Forms.Button();
            this.button_Modificar_Materia_Prima = new System.Windows.Forms.Button();
            this.label_Buscar_Materia_Prima = new System.Windows.Forms.Label();
            this.textBox_Buscar_Materia_Prima = new System.Windows.Forms.TextBox();
            this.button_Buscar_Materia_Prima = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Materia_Prima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Materias_Primas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Materia_Prima
            // 
            this.groupBox_Materia_Prima.Controls.Add(this.textBox_nombre_materia_prima);
            this.groupBox_Materia_Prima.Controls.Add(this.label_nombre_materia_prima);
            this.groupBox_Materia_Prima.Controls.Add(this.label_Cantidad_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.textBox_Cantidad_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.textBox_Costo_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.textBox_Descripcion_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.label_Costo_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.label_Descripcion_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.textBox_ID_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.label_ID_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.button_Agregar_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.button_Cancelar_Materia_Prima);
            this.groupBox_Materia_Prima.Controls.Add(this.button_Guardar_Modificado_Materia_Prima);
            this.groupBox_Materia_Prima.Location = new System.Drawing.Point(441, 35);
            this.groupBox_Materia_Prima.Name = "groupBox_Materia_Prima";
            this.groupBox_Materia_Prima.Size = new System.Drawing.Size(347, 361);
            this.groupBox_Materia_Prima.TabIndex = 0;
            this.groupBox_Materia_Prima.TabStop = false;
            this.groupBox_Materia_Prima.Text = "Materia Prima";
            // 
            // textBox_nombre_materia_prima
            // 
            this.textBox_nombre_materia_prima.Location = new System.Drawing.Point(157, 65);
            this.textBox_nombre_materia_prima.Name = "textBox_nombre_materia_prima";
            this.textBox_nombre_materia_prima.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre_materia_prima.TabIndex = 18;
            // 
            // label_nombre_materia_prima
            // 
            this.label_nombre_materia_prima.AutoSize = true;
            this.label_nombre_materia_prima.Location = new System.Drawing.Point(80, 65);
            this.label_nombre_materia_prima.Name = "label_nombre_materia_prima";
            this.label_nombre_materia_prima.Size = new System.Drawing.Size(44, 13);
            this.label_nombre_materia_prima.TabIndex = 17;
            this.label_nombre_materia_prima.Text = "Nombre";
            // 
            // label_Cantidad_Materia_Prima
            // 
            this.label_Cantidad_Materia_Prima.AutoSize = true;
            this.label_Cantidad_Materia_Prima.Location = new System.Drawing.Point(77, 227);
            this.label_Cantidad_Materia_Prima.Name = "label_Cantidad_Materia_Prima";
            this.label_Cantidad_Materia_Prima.Size = new System.Drawing.Size(49, 13);
            this.label_Cantidad_Materia_Prima.TabIndex = 12;
            this.label_Cantidad_Materia_Prima.Text = "Cantidad";
            // 
            // textBox_Cantidad_Materia_Prima
            // 
            this.textBox_Cantidad_Materia_Prima.Location = new System.Drawing.Point(157, 227);
            this.textBox_Cantidad_Materia_Prima.Name = "textBox_Cantidad_Materia_Prima";
            this.textBox_Cantidad_Materia_Prima.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cantidad_Materia_Prima.TabIndex = 11;
            // 
            // textBox_Costo_Materia_Prima
            // 
            this.textBox_Costo_Materia_Prima.Location = new System.Drawing.Point(157, 188);
            this.textBox_Costo_Materia_Prima.Name = "textBox_Costo_Materia_Prima";
            this.textBox_Costo_Materia_Prima.Size = new System.Drawing.Size(100, 20);
            this.textBox_Costo_Materia_Prima.TabIndex = 10;
            // 
            // textBox_Descripcion_Materia_Prima
            // 
            this.textBox_Descripcion_Materia_Prima.Location = new System.Drawing.Point(157, 144);
            this.textBox_Descripcion_Materia_Prima.Name = "textBox_Descripcion_Materia_Prima";
            this.textBox_Descripcion_Materia_Prima.Size = new System.Drawing.Size(100, 20);
            this.textBox_Descripcion_Materia_Prima.TabIndex = 9;
            // 
            // label_Costo_Materia_Prima
            // 
            this.label_Costo_Materia_Prima.AutoSize = true;
            this.label_Costo_Materia_Prima.Location = new System.Drawing.Point(77, 188);
            this.label_Costo_Materia_Prima.Name = "label_Costo_Materia_Prima";
            this.label_Costo_Materia_Prima.Size = new System.Drawing.Size(34, 13);
            this.label_Costo_Materia_Prima.TabIndex = 8;
            this.label_Costo_Materia_Prima.Text = "Costo";
            // 
            // label_Descripcion_Materia_Prima
            // 
            this.label_Descripcion_Materia_Prima.AutoSize = true;
            this.label_Descripcion_Materia_Prima.Location = new System.Drawing.Point(77, 144);
            this.label_Descripcion_Materia_Prima.Name = "label_Descripcion_Materia_Prima";
            this.label_Descripcion_Materia_Prima.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion_Materia_Prima.TabIndex = 7;
            this.label_Descripcion_Materia_Prima.Text = "Descripcion";
            // 
            // textBox_ID_Materia_Prima
            // 
            this.textBox_ID_Materia_Prima.Location = new System.Drawing.Point(157, 26);
            this.textBox_ID_Materia_Prima.Name = "textBox_ID_Materia_Prima";
            this.textBox_ID_Materia_Prima.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_Materia_Prima.TabIndex = 4;
            // 
            // label_ID_Materia_Prima
            // 
            this.label_ID_Materia_Prima.AutoSize = true;
            this.label_ID_Materia_Prima.Location = new System.Drawing.Point(80, 29);
            this.label_ID_Materia_Prima.Name = "label_ID_Materia_Prima";
            this.label_ID_Materia_Prima.Size = new System.Drawing.Size(18, 13);
            this.label_ID_Materia_Prima.TabIndex = 3;
            this.label_ID_Materia_Prima.Text = "ID";
            // 
            // button_Agregar_Materia_Prima
            // 
            this.button_Agregar_Materia_Prima.Location = new System.Drawing.Point(23, 284);
            this.button_Agregar_Materia_Prima.Name = "button_Agregar_Materia_Prima";
            this.button_Agregar_Materia_Prima.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar_Materia_Prima.TabIndex = 2;
            this.button_Agregar_Materia_Prima.Text = "Agregar";
            this.button_Agregar_Materia_Prima.UseVisualStyleBackColor = true;
            this.button_Agregar_Materia_Prima.Click += new System.EventHandler(this.button_Agregar_Materia_Prima_Click);
            // 
            // button_Cancelar_Materia_Prima
            // 
            this.button_Cancelar_Materia_Prima.Location = new System.Drawing.Point(123, 284);
            this.button_Cancelar_Materia_Prima.Name = "button_Cancelar_Materia_Prima";
            this.button_Cancelar_Materia_Prima.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_Materia_Prima.TabIndex = 1;
            this.button_Cancelar_Materia_Prima.Text = "Cancelar";
            this.button_Cancelar_Materia_Prima.UseVisualStyleBackColor = true;
            this.button_Cancelar_Materia_Prima.Click += new System.EventHandler(this.button_Cancelar_Materia_Prima_Click);
            // 
            // button_Guardar_Modificado_Materia_Prima
            // 
            this.button_Guardar_Modificado_Materia_Prima.Location = new System.Drawing.Point(216, 284);
            this.button_Guardar_Modificado_Materia_Prima.Name = "button_Guardar_Modificado_Materia_Prima";
            this.button_Guardar_Modificado_Materia_Prima.Size = new System.Drawing.Size(125, 23);
            this.button_Guardar_Modificado_Materia_Prima.TabIndex = 0;
            this.button_Guardar_Modificado_Materia_Prima.Text = "Guardar Modificado";
            this.button_Guardar_Modificado_Materia_Prima.UseVisualStyleBackColor = true;
            this.button_Guardar_Modificado_Materia_Prima.Click += new System.EventHandler(this.button_Guardar_Modificado_Materia_Prima_Click);
            // 
            // dataGridView_Materias_Primas
            // 
            this.dataGridView_Materias_Primas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Materias_Primas.Location = new System.Drawing.Point(12, 87);
            this.dataGridView_Materias_Primas.Name = "dataGridView_Materias_Primas";
            this.dataGridView_Materias_Primas.Size = new System.Drawing.Size(423, 255);
            this.dataGridView_Materias_Primas.TabIndex = 1;
            // 
            // button_Eliminar_Materia_Prima
            // 
            this.button_Eliminar_Materia_Prima.Location = new System.Drawing.Point(360, 58);
            this.button_Eliminar_Materia_Prima.Name = "button_Eliminar_Materia_Prima";
            this.button_Eliminar_Materia_Prima.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar_Materia_Prima.TabIndex = 2;
            this.button_Eliminar_Materia_Prima.Text = "Eliminar";
            this.button_Eliminar_Materia_Prima.UseVisualStyleBackColor = true;
            this.button_Eliminar_Materia_Prima.Click += new System.EventHandler(this.button_Eliminar_Materia_Prima_Click);
            // 
            // button_Modificar_Materia_Prima
            // 
            this.button_Modificar_Materia_Prima.Location = new System.Drawing.Point(279, 58);
            this.button_Modificar_Materia_Prima.Name = "button_Modificar_Materia_Prima";
            this.button_Modificar_Materia_Prima.Size = new System.Drawing.Size(75, 23);
            this.button_Modificar_Materia_Prima.TabIndex = 3;
            this.button_Modificar_Materia_Prima.Text = "Modificar";
            this.button_Modificar_Materia_Prima.UseVisualStyleBackColor = true;
            this.button_Modificar_Materia_Prima.Click += new System.EventHandler(this.button_Modificar_Materia_Prima_Click);
            // 
            // label_Buscar_Materia_Prima
            // 
            this.label_Buscar_Materia_Prima.AutoSize = true;
            this.label_Buscar_Materia_Prima.Location = new System.Drawing.Point(12, 64);
            this.label_Buscar_Materia_Prima.Name = "label_Buscar_Materia_Prima";
            this.label_Buscar_Materia_Prima.Size = new System.Drawing.Size(71, 13);
            this.label_Buscar_Materia_Prima.TabIndex = 4;
            this.label_Buscar_Materia_Prima.Text = "Materia Prima";
            // 
            // textBox_Buscar_Materia_Prima
            // 
            this.textBox_Buscar_Materia_Prima.Location = new System.Drawing.Point(89, 61);
            this.textBox_Buscar_Materia_Prima.Name = "textBox_Buscar_Materia_Prima";
            this.textBox_Buscar_Materia_Prima.Size = new System.Drawing.Size(100, 20);
            this.textBox_Buscar_Materia_Prima.TabIndex = 5;
            this.textBox_Buscar_Materia_Prima.TextChanged += new System.EventHandler(this.textBox_Buscar_Materia_Prima_TextChanged);
            // 
            // button_Buscar_Materia_Prima
            // 
            this.button_Buscar_Materia_Prima.Location = new System.Drawing.Point(196, 58);
            this.button_Buscar_Materia_Prima.Name = "button_Buscar_Materia_Prima";
            this.button_Buscar_Materia_Prima.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_Materia_Prima.TabIndex = 6;
            this.button_Buscar_Materia_Prima.Text = "Buscar";
            this.button_Buscar_Materia_Prima.UseVisualStyleBackColor = true;
            this.button_Buscar_Materia_Prima.Click += new System.EventHandler(this.button_Buscar_Materia_Prima_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FormMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.button_Buscar_Materia_Prima);
            this.Controls.Add(this.textBox_Buscar_Materia_Prima);
            this.Controls.Add(this.label_Buscar_Materia_Prima);
            this.Controls.Add(this.button_Modificar_Materia_Prima);
            this.Controls.Add(this.button_Eliminar_Materia_Prima);
            this.Controls.Add(this.dataGridView_Materias_Primas);
            this.Controls.Add(this.groupBox_Materia_Prima);
            this.Name = "FormMateriaPrima";
            this.Text = "FormMateriaPrima";
            this.groupBox_Materia_Prima.ResumeLayout(false);
            this.groupBox_Materia_Prima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Materias_Primas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Materia_Prima;
        private System.Windows.Forms.Label label_ID_Materia_Prima;
        private System.Windows.Forms.Button button_Agregar_Materia_Prima;
        private System.Windows.Forms.Button button_Cancelar_Materia_Prima;
        private System.Windows.Forms.Button button_Guardar_Modificado_Materia_Prima;
        private System.Windows.Forms.Label label_Cantidad_Materia_Prima;
        private System.Windows.Forms.TextBox textBox_Cantidad_Materia_Prima;
        private System.Windows.Forms.TextBox textBox_Costo_Materia_Prima;
        private System.Windows.Forms.TextBox textBox_Descripcion_Materia_Prima;
        private System.Windows.Forms.Label label_Costo_Materia_Prima;
        private System.Windows.Forms.Label label_Descripcion_Materia_Prima;
        private System.Windows.Forms.TextBox textBox_ID_Materia_Prima;
        private System.Windows.Forms.DataGridView dataGridView_Materias_Primas;
        private System.Windows.Forms.Button button_Eliminar_Materia_Prima;
        private System.Windows.Forms.Button button_Modificar_Materia_Prima;
        private System.Windows.Forms.Label label_Buscar_Materia_Prima;
        private System.Windows.Forms.TextBox textBox_Buscar_Materia_Prima;
        private System.Windows.Forms.Button button_Buscar_Materia_Prima;
        private System.Windows.Forms.TextBox textBox_nombre_materia_prima;
        private System.Windows.Forms.Label label_nombre_materia_prima;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}