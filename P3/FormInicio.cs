using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class FormInicio : Form
    {

        public FormInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMozo ventana_mozo = new FormMozo();
            ventana_mozo.Show();
        }

        private void button_Mesa_Inicio_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Producto_Simple_Click(object sender, EventArgs e)
        {
            FormProductoSimple ventana_producto_simple = new FormProductoSimple();
            ventana_producto_simple.Show();
        }

        private void button_Materia_Prima_Click(object sender, EventArgs e)
        {
            FormMateriaPrima ventana_materia_prima = new FormMateriaPrima();
            ventana_materia_prima.Show();
        }

        private void button_Categoria_Click(object sender, EventArgs e)
        {
            FormCategoria ventana_categoria = new FormCategoria();
            ventana_categoria.Show();
        }

        private void button_Pedido_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Producto_Compuesto_Click(object sender, EventArgs e)
        {
            //FormProductoCompuesto2 ventana_productocompuesto = new FormProductoCompuesto2();
            //ventana_productocompuesto.Show();
        }

        private void button_VentasXMozo_Click(object sender, EventArgs e)
        {
            FormReporteVentasXMozo ventana_ventas_mozo = new FormReporteVentasXMozo();
            ventana_ventas_mozo.Show();
        }

        private void button_Venta_Diaria_Click(object sender, EventArgs e)
        {
            FormReporteVentasDiaria ventana_venta_diaria = new FormReporteVentasDiaria();
            ventana_venta_diaria.Show();
        }

        private void button_PrecioXCategoria_Click(object sender, EventArgs e)
        {
            FormReportePrecioXCategoria ventana_precio_categoria = new FormReportePrecioXCategoria();
            ventana_precio_categoria.Show();
        }

        private void button_Ventas_Click(object sender, EventArgs e)
        {
            FormVentas ventana_venta = new FormVentas();
            ventana_venta.Show();
        }

        private void button_armar_producto_compuesto_Click(object sender, EventArgs e)
        {
            FormArmarProductoCompuesto armar = new FormArmarProductoCompuesto();
            armar.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
