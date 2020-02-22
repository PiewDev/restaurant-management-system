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
            dataGridView_armar.Columns.Add("nombre", "Materia Prima");
            dataGridView_armar.Columns.Add("cantidad", "Cantidad");
            dataGridView_armar.Columns.Add("precio", "");            
            dataGridView_armar.Columns[2].Visible = false;
            LabelCosto.Text = 0.ToString();
            comboBoxMateria.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
            comboBoxMateria.DisplayMember = "nombre";
            comboBoxMateria.ValueMember = "costo";
           
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
            /*FormListaMateriaPrima ventana_lista_materia_prima = new FormListaMateriaPrima();
            ventana_lista_materia_prima.Show();*/
            
            if (string.IsNullOrEmpty(textBoxCantidad.Text))
            {
                Funciones.mError(this, "Establezca una cantidad");
            }
            else
            {
                bool existe = false;
                foreach (DataGridViewRow Row in dataGridView_armar.Rows)
                {

                    string valor = Convert.ToString(Row.Cells["nombre"].Value);

                    if (valor == this.comboBoxMateria.Text)
                    {
                        int suma = Convert.ToInt32(Row.Cells["cantidad"].Value) + Convert.ToInt32(textBoxCantidad.Text);
                        Row.Cells["cantidad"].Value = suma.ToString();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    dataGridView_armar.Rows.Add(comboBoxMateria.Text, textBoxCantidad.Text, comboBoxMateria.SelectedValue);

                }
                ActualizarCosto();
            }
            this.dataGridView_armar.Refresh(); 
            
        }

        private void ActualizarCosto()
        {
            int suma = 0;
            foreach (DataGridViewRow Row in dataGridView_armar.Rows)
            {
                int valor = Convert.ToInt32(Row.Cells["cantidad"].Value);
                int costo = Convert.ToInt32(Row.Cells["precio"].Value);                
                suma += (valor * costo);
            }
            if(!string.IsNullOrEmpty(textBox_costo.Text))
                suma += Convert.ToInt32(textBox_costo.Text);
            LabelCosto.Text = suma.ToString();
            LabelCosto.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormArmarProductoCompuesto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'test_Final_Programacion_3DataSet.MateriaPrima2' Puede moverla o quitarla según sea necesario.
            this.materiaPrima2TableAdapter.Fill(this.test_Final_Programacion_3DataSet.MateriaPrima2);
            // TODO: esta línea de código carga datos en la tabla 'test_Final_Programacion_3DataSet.MateriaPrima2' Puede moverla o quitarla según sea necesario.
            this.materiaPrima2TableAdapter.Fill(this.test_Final_Programacion_3DataSet.MateriaPrima2);
            // TODO: esta línea de código carga datos en la tabla 'test_Final_Programacion_3DataSet.MateriaPrima2' Puede moverla o quitarla según sea necesario.
            this.materiaPrima2TableAdapter.Fill(this.test_Final_Programacion_3DataSet.MateriaPrima2);
    

        }
        private void textBox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                ;
                e.Handled = true;
                return;
            }
        }

        private void textBox_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            
        }       

        private void textBoxCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_eliminar_Click_1(object sender, EventArgs e)
        {
            dataGridView_armar.Rows.Remove(dataGridView_armar.CurrentRow);
            ActualizarCosto();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_costo_TextChanged(object sender, EventArgs e)
        {
            ActualizarCosto();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
