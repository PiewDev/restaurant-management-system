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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
            label_ID_Categoria.Enabled = false;
            textBox_ID_Categoria.Enabled = false;
            dataGridView_Categoria.DataSource = Categoria_Neg.listarCategorias();
        }

        private void limpiar()
        {
            textBox_ID_Categoria.Text = "";
            textBox_Nombre_Categoria.Text = "";
            textBox_simple_compuesto.Text = "";
        }

        private void resetear()
        {
            textBox_ID_Categoria.Enabled = false;
            label_ID_Categoria.Enabled = false;
            button_Guardar_Modificado_Categoria.Enabled = false;
            button_Agregar_Categoria.Enabled = true;
        }

        private void button_Agregar_Categoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (Categoria_Neg.guardarCategoria(textBox_Nombre_Categoria.Text, textBox_simple_compuesto.Text, 0))
                {
                    Funciones.mOk(this, "Se a guardado correctamente");
                    limpiar();
                    dataGridView_Categoria.DataSource = Categoria_Neg.listarCategorias();
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

        private void button_Cancelar_Categoria_Click(object sender, EventArgs e)
        {
            limpiar();
            resetear();
        }

        private void button_Modificar_Categoria_Click(object sender, EventArgs e)
        {
            textBox_ID_Categoria.Enabled = true;
            label_ID_Categoria.Enabled = true;

            string indice = Convert.ToString(dataGridView_Categoria.CurrentRow.Cells["id_categoria"].Value);
            string nombre = Convert.ToString(dataGridView_Categoria.CurrentRow.Cells["nombre"].Value);
            string tipo = Convert.ToString(dataGridView_Categoria.CurrentRow.Cells["tipo"].Value);

            button_Guardar_Modificado_Categoria.Enabled = true;
            button_Agregar_Categoria.Enabled = false;

            textBox_ID_Categoria.Text = indice;
            textBox_Nombre_Categoria.Text = nombre;
            textBox_simple_compuesto.Text = tipo;

            string indice_modificado = textBox_ID_Categoria.Text;
            string nombre_modificado = textBox_Nombre_Categoria.Text;
            string tipo_modificado = textBox_simple_compuesto.Text;
        }

        private void button_Guardar_Modificado_Categoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (Categoria_Neg.guardarModificadoCategoria(Convert.ToInt32(textBox_ID_Categoria.Text), textBox_Nombre_Categoria.Text, textBox_simple_compuesto.Text))
                {
                    Funciones.mOk(this, "Se a modificado correctamente");
                    limpiar();
                    dataGridView_Categoria.DataSource = Categoria_Neg.listarCategorias();
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

        private void button_Eliminar_Categoria_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(dataGridView_Categoria.CurrentRow.Cells["id_categoria"].Value);

            try
            {
                if (Categoria_Neg.eliminarCategoria(indice))
                {
                    Funciones.mOk(this, "Se a eliminado correctamente");
                    dataGridView_Categoria.DataSource = Categoria_Neg.listarCategorias();
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

        private void textBox_Buscar_Categoria_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Buscar_Categoria.Text == "")
            {
                dataGridView_Categoria.DataSource = Categoria_Neg.listarCategorias();
            }
            //if (textBox_Buscar_Categoria.Text != "")
            //{
            //    dataGridView_Categoria.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView_Categoria.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dataGridView_Categoria.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper()).IndexOf(textBox_Buscar_Categoria.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_Categoria.DataSource = Categoria_Neg.listarCategorias();
            //}
        }

        private void button_Buscar_Categoria_Click(object sender, EventArgs e)
        {
            string nombre = textBox_Buscar_Categoria.Text;
            dataGridView_Categoria.DataSource = Categoria_Neg.listarCategorias(nombre);
        }
    }
}
