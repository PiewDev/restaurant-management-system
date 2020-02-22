namespace P3
{
    partial class FormReporteVentasXMozo
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
            this.dataGridView_VentasXMozo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VentasXMozo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_VentasXMozo
            // 
            this.dataGridView_VentasXMozo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_VentasXMozo.Location = new System.Drawing.Point(117, 83);
            this.dataGridView_VentasXMozo.Name = "dataGridView_VentasXMozo";
            this.dataGridView_VentasXMozo.Size = new System.Drawing.Size(520, 236);
            this.dataGridView_VentasXMozo.TabIndex = 3;
            this.dataGridView_VentasXMozo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_VentasXMozo_CellContentClick);
            // 
            // FormReporteVentasXMozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_VentasXMozo);
            this.Name = "FormReporteVentasXMozo";
            this.Text = "ReporteVentasXMozo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VentasXMozo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_VentasXMozo;
    }
}