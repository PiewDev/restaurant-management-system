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
    public partial class FormProductoSimple : Form
    {
        public FormProductoSimple()
        {
            InitializeComponent();
            textBox_ID_Producto_Simple.Enabled = false;
            label_ID_Producto_Simple.Enabled = false;
            button_Guardar_Modificado_Producto_Simple.Enabled = false;
            dataGridView_Productos_Simples.DataSource = ProductoSimple_Neg.listarProductosSimples();
            comboBox_Categoria_Producto_Simple.DataSource = ProductoSimple_Neg.listarCategoria();
            comboBox_Categoria_Producto_Simple.DisplayMember = "nombre";
            comboBox_Categoria_Producto_Simple.ValueMember = "id_categoria";
        }

        private void limpiar()
        {
            textBox_Marca_Producto_Simple.Text = "";
            //comboBox_Categoria_Proucto_Simple.ValueMember = "nombre";
            textBox_Descripcion_Producto_Simple.Text = "";
            textBox_Costo_Producto_Simple.Text = "";
            textBox_Precio_Venta_Producto_Simple.Text = "";
            textBox_Cantidad_Producto_Simple.Text = "";
        }

        private void resetear()
        {
            textBox_ID_Producto_Simple.Enabled = false;
            label_ID_Producto_Simple.Enabled = false;
            button_Guardar_Modificado_Producto_Simple.Enabled = false;
            button_Guardar_Producto_Simple.Enabled = true;
        }

        private void button_Guardar_Producto_Simple_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductoSimple_Neg.guardarProductoSimple(textBox_Marca_Producto_Simple.Text, Convert.ToInt32(comboBox_Categoria_Producto_Simple.SelectedValue), textBox_Descripcion_Producto_Simple.Text, Convert.ToInt32(textBox_Costo_Producto_Simple.Text), Convert.ToInt32(textBox_Precio_Venta_Producto_Simple.Text), Convert.ToInt32(textBox_Cantidad_Producto_Simple.Text), 0))
                {
                    Funciones.mOk(this, "Se a guardado correctamente");
                    limpiar();
                    dataGridView_Productos_Simples.DataSource = ProductoSimple_Neg.listarProductosSimples();
                }
                else
                {
                    Funciones.mError(this, "Error al guardar, estoy en el ELSE");
                }
            }
            catch (Exception ex)
            {
                Funciones.mError(this, "Error al guardar" + ex);
            }
        }

        private void button_Cancelar_Producto_Simple_Click(object sender, EventArgs e)
        {
            limpiar();
            resetear();
        }

        private void button_Guardar_Modificado_Producto_Simple_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductoSimple_Neg.guardarModificadoProductoSimple(Convert.ToInt32(textBox_ID_Producto_Simple.Text), textBox_Marca_Producto_Simple.Text, textBox_Descripcion_Producto_Simple.Text, Convert.ToInt32(textBox_Costo_Producto_Simple.Text), Convert.ToInt32(textBox_Precio_Venta_Producto_Simple.Text), Convert.ToInt32(textBox_Cantidad_Producto_Simple.Text), Convert.ToInt32(comboBox_Categoria_Producto_Simple.Text)))
                {
                    Funciones.mOk(this, "Se a modificado correctamente");
                    limpiar();
                    dataGridView_Productos_Simples.DataSource = ProductoSimple_Neg.listarProductosSimples();
                    resetear();
                }
                else
                {
                    Funciones.mError(this, "Error al modificar");
                }

            }
            catch (Exception)
            {
                Funciones.mError(this, "Error al modificar");
            }
        }

        private void button_Modificar_Producto_Simple_Click(object sender, EventArgs e)
        {
            textBox_ID_Producto_Simple.Enabled = true;
            label_ID_Producto_Simple.Enabled = true;

            string indice = Convert.ToString(dataGridView_Productos_Simples.CurrentRow.Cells["id_productosimple"].Value);
            string marca = Convert.ToString(dataGridView_Productos_Simples.CurrentRow.Cells["marca"].Value);
            //string categoria = Convert.ToString(dataGridView_Productos_Simples.CurrentRow.Cells["categoria"].Value);
            string descripcion = Convert.ToString(dataGridView_Productos_Simples.CurrentRow.Cells["descripcion"].Value);
            string costo = Convert.ToString(dataGridView_Productos_Simples.CurrentRow.Cells["costo"].Value);
            string precio_venta = Convert.ToString(dataGridView_Productos_Simples.CurrentRow.Cells["precio_venta"].Value);
            string cantidad = Convert.ToString(dataGridView_Productos_Simples.CurrentRow.Cells["cantidad"].Value);
            string id_categoria = Convert.ToString(dataGridView_Productos_Simples.CurrentRow.Cells["id_categoria"].Value);

            button_Guardar_Modificado_Producto_Simple.Enabled = true;
            button_Guardar_Producto_Simple.Enabled = false;

            textBox_ID_Producto_Simple.Text = indice;
            textBox_Marca_Producto_Simple.Text = marca;
            //comboBox_Categoria_Producto_Simple.Text = categoria;
            comboBox_Categoria_Producto_Simple.Text = id_categoria;
            textBox_Descripcion_Producto_Simple.Text = descripcion;
            textBox_Costo_Producto_Simple.Text = costo;
            textBox_Precio_Venta_Producto_Simple.Text = precio_venta;
            textBox_Cantidad_Producto_Simple.Text = cantidad;

            string indice_modificado = textBox_ID_Producto_Simple.Text;
            string marca_modificado = textBox_Marca_Producto_Simple.Text;
            //string categoria_modificado = comboBox_Categoria_Producto_Simple.Text;
            string id_categoria_modificado = comboBox_Categoria_Producto_Simple.Text;
            string descripcion_modificado = textBox_Descripcion_Producto_Simple.Text;
            string costo_modificado = textBox_Costo_Producto_Simple.Text;
            string precio_venta_modificado = textBox_Precio_Venta_Producto_Simple.Text;
            string cantidad_modificado = textBox_Cantidad_Producto_Simple.Text;
        }

        private void button_Eliminar_Producto_Simple_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(dataGridView_Productos_Simples.CurrentRow.Cells["id_productosimple"].Value);

            try
            {
                if (ProductoSimple_Neg.eliminarProductoSimple(indice))
                {
                    Funciones.mOk(this, "Se a eliminado correctamente");
                    dataGridView_Productos_Simples.DataSource = ProductoSimple_Neg.listarProductosSimples();
                }
                else
                {
                    Funciones.mError(this, "Error al eliminar");
                }

            }
            catch (Exception)
            {
                Funciones.mError(this, "Error al eliminar");
            }
        }

        private void textBox_Buscar_Producto_Simple_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Buscar_Producto_Simple.Text == "")
            {
                dataGridView_Productos_Simples.DataSource = ProductoSimple_Neg.listarProductosSimples();
            }
            //if (textBox_Buscar_Producto_Simple.Text != "")
            //{
            //    dataGridView_Productos_Simples.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView_Productos_Simples.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dataGridView_Productos_Simples.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper()).IndexOf(textBox_Buscar_Producto_Simple.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_Productos_Simples.DataSource = ProductoSimple_Neg.listarProductosSimples();
            //}
        }

        private void button_Buscar_Producto_Simple_Click(object sender, EventArgs e)
        {
            string categoria = textBox_Buscar_Producto_Simple.Text;
            dataGridView_Productos_Simples.DataSource = ProductoSimple_Neg.listarProductosSimples(categoria);
        }

        private void FormProductoSimple_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_Formulario_Producto_Simple_Enter(object sender, EventArgs e)
        {

        }
    }
}
