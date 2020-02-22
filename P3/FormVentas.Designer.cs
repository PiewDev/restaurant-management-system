namespace P3
{
    partial class FormVentas
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
            this.dataGridView_Ventas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Ventas
            // 
            this.dataGridView_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ventas.Location = new System.Drawing.Point(28, 54);
            this.dataGridView_Ventas.Name = "dataGridView_Ventas";
            this.dataGridView_Ventas.Size = new System.Drawing.Size(710, 336);
            this.dataGridView_Ventas.TabIndex = 0;
            this.dataGridView_Ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ventas_CellContentClick);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Ventas);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Ventas;
    }
}