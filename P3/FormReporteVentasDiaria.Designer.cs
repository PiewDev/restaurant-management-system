namespace P3
{
    partial class FormReporteVentasDiaria
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
            this.label_Fecha_Ventas_Diarias = new System.Windows.Forms.Label();
            this.textBox_Fecha_Venta_Diaria = new System.Windows.Forms.TextBox();
            this.dataGridView_VentasDiarias = new System.Windows.Forms.DataGridView();
            this.button_Buscar_Fecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VentasDiarias)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Fecha_Ventas_Diarias
            // 
            this.label_Fecha_Ventas_Diarias.AutoSize = true;
            this.label_Fecha_Ventas_Diarias.Location = new System.Drawing.Point(45, 51);
            this.label_Fecha_Ventas_Diarias.Name = "label_Fecha_Ventas_Diarias";
            this.label_Fecha_Ventas_Diarias.Size = new System.Drawing.Size(37, 13);
            this.label_Fecha_Ventas_Diarias.TabIndex = 0;
            this.label_Fecha_Ventas_Diarias.Text = "Fecha";
            // 
            // textBox_Fecha_Venta_Diaria
            // 
            this.textBox_Fecha_Venta_Diaria.Location = new System.Drawing.Point(86, 48);
            this.textBox_Fecha_Venta_Diaria.Name = "textBox_Fecha_Venta_Diaria";
            this.textBox_Fecha_Venta_Diaria.Size = new System.Drawing.Size(100, 20);
            this.textBox_Fecha_Venta_Diaria.TabIndex = 1;
            this.textBox_Fecha_Venta_Diaria.TextChanged += new System.EventHandler(this.textBox_Fecha_Venta_Diaria_TextChanged);
            // 
            // dataGridView_VentasDiarias
            // 
            this.dataGridView_VentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_VentasDiarias.Location = new System.Drawing.Point(48, 75);
            this.dataGridView_VentasDiarias.Name = "dataGridView_VentasDiarias";
            this.dataGridView_VentasDiarias.Size = new System.Drawing.Size(482, 226);
            this.dataGridView_VentasDiarias.TabIndex = 3;
            this.dataGridView_VentasDiarias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_VentasDiarias_CellContentClick);
            // 
            // button_Buscar_Fecha
            // 
            this.button_Buscar_Fecha.Location = new System.Drawing.Point(206, 48);
            this.button_Buscar_Fecha.Name = "button_Buscar_Fecha";
            this.button_Buscar_Fecha.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_Fecha.TabIndex = 4;
            this.button_Buscar_Fecha.Text = "Buscar";
            this.button_Buscar_Fecha.UseVisualStyleBackColor = true;
            this.button_Buscar_Fecha.Click += new System.EventHandler(this.button_Buscar_Fecha_Click);
            // 
            // FormReporteVentasDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Buscar_Fecha);
            this.Controls.Add(this.dataGridView_VentasDiarias);
            this.Controls.Add(this.textBox_Fecha_Venta_Diaria);
            this.Controls.Add(this.label_Fecha_Ventas_Diarias);
            this.Name = "FormReporteVentasDiaria";
            this.Text = "FormReporteVentasXDiaria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VentasDiarias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Fecha_Ventas_Diarias;
        private System.Windows.Forms.TextBox textBox_Fecha_Venta_Diaria;
        private System.Windows.Forms.DataGridView dataGridView_VentasDiarias;
        private System.Windows.Forms.Button button_Buscar_Fecha;
    }
}