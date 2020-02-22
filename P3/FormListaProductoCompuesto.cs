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
    public partial class FormListaProductoCompuesto : Form
    {
        public FormListaProductoCompuesto()
        {
            InitializeComponent();
            comboBox_categoria.DataSource = Categoria_Neg.listarCategoriasCombo();
            dataGridView_lista_producto_compuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestosPedido();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                FormComandaTemporal temporal = new FormComandaTemporal();
                int nro_mesa = temporal.valor_mesa();

                foreach (DataGridViewRow row in dataGridView_lista_producto_compuesto.Rows)
                {
                    int mesa = nro_mesa;
                    int id_mozo = Convert.ToInt32(textBox_mozo.ToString());
                    int id_productocompuesto = Convert.ToInt32(row.Cells[0].Value);

                    Pedido_Neg.guardarTemporal2(1, mesa, id_mozo, id_productocompuesto, 0);
                }

            }
            catch (Exception ex)
            {
                Funciones.mError(this, "Error al guardar" + ex);
            }

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string nombre = comboBox_categoria.SelectedValue.ToString();
            dataGridView_lista_producto_compuesto.DataSource = Categoria_Neg.listarCategorias(nombre);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox_nombre_producto_compuesto.Text.ToString();
            string categoria = comboBox_categoria.SelectedValue.ToString();
            dataGridView_lista_producto_compuesto.DataSource = ProductoCompuesto_Neg.listarProductosCompuestos(categoria, nombre);
        }
    }
}
