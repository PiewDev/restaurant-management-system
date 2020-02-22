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
    public partial class FormListaProductoSimple : Form
    {
        public FormListaProductoSimple()
        {
            InitializeComponent();
            //comboBox_mozo.DataSource = Mozo_Neg.listarMozos();
            comboBox_categoria.DataSource = Categoria_Neg.listarCategoriasCombo();
            dataGridView_producto_simple.DataSource = ProductoSimple_Neg.listarProductosSimplesPedido();
        }
        
        private void button_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                FormComandaTemporal temporal = new FormComandaTemporal();
                int nro_mesa = temporal.valor_mesa();
         
                foreach (DataGridViewRow row in dataGridView_producto_simple.Rows)
                {
                    int mesa = nro_mesa;
                    int id_mozo = Convert.ToInt32(textBox_mozo.ToString());
                    int id_productosimple = Convert.ToInt32(row.Cells[0].Value);

                    Pedido_Neg.guardarTemporal(1, mesa, id_mozo, id_productosimple, 0);
                }

            }
            catch (Exception ex)
            {
                Funciones.mError(this, "Error al guardar" + ex);
            }

        }

        private void groupBox_producto_simple_Enter(object sender, EventArgs e)
        {

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string nombre = comboBox_categoria.SelectedValue.ToString();
            dataGridView_producto_simple.DataSource = Categoria_Neg.listarCategorias(nombre);
        }
    }
}
