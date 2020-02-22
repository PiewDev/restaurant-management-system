using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace P3
{
    public partial class FormReportePrecioXCategoria : Form
    {
        public FormReportePrecioXCategoria()
        {
            InitializeComponent();
            //dataGridView_Categoria_Precio.DataSource = Reportes_Neg.listarPrecioCategoria();
        }

        //private void button_Buscar_Categoria_Click(object sender, EventArgs e)
        //{
        //    dataGridView_Categoria_Producto_Simple.DataSource = Reportes_Neg.listarPrecioProductoSimple(comboBox_Categoria_Producto_Simple.SelectedValue.ToString());
        //}

        //private void button_Categoria_Producto_Compuesto_Click(object sender, EventArgs e)
        //{
        //    dataGridView_Categoria_Producto_Compuesto.DataSource = Reportes_Neg.listarPrecioProductoCompuesto(comboBox_Categoria_Producto_Compuesto.SelectedValue.ToString());
        //}

        //private void button_Categoria_Materia_Prima_Click(object sender, EventArgs e)
        //{
        //    dataGridView_Categoria_Materia_Prima.DataSource = Reportes_Neg.listarPrecioMateriaPrima(comboBox_Categoria_Materia_Prima.SelectedValue.ToString());
        //}

        private void textBox_Buscar_Categoria_Producto_Simple_TextChanged(object sender, EventArgs e)
        {
            //if(textBox_Buscar_Categoria_Producto_Simple.Text == "")
            //{
            //    dataGridView_Categoria_Precio.DataSource = Reportes_Neg.listarPrecioCategoria();
            //}
            //if (textBox_Buscar_Categoria_Producto_Simple.Text != "")
            //{
            //    dataGridView_Categoria_Producto_Simple.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView_Categoria_Producto_Simple.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dataGridView_Categoria_Producto_Simple.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper()).IndexOf(textBox_Buscar_Categoria_Producto_Simple.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_Categoria_Producto_Simple.DataSource = Reportes_Neg.listarPrecioProductoSimple();
            //}
        }

        private void button_Buscar_Categoria_Producto_Simple_Click(object sender, EventArgs e)
        {
            //int categoria = Convert.ToInt32(textBox_Buscar_Categoria_Producto_Simple.Text);
            string tipo = textBox_simple_compuesto.Text;

            if(tipo.Equals("Simple"))
            {
                dataGridView_Categoria_Precio.DataSource = Reportes_Neg.listarPrecioCategoriaSimple();
            }
            else if(tipo.Equals("Compuesto"))
            {
                dataGridView_Categoria_Precio.DataSource = Reportes_Neg.listarPrecioCategoriaCompuesto();
            }
        }
    }
}
