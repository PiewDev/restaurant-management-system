namespace P3
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Mozo_Inicio = new System.Windows.Forms.Button();
            this.button_Mesa_Inicio = new System.Windows.Forms.Button();
            this.button_Producto_Simple = new System.Windows.Forms.Button();
            this.button_Materia_Prima = new System.Windows.Forms.Button();
            this.button_Categoria = new System.Windows.Forms.Button();
            this.button_Pedido = new System.Windows.Forms.Button();
            this.button_Producto_Compuesto = new System.Windows.Forms.Button();
            this.button_VentasXMozo = new System.Windows.Forms.Button();
            this.button_Venta_Diaria = new System.Windows.Forms.Button();
            this.button_PrecioXCategoria = new System.Windows.Forms.Button();
            this.button_Ventas = new System.Windows.Forms.Button();
            this.button_armar_producto_compuesto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Mozo_Inicio
            // 
            this.button_Mozo_Inicio.Location = new System.Drawing.Point(13, 13);
            this.button_Mozo_Inicio.Name = "button_Mozo_Inicio";
            this.button_Mozo_Inicio.Size = new System.Drawing.Size(75, 23);
            this.button_Mozo_Inicio.TabIndex = 2;
            this.button_Mozo_Inicio.Text = "Mozos";
            this.button_Mozo_Inicio.UseVisualStyleBackColor = true;
            this.button_Mozo_Inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Mesa_Inicio
            // 
            this.button_Mesa_Inicio.Location = new System.Drawing.Point(103, 13);
            this.button_Mesa_Inicio.Name = "button_Mesa_Inicio";
            this.button_Mesa_Inicio.Size = new System.Drawing.Size(75, 23);
            this.button_Mesa_Inicio.TabIndex = 3;
            this.button_Mesa_Inicio.Text = "Mesas";
            this.button_Mesa_Inicio.UseVisualStyleBackColor = true;
            this.button_Mesa_Inicio.Click += new System.EventHandler(this.button_Mesa_Inicio_Click);
            // 
            // button_Producto_Simple
            // 
            this.button_Producto_Simple.Location = new System.Drawing.Point(193, 13);
            this.button_Producto_Simple.Name = "button_Producto_Simple";
            this.button_Producto_Simple.Size = new System.Drawing.Size(145, 23);
            this.button_Producto_Simple.TabIndex = 5;
            this.button_Producto_Simple.Text = "Productos Simples ";
            this.button_Producto_Simple.UseVisualStyleBackColor = true;
            this.button_Producto_Simple.Click += new System.EventHandler(this.button_Producto_Simple_Click);
            // 
            // button_Materia_Prima
            // 
            this.button_Materia_Prima.Location = new System.Drawing.Point(546, 13);
            this.button_Materia_Prima.Name = "button_Materia_Prima";
            this.button_Materia_Prima.Size = new System.Drawing.Size(107, 23);
            this.button_Materia_Prima.TabIndex = 6;
            this.button_Materia_Prima.Text = "Materias Primas";
            this.button_Materia_Prima.UseVisualStyleBackColor = true;
            this.button_Materia_Prima.Click += new System.EventHandler(this.button_Materia_Prima_Click);
            // 
            // button_Categoria
            // 
            this.button_Categoria.Location = new System.Drawing.Point(669, 13);
            this.button_Categoria.Name = "button_Categoria";
            this.button_Categoria.Size = new System.Drawing.Size(75, 23);
            this.button_Categoria.TabIndex = 7;
            this.button_Categoria.Text = "Categorias";
            this.button_Categoria.UseVisualStyleBackColor = true;
            this.button_Categoria.Click += new System.EventHandler(this.button_Categoria_Click);
            // 
            // button_Pedido
            // 
            this.button_Pedido.Location = new System.Drawing.Point(761, 13);
            this.button_Pedido.Name = "button_Pedido";
            this.button_Pedido.Size = new System.Drawing.Size(75, 23);
            this.button_Pedido.TabIndex = 8;
            this.button_Pedido.Text = "Pedido";
            this.button_Pedido.UseVisualStyleBackColor = true;
            this.button_Pedido.Click += new System.EventHandler(this.button_Pedido_Click);
            // 
            // button_Producto_Compuesto
            // 
            this.button_Producto_Compuesto.Location = new System.Drawing.Point(685, 261);
            this.button_Producto_Compuesto.Name = "button_Producto_Compuesto";
            this.button_Producto_Compuesto.Size = new System.Drawing.Size(151, 23);
            this.button_Producto_Compuesto.TabIndex = 10;
            this.button_Producto_Compuesto.Text = "Producto Compuesto ";
            this.button_Producto_Compuesto.UseVisualStyleBackColor = true;
            this.button_Producto_Compuesto.Click += new System.EventHandler(this.button_Producto_Compuesto_Click);
            // 
            // button_VentasXMozo
            // 
            this.button_VentasXMozo.Location = new System.Drawing.Point(13, 56);
            this.button_VentasXMozo.Name = "button_VentasXMozo";
            this.button_VentasXMozo.Size = new System.Drawing.Size(147, 23);
            this.button_VentasXMozo.TabIndex = 11;
            this.button_VentasXMozo.Text = "Reporte Ventas por Mozo";
            this.button_VentasXMozo.UseVisualStyleBackColor = true;
            this.button_VentasXMozo.Click += new System.EventHandler(this.button_VentasXMozo_Click);
            // 
            // button_Venta_Diaria
            // 
            this.button_Venta_Diaria.Location = new System.Drawing.Point(181, 56);
            this.button_Venta_Diaria.Name = "button_Venta_Diaria";
            this.button_Venta_Diaria.Size = new System.Drawing.Size(149, 23);
            this.button_Venta_Diaria.TabIndex = 12;
            this.button_Venta_Diaria.Text = "Reporte Ventas Diarias";
            this.button_Venta_Diaria.UseVisualStyleBackColor = true;
            this.button_Venta_Diaria.Click += new System.EventHandler(this.button_Venta_Diaria_Click);
            // 
            // button_PrecioXCategoria
            // 
            this.button_PrecioXCategoria.Location = new System.Drawing.Point(351, 56);
            this.button_PrecioXCategoria.Name = "button_PrecioXCategoria";
            this.button_PrecioXCategoria.Size = new System.Drawing.Size(188, 23);
            this.button_PrecioXCategoria.TabIndex = 13;
            this.button_PrecioXCategoria.Text = "Reporte Precio por Categoria";
            this.button_PrecioXCategoria.UseVisualStyleBackColor = true;
            this.button_PrecioXCategoria.Click += new System.EventHandler(this.button_PrecioXCategoria_Click);
            // 
            // button_Ventas
            // 
            this.button_Ventas.Location = new System.Drawing.Point(559, 56);
            this.button_Ventas.Name = "button_Ventas";
            this.button_Ventas.Size = new System.Drawing.Size(75, 23);
            this.button_Ventas.TabIndex = 14;
            this.button_Ventas.Text = "Ventas";
            this.button_Ventas.UseVisualStyleBackColor = true;
            this.button_Ventas.Click += new System.EventHandler(this.button_Ventas_Click);
            // 
            // button_armar_producto_compuesto
            // 
            this.button_armar_producto_compuesto.Location = new System.Drawing.Point(351, 13);
            this.button_armar_producto_compuesto.Name = "button_armar_producto_compuesto";
            this.button_armar_producto_compuesto.Size = new System.Drawing.Size(179, 23);
            this.button_armar_producto_compuesto.TabIndex = 16;
            this.button_armar_producto_compuesto.Text = "Armar Producto Compuesto";
            this.button_armar_producto_compuesto.UseVisualStyleBackColor = true;
            this.button_armar_producto_compuesto.Click += new System.EventHandler(this.button_armar_producto_compuesto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Comanda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormInicio
            // 
            this.ClientSize = new System.Drawing.Size(848, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_armar_producto_compuesto);
            this.Controls.Add(this.button_Ventas);
            this.Controls.Add(this.button_PrecioXCategoria);
            this.Controls.Add(this.button_Venta_Diaria);
            this.Controls.Add(this.button_VentasXMozo);
            this.Controls.Add(this.button_Producto_Compuesto);
            this.Controls.Add(this.button_Pedido);
            this.Controls.Add(this.button_Categoria);
            this.Controls.Add(this.button_Materia_Prima);
            this.Controls.Add(this.button_Producto_Simple);
            this.Controls.Add(this.button_Mesa_Inicio);
            this.Controls.Add(this.button_Mozo_Inicio);
            this.IsMdiContainer = true;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button button_Mozo_Inicio;
        private System.Windows.Forms.Button button_Mesa_Inicio;
        private System.Windows.Forms.Button button_Producto_Simple;
        private System.Windows.Forms.Button button_Materia_Prima;
        private System.Windows.Forms.Button button_Categoria;
        private System.Windows.Forms.Button button_Pedido;
        private System.Windows.Forms.Button button_Producto_Compuesto;
        private System.Windows.Forms.Button button_VentasXMozo;
        private System.Windows.Forms.Button button_Venta_Diaria;
        private System.Windows.Forms.Button button_PrecioXCategoria;
        private System.Windows.Forms.Button button_Ventas;
        private System.Windows.Forms.Button button_armar_producto_compuesto;
        private System.Windows.Forms.Button button1;
    }
}

