namespace P3
{
    partial class FormListaMateriaPrima
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
            this.label_nombre = new System.Windows.Forms.Label();
            this.comboBox_ingrediente = new System.Windows.Forms.ComboBox();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.button_agregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_agregar);
            this.groupBox1.Controls.Add(this.textBox_cantidad);
            this.groupBox1.Controls.Add(this.label_cantidad);
            this.groupBox1.Controls.Add(this.comboBox_ingrediente);
            this.groupBox1.Controls.Add(this.label_nombre);
            this.groupBox1.Location = new System.Drawing.Point(479, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Materia Prima";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(7, 55);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 3;
            this.label_nombre.Text = "Nombre";
            // 
            // comboBox_ingrediente
            // 
            this.comboBox_ingrediente.FormattingEnabled = true;
            this.comboBox_ingrediente.Location = new System.Drawing.Point(57, 55);
            this.comboBox_ingrediente.Name = "comboBox_ingrediente";
            this.comboBox_ingrediente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ingrediente.TabIndex = 5;
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(10, 97);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(49, 13);
            this.label_cantidad.TabIndex = 6;
            this.label_cantidad.Text = "Cantidad";
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(57, 97);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(100, 20);
            this.textBox_cantidad.TabIndex = 7;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(57, 162);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 8;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // FormListaMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 582);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormListaMateriaPrima";
            this.Text = "FormListaMateriaPrima";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.Label label_cantidad;
        private System.Windows.Forms.ComboBox comboBox_ingrediente;
    }
}