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
    public partial class FormArmarProductoCompuesto : Form
    {
        public FormArmarProductoCompuesto()
        {
            InitializeComponent();
            comboBox_categorias.DataSource = ProductoCompuesto_Neg.comboBox_Categoria();
            comboBox_categorias.DisplayMember = "nombre";
            comboBox_categorias.ValueMember = "id_categoria";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int id_materiaprima = Convert.ToInt32(this.dataGridView_armar.CurrentRow.Cells[0].Value.ToString());
            //int cantidad = Convert.ToInt32(this.dataGridView_armar.CurrentRow.Cells[1].Value.ToString());

            //MateriaPrima_Neg.descontarCantidad(id_materiaprima, cantidad);

            try
            {
                for (int fila = 0; fila < dataGridView_armar.Rows.Count - 1; fila++)
                {
                    for (int col = 0; col < dataGridView_armar.Rows[fila].Cells.Count; col++)
                    {
                        //string valor = dataGridView_armar.Rows[fila].Cells[col].Value.ToString();

                        int id_materiaprima = Convert.ToInt32(this.dataGridView_armar.Rows[fila].Cells[col].Value.ToString());
                        int cantidad = Convert.ToInt32(this.dataGridView_armar.Rows[fila].Cells[col + 1].Value.ToString());
                        MateriaPrima_Neg.descontarCantidad(id_materiaprima, cantidad);
                        break;
                    }
                }

                if (ProductoCompuesto_Neg.guardarProductoCompuesto(textBox_nombre.Text, Convert.ToInt32(comboBox_categorias.SelectedValue), Convert.ToInt32(textBox_costo.Text), Convert.ToInt32(textBox_precio_venta.Text), 0))
                {
                    Funciones.mOk(this, "Se a guardado correctamente");
                    //limpiar();
                    //dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos();
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

        private void button_agregar_ingredientes_Click(object sender, EventArgs e)
        {
            FormListaMateriaPrima ventana_lista_materia_prima = new FormListaMateriaPrima();
            ventana_lista_materia_prima.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormArmarProductoCompuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
