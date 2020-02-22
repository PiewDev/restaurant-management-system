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
            this.dataGridView_temporal = new System.Windows.Forms.DataGridView();
            this.Nro_Comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label_valor_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_nro_comanda = new System.Windows.Forms.TextBox();
            this.textBox_cod_producto = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.textBox_subtotal = new System.Windows.Forms.TextBox();
            this.button_aceptar_modificado = new System.Windows.Forms.Button();
            this.button_cancenlar_modificado = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label_valor_nro_mesa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tipo_producto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_temporal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_temporal
            // 
            this.dataGridView_temporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_temporal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Comanda,
            this.Cod_Producto,
            this.Nombre,
            this.Tipo,
            this.Precio,
            this.Subtotal});
            this.dataGridView_temporal.Location = new System.Drawing.Point(12, 54);
            this.dataGridView_temporal.Name = "dataGridView_temporal";
            this.dataGridView_temporal.Size = new System.Drawing.Size(643, 176);
            this.dataGridView_temporal.TabIndex = 0;
            this.dataGridView_temporal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_temporal_CellContentClick);
            // 
            // Nro_Comanda
            // 
            this.Nro_Comanda.HeaderText = "N° Comanda";
            this.Nro_Comanda.Name = "Nro_Comanda";
            // 
            // Cod_Producto
            // 
            this.Cod_Producto.HeaderText = "Cod. Producto";
            this.Cod_Producto.Name = "Cod_Producto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mesa:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Generar Comanda";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(559, 364);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Atras";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total:";
            // 
            // label_valor_total
            // 
            this.label_valor_total.AutoSize = true;
            this.label_valor_total.Location = new System.Drawing.Point(620, 251);
            this.label_valor_total.Name = "label_valor_total";
            this.label_valor_total.Size = new System.Drawing.Size(35, 13);
            this.label_valor_total.TabIndex = 15;
            this.label_valor_total.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "N° Comanda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(801, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cod. Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(801, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(801, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(801, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Subtotal";
            // 
            // textBox_nro_comanda
            // 
            this.textBox_nro_comanda.Location = new System.Drawing.Point(883, 57);
            this.textBox_nro_comanda.Name = "textBox_nro_comanda";
            this.textBox_nro_comanda.Size = new System.Drawing.Size(100, 20);
            this.textBox_nro_comanda.TabIndex = 22;
            // 
            // textBox_cod_producto
            // 
            this.textBox_cod_producto.Location = new System.Drawing.Point(883, 106);
            this.textBox_cod_producto.Name = "textBox_cod_producto";
            this.textBox_cod_producto.Size = new System.Drawing.Size(100, 20);
            this.textBox_cod_producto.TabIndex = 23;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(883, 159);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 25;
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(883, 244);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(100, 20);
            this.textBox_precio.TabIndex = 26;
            // 
            // textBox_subtotal
            // 
            this.textBox_subtotal.Location = new System.Drawing.Point(883, 305);
            this.textBox_subtotal.Name = "textBox_subtotal";
            this.textBox_subtotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_subtotal.TabIndex = 27;
            // 
            // button_aceptar_modificado
            // 
            this.button_aceptar_modificado.Location = new System.Drawing.Point(814, 364);
            this.button_aceptar_modificado.Name = "button_aceptar_modificado";
            this.button_aceptar_modificado.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar_modificado.TabIndex = 28;
            this.button_aceptar_modificado.Text = "Aceptar";
            this.button_aceptar_modificado.UseVisualStyleBackColor = true;
            this.button_aceptar_modificado.Click += new System.EventHandler(this.button_aceptar_modificado_Click);
            // 
            // button_cancenlar_modificado
            // 
            this.button_cancenlar_modificado.Location = new System.Drawing.Point(908, 364);
            this.button_cancenlar_modificado.Name = "button_cancenlar_modificado";
            this.button_cancenlar_modificado.Size = new System.Drawing.Size(75, 23);
            this.button_cancenlar_modificado.TabIndex = 29;
            this.button_cancenlar_modificado.Text = "Cancelar";
            this.button_cancenlar_modificado.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(333, 364);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "Guardar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label_valor_nro_mesa
            // 
            this.label_valor_nro_mesa.AutoSize = true;
            this.label_valor_nro_mesa.Location = new System.Drawing.Point(243, 29);
            this.label_valor_nro_mesa.Name = "label_valor_nro_mesa";
            this.label_valor_nro_mesa.Size = new System.Drawing.Size(35, 13);
            this.label_valor_nro_mesa.TabIndex = 31;
            this.label_valor_nro_mesa.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tipo";
            // 
            // textBox_tipo_producto
            // 
            this.textBox_tipo_producto.Location = new System.Drawing.Point(883, 200);
            this.textBox_tipo_producto.Name = "textBox_tipo_producto";
            this.textBox_tipo_producto.Size = new System.Drawing.Size(100, 20);
            this.textBox_tipo_producto.TabIndex = 33;
            // 
            // FormComandaTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.textBox_tipo_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_valor_nro_mesa);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button_cancenlar_modificado);
            this.Controls.Add(this.button_aceptar_modificado);
            this.Controls.Add(this.textBox_subtotal);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.textBox_cod_producto);
            this.Controls.Add(this.textBox_nro_comanda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_valor_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_temporal);
            this.Name = "FormComandaTemporal";
            this.Text = "FormComanda";
            this.Load += new System.EventHandler(this.FormComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_temporal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_temporal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_valor_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_nro_comanda;
        private System.Windows.Forms.TextBox textBox_cod_producto;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.TextBox textBox_subtotal;
        private System.Windows.Forms.Button button_aceptar_modificado;
        private System.Windows.Forms.Button button_cancenlar_modificado;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label_valor_nro_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tipo_producto;
    }
}