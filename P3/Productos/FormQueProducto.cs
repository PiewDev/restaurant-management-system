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
    public partial class FormQueProducto : Form
    {
        public FormQueProducto()
        {
            InitializeComponent();
        }

        private void button_producto_simple_Click(object sender, EventArgs e)
        {
            FormListaProductoSimple simple = new FormListaProductoSimple();
            simple.Show();
        }

        private void button_producto_compuesto_Click(object sender, EventArgs e)
        {
            FormListaProductoCompuesto compuesto = new FormListaProductoCompuesto();
            compuesto.Show();
        }
    }
}
