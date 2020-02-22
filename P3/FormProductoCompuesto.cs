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
    public partial class FormProductoCompuesto : Form
    {
        public FormProductoCompuesto()
        {
            InitializeComponent();
            textBox_ID_Producto_Compuesto.Enabled = false;
            label_ID_Producto_Compuesto.Enabled = false;
            button_GuardarModificado_Producto_Compuesto.Enabled = false;
            dataGridView_ProductoCompuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestos();
            //comboBox_Categoria_Producto_Compuesto.DataSource = ProductoCompuesto_Neg.comboBox_Categoria();
            //comboBox_Categoria_Producto_Compuesto.DisplayMember = "Seleccionar..";
            //comboBox_Categoria_Producto_Compuesto.ValueMember = "nombre";
        }

        private void limpiar()
        {
            textBox_ID_Producto_Compuesto.Text = "";
            //comboBox_Categoria_Producto_Compuesto.ValueMember = "nombre";
            textBox_Nombre_Producto_Compuesto.Text = "";
            textBox_Descripcion_Producto_Compuesto.Text = "";
            textBox_Costo_Producto_Compuesto.Text = "";
            textBox_PrecioVenta_Producto_Compuesto.Text = "";
        }

        private void resetear()
        {
            textBox_ID_Producto_Compuesto.Enabled = false;
            label_ID_Producto_Compuesto.Enabled = false;
            button_GuardarModificado_Producto_Compuesto.Enabled = false;
            button_Agregar_Producto_Compuesto.Enabled = true;
        }

        private void button_Agregar_Producto_Compuesto_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ProductoCompuesto_Neg.guardarProductoCompuesto(comboBox_Categoria_Producto_Compuesto.SelectedItem.ToString(), textBox_Nombre_Producto_Compuesto.Text, textBox_Descripcion_Producto_Compuesto.Text, Convert.ToInt32(textBox_Costo_Producto_Compuesto.Text), Convert.ToInt32(textBox_PrecioVenta_Producto_Compuesto.Text), 0))
                //{
                //    Funciones.mOk(this, "Se a guardado correctamente");
                //    limpiar();
                //    dataGridView_ProductoCompuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestos();
                //}
                //else
                //{
                //    Funciones.mError(this, "Error al guardar, estoy en el ELSE");
                //}
            }
            catch (Exception ex)
            {
                Funciones.mError(this, "Error al guardar" + ex);
            }
        }

        private void button_Cancelar_Producto_Compuesto_Click(object sender, EventArgs e)
        {
            limpiar();
            resetear();
        }

        private void button_GuardarModificado_Producto_Compuesto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductoCompuesto_Neg.guardarModificadoProductoCompuesto(Convert.ToInt32(textBox_ID_Producto_Compuesto.Text), comboBox_Categoria_Producto_Compuesto.SelectedItem.ToString(), textBox_Nombre_Producto_Compuesto.Text, textBox_Descripcion_Producto_Compuesto.Text, Convert.ToInt32(textBox_Costo_Producto_Compuesto.Text), Convert.ToInt32(textBox_PrecioVenta_Producto_Compuesto.Text)))
                {
                    Funciones.mOk(this, "Se a modificado correctamente");
                    limpiar();
                    dataGridView_ProductoCompuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestos();
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

        private void button_Modificar_Producto_Compuesto_Click(object sender, EventArgs e)
        {
            textBox_ID_Producto_Compuesto.Enabled = true;
            label_ID_Producto_Compuesto.Enabled = true;

            string indice = Convert.ToString(dataGridView_ProductoCompuesto.CurrentRow.Cells["id_productocompuesto"].Value);
            string categoria = Convert.ToString(dataGridView_ProductoCompuesto.CurrentRow.Cells["categoria"].Value);
            string nombre = Convert.ToString(dataGridView_ProductoCompuesto.CurrentRow.Cells["nombre"].Value);
            string descripcion = Convert.ToString(dataGridView_ProductoCompuesto.CurrentRow.Cells["descripcion"].Value);
            string costo = Convert.ToString(dataGridView_ProductoCompuesto.CurrentRow.Cells["costo"].Value);
            string precio_venta = Convert.ToString(dataGridView_ProductoCompuesto.CurrentRow.Cells["precio_venta"].Value);

            button_GuardarModificado_Producto_Compuesto.Enabled = true;
            button_Agregar_Producto_Compuesto.Enabled = false;

            textBox_ID_Producto_Compuesto.Text = indice;
            comboBox_Categoria_Producto_Compuesto.Text = categoria;
            textBox_Nombre_Producto_Compuesto.Text = nombre;
            textBox_Descripcion_Producto_Compuesto.Text = descripcion;
            textBox_Costo_Producto_Compuesto.Text = costo;
            textBox_PrecioVenta_Producto_Compuesto.Text = precio_venta;

            string indice_modificado = textBox_ID_Producto_Compuesto.Text;
            string categoria_modificado = comboBox_Categoria_Producto_Compuesto.Text;
            string nombre_modificado = textBox_Nombre_Producto_Compuesto.Text;
            string descripcion_modificado = textBox_Descripcion_Producto_Compuesto.Text;
            string costo_modificado = textBox_Costo_Producto_Compuesto.Text;
            string precio_venta_modificado = textBox_PrecioVenta_Producto_Compuesto.Text;
        }

        private void button_Eliminar_Producto_Compuesto_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(dataGridView_ProductoCompuesto.CurrentRow.Cells["id_productocompuesto"].Value);

            try
            {
                if (ProductoCompuesto_Neg.eliminarProductoCompuesto(indice))
                {
                    Funciones.mOk(this, "Se a eliminado correctamente");
                    dataGridView_ProductoCompuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestos();
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

        private void comboBox_Categoria_Producto_Compuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Buscar_Producto_Compuesto_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Buscar_Producto_Compuesto.Text == "")
            {
                dataGridView_ProductoCompuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestos();
            }
            //if (textBox_Buscar_Producto_Compuesto.Text != "")
            //{
            //    dataGridView_ProductoCompuesto.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView_ProductoCompuesto.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dataGridView_ProductoCompuesto.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper()).IndexOf(textBox_Buscar_Producto_Compuesto.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_ProductoCompuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestos();
            //}
        }

        private void button_Buscar_Producto_Compuesto_Click(object sender, EventArgs e)
        {
            string categoria = textBox_Buscar_Producto_Compuesto.Text;
            dataGridView_ProductoCompuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestos(categoria);
        }
    }
}
