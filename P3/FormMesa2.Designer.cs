namespace P3
{
    partial class FormMesa2
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
            this.label_Numero_Mesa = new System.Windows.Forms.Label();
            this.textBox_Numero_Mesa = new System.Windows.Forms.TextBox();
            this.button_Agregar_Mesa = new System.Windows.Forms.Button();
            this.button_Cancelar_Mesa = new System.Windows.Forms.Button();
            this.dataGridView_Mesas = new System.Windows.Forms.DataGridView();
            this.button_Modificar_Mesa = new System.Windows.Forms.Button();
            this.button_Eliminar_Mesa = new System.Windows.Forms.Button();
            this.button_Guardar_Modificado_Mesa = new System.Windows.Forms.Button();
            this.groupBox_Mesa = new System.Windows.Forms.GroupBox();
            this.textBox_ID_Mesa = new System.Windows.Forms.TextBox();
            this.label_Mesa = new System.Windows.Forms.Label();
            this.label_Buscar_Mesa = new System.Windows.Forms.Label();
            this.textBox_Buscar_Mesa = new System.Windows.Forms.TextBox();
            this.button_Buscar_Mesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Mesas)).BeginInit();
            this.groupBox_Mesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Numero_Mesa
            // 
            this.label_Numero_Mesa.AutoSize = true;
            this.label_Numero_Mesa.Location = new System.Drawing.Point(68, 61);
            this.label_Numero_Mesa.Name = "label_Numero_Mesa";
            this.label_Numero_Mesa.Size = new System.Drawing.Size(44, 13);
            this.label_Numero_Mesa.TabIndex = 0;
            this.label_Numero_Mesa.Text = "Numero";
            // 
            // textBox_Numero_Mesa
            // 
            this.textBox_Numero_Mesa.Location = new System.Drawing.Point(146, 58);
            this.textBox_Numero_Mesa.Name = "textBox_Numero_Mesa";
            this.textBox_Numero_Mesa.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numero_Mesa.TabIndex = 1;
            // 
            // button_Agregar_Mesa
            // 
            this.button_Agregar_Mesa.Location = new System.Drawing.Point(6, 106);
            this.button_Agregar_Mesa.Name = "button_Agregar_Mesa";
            this.button_Agregar_Mesa.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar_Mesa.TabIndex = 2;
            this.button_Agregar_Mesa.Text = "Agregar";
            this.button_Agregar_Mesa.UseVisualStyleBackColor = true;
            this.button_Agregar_Mesa.Click += new System.EventHandler(this.button_Agregar_Mesa_Click);
            // 
            // button_Cancelar_Mesa
            // 
            this.button_Cancelar_Mesa.Location = new System.Drawing.Point(99, 106);
            this.button_Cancelar_Mesa.Name = "button_Cancelar_Mesa";
            this.button_Cancelar_Mesa.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_Mesa.TabIndex = 3;
            this.button_Cancelar_Mesa.Text = "Cancelar";
            this.button_Cancelar_Mesa.UseVisualStyleBackColor = true;
            this.button_Cancelar_Mesa.Click += new System.EventHandler(this.button_Cancelar_Mesa_Click);
            // 
            // dataGridView_Mesas
            // 
            this.dataGridView_Mesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Mesas.Location = new System.Drawing.Point(12, 108);
            this.dataGridView_Mesas.Name = "dataGridView_Mesas";
            this.dataGridView_Mesas.Size = new System.Drawing.Size(392, 150);
            this.dataGridView_Mesas.TabIndex = 6;
            // 
            // button_Modificar_Mesa
            // 
            this.button_Modificar_Mesa.Location = new System.Drawing.Point(248, 79);
            this.button_Modificar_Mesa.Name = "button_Modificar_Mesa";
            this.button_Modificar_Mesa.Size = new System.Drawing.Size(75, 23);
            this.button_Modificar_Mesa.TabIndex = 7;
            this.button_Modificar_Mesa.Text = "Modificar";
            this.button_Modificar_Mesa.UseVisualStyleBackColor = true;
            this.button_Modificar_Mesa.Click += new System.EventHandler(this.button_Modificar_Mesa_Click);
            // 
            // button_Eliminar_Mesa
            // 
            this.button_Eliminar_Mesa.Location = new System.Drawing.Point(329, 79);
            this.button_Eliminar_Mesa.Name = "button_Eliminar_Mesa";
            this.button_Eliminar_Mesa.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar_Mesa.TabIndex = 8;
            this.button_Eliminar_Mesa.Text = "Eliminar";
            this.button_Eliminar_Mesa.UseVisualStyleBackColor = true;
            this.button_Eliminar_Mesa.Click += new System.EventHandler(this.button_Eliminar_Mesa_Click);
            // 
            // button_Guardar_Modificado_Mesa
            // 
            this.button_Guardar_Modificado_Mesa.Location = new System.Drawing.Point(180, 106);
            this.button_Guardar_Modificado_Mesa.Name = "button_Guardar_Modificado_Mesa";
            this.button_Guardar_Modificado_Mesa.Size = new System.Drawing.Size(114, 23);
            this.button_Guardar_Modificado_Mesa.TabIndex = 9;
            this.button_Guardar_Modificado_Mesa.Text = "Guardar Modificado";
            this.button_Guardar_Modificado_Mesa.UseVisualStyleBackColor = true;
            this.button_Guardar_Modificado_Mesa.Click += new System.EventHandler(this.button_Guardar_Modificado_Mesa_Click);
            // 
            // groupBox_Mesa
            // 
            this.groupBox_Mesa.Controls.Add(this.textBox_ID_Mesa);
            this.groupBox_Mesa.Controls.Add(this.label_Mesa);
            this.groupBox_Mesa.Controls.Add(this.button_Guardar_Modificado_Mesa);
            this.groupBox_Mesa.Controls.Add(this.button_Cancelar_Mesa);
            this.groupBox_Mesa.Controls.Add(this.button_Agregar_Mesa);
            this.groupBox_Mesa.Controls.Add(this.textBox_Numero_Mesa);
            this.groupBox_Mesa.Controls.Add(this.label_Numero_Mesa);
            this.groupBox_Mesa.Location = new System.Drawing.Point(436, 34);
            this.groupBox_Mesa.Name = "groupBox_Mesa";
            this.groupBox_Mesa.Size = new System.Drawing.Size(316, 150);
            this.groupBox_Mesa.TabIndex = 10;
            this.groupBox_Mesa.TabStop = false;
            this.groupBox_Mesa.Text = "Mesa";
            // 
            // textBox_ID_Mesa
            // 
            this.textBox_ID_Mesa.Location = new System.Drawing.Point(146, 19);
            this.textBox_ID_Mesa.Name = "textBox_ID_Mesa";
            this.textBox_ID_Mesa.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_Mesa.TabIndex = 11;
            // 
            // label_Mesa
            // 
            this.label_Mesa.AutoSize = true;
            this.label_Mesa.Location = new System.Drawing.Point(71, 20);
            this.label_Mesa.Name = "label_Mesa";
            this.label_Mesa.Size = new System.Drawing.Size(18, 13);
            this.label_Mesa.TabIndex = 10;
            this.label_Mesa.Text = "ID";
            // 
            // label_Buscar_Mesa
            // 
            this.label_Buscar_Mesa.AutoSize = true;
            this.label_Buscar_Mesa.Location = new System.Drawing.Point(12, 84);
            this.label_Buscar_Mesa.Name = "label_Buscar_Mesa";
            this.label_Buscar_Mesa.Size = new System.Drawing.Size(33, 13);
            this.label_Buscar_Mesa.TabIndex = 11;
            this.label_Buscar_Mesa.Text = "Mesa";
            // 
            // textBox_Buscar_Mesa
            // 
            this.textBox_Buscar_Mesa.Location = new System.Drawing.Point(52, 81);
            this.textBox_Buscar_Mesa.Name = "textBox_Buscar_Mesa";
            this.textBox_Buscar_Mesa.Size = new System.Drawing.Size(100, 20);
            this.textBox_Buscar_Mesa.TabIndex = 12;
            this.textBox_Buscar_Mesa.TextChanged += new System.EventHandler(this.textBox_Buscar_Mesa_TextChanged);
            // 
            // button_Buscar_Mesa
            // 
            this.button_Buscar_Mesa.Location = new System.Drawing.Point(158, 79);
            this.button_Buscar_Mesa.Name = "button_Buscar_Mesa";
            this.button_Buscar_Mesa.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_Mesa.TabIndex = 13;
            this.button_Buscar_Mesa.Text = "Buscar";
            this.button_Buscar_Mesa.UseVisualStyleBackColor = true;
            this.button_Buscar_Mesa.Click += new System.EventHandler(this.button_Buscar_Mesa_Click);
            // 
            // FormMesa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 275);
            this.Controls.Add(this.button_Buscar_Mesa);
            this.Controls.Add(this.textBox_Buscar_Mesa);
            this.Controls.Add(this.label_Buscar_Mesa);
            this.Controls.Add(this.groupBox_Mesa);
            this.Controls.Add(this.button_Eliminar_Mesa);
            this.Controls.Add(this.button_Modificar_Mesa);
            this.Controls.Add(this.dataGridView_Mesas);
            this.Name = "FormMesa2";
            this.Text = "FormMesa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Mesas)).EndInit();
            this.groupBox_Mesa.ResumeLayout(false);
            this.groupBox_Mesa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Numero_Mesa;
        private System.Windows.Forms.TextBox textBox_Numero_Mesa;
        private System.Windows.Forms.Button button_Agregar_Mesa;
        private System.Windows.Forms.Button button_Cancelar_Mesa;
        private System.Windows.Forms.DataGridView dataGridView_Mesas;
        private System.Windows.Forms.Button button_Modificar_Mesa;
        private System.Windows.Forms.Button button_Eliminar_Mesa;
        private System.Windows.Forms.Button button_Guardar_Modificado_Mesa;
        private System.Windows.Forms.GroupBox groupBox_Mesa;
        private System.Windows.Forms.TextBox textBox_ID_Mesa;
        private System.Windows.Forms.Label label_Mesa;
        private System.Windows.Forms.Label label_Buscar_Mesa;
        private System.Windows.Forms.TextBox textBox_Buscar_Mesa;
        private System.Windows.Forms.Button button_Buscar_Mesa;
    }
}