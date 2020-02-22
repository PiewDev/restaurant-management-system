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
    public partial class FormMateriaPrima : Form
    {
        public FormMateriaPrima()
        {
            InitializeComponent();
            textBox_ID_Materia_Prima.Enabled = false;
            label_ID_Materia_Prima.Enabled = false;
            button_Guardar_Modificado_Materia_Prima.Enabled = false;
            dataGridView_Materias_Primas.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
            //comboBox_Categoria_Materia_Prima.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
            //comboBox_Categoria_Producto_Compuesto.DisplayMember = "Seleccionar..";
            //comboBox_Categoria_Materia_Prima.ValueMember = "nombre";
        }

        private void limpiar()
        {
            //textBox_Marca_Materia_Prima.Text = "";
            //comboBox_Categoria_Materia_Prima.ValueMember = "nombre";
            textBox_nombre_materia_prima.Text = "";
            textBox_Descripcion_Materia_Prima.Text = "";
            textBox_Costo_Materia_Prima.Text = "";
            textBox_Cantidad_Materia_Prima.Text = "";
        }

        private void resetear()
        {
            textBox_ID_Materia_Prima.Enabled = false;
            label_ID_Materia_Prima.Enabled = false;
            button_Guardar_Modificado_Materia_Prima.Enabled = false;
            button_Agregar_Materia_Prima.Enabled = true;
        }

        private void button_Agregar_Materia_Prima_Click(object sender, EventArgs e)
        {
            try
            {
                if (MateriaPrima_Neg.guardarMateriaPrima(/*textBox_Marca_Materia_Prima.Text,*/ textBox_nombre_materia_prima.Text, textBox_Descripcion_Materia_Prima.Text, Convert.ToInt32(textBox_Costo_Materia_Prima.Text), Convert.ToInt32(textBox_Cantidad_Materia_Prima.Text), 0))
                {
                    Funciones.mOk(this, "Se a guardado correctamente");
                    limpiar();
                    dataGridView_Materias_Primas.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
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

        private void button_Cancelar_Materia_Prima_Click(object sender, EventArgs e)
        {
            limpiar();
            resetear();
        }

        private void button_Guardar_Modificado_Materia_Prima_Click(object sender, EventArgs e)
        {
            try
            {
                if (MateriaPrima_Neg.guardarModificadoMateriaPrima(Convert.ToInt32(textBox_ID_Materia_Prima.Text), /*textBox_Marca_Materia_Prima.Text,*/ textBox_nombre_materia_prima.Text, textBox_Descripcion_Materia_Prima.Text, Convert.ToInt32(textBox_Costo_Materia_Prima.Text), Convert.ToInt32(textBox_Cantidad_Materia_Prima.Text)))
                {
                    Funciones.mOk(this, "Se a modificado correctamente");
                    limpiar();
                    dataGridView_Materias_Primas.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
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

        private void button_Modificar_Materia_Prima_Click(object sender, EventArgs e)
        {
            textBox_ID_Materia_Prima.Enabled = true;
            label_ID_Materia_Prima.Enabled = true;

            string indice = Convert.ToString(dataGridView_Materias_Primas.CurrentRow.Cells["id_materiaprima"].Value);
            string nombre = Convert.ToString(dataGridView_Materias_Primas.CurrentRow.Cells["nombre"].Value);
            //string categoria = Convert.ToString(dataGridView_Materias_Primas.CurrentRow.Cells["categoria"].Value);
            string descripcion = Convert.ToString(dataGridView_Materias_Primas.CurrentRow.Cells["descripcion"].Value);
            string costo = Convert.ToString(dataGridView_Materias_Primas.CurrentRow.Cells["costo"].Value);
            string cantidad = Convert.ToString(dataGridView_Materias_Primas.CurrentRow.Cells["cantidad"].Value);

            button_Guardar_Modificado_Materia_Prima.Enabled = true;
            button_Agregar_Materia_Prima.Enabled = false;

            textBox_ID_Materia_Prima.Text = indice;
            //textBox_Marca_Materia_Prima.Text = marca;
            textBox_nombre_materia_prima.Text = nombre;
            textBox_Descripcion_Materia_Prima.Text = descripcion;
            textBox_Costo_Materia_Prima.Text = costo;
            textBox_Cantidad_Materia_Prima.Text = cantidad;

            string indice_modificado = textBox_ID_Materia_Prima.Text;
            //string marca_modificado = textBox_Marca_Materia_Prima.Text;
            string nombre_modificado = textBox_nombre_materia_prima.Text;
            string descripcion_modificado = textBox_Descripcion_Materia_Prima.Text;
            string costo_modificado = textBox_Costo_Materia_Prima.Text;
            string cantidad_modificado = textBox_Cantidad_Materia_Prima.Text;
        }

        private void button_Eliminar_Materia_Prima_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(dataGridView_Materias_Primas.CurrentRow.Cells["id_materiaprima"].Value);

            try
            {
                if (MateriaPrima_Neg.eliminarMateriaPrima(indice))
                {
                    Funciones.mOk(this, "Se a eliminado correctamente");
                    dataGridView_Materias_Primas.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
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

        private void textBox_Buscar_Materia_Prima_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Buscar_Materia_Prima.Text == "")
            {
                dataGridView_Materias_Primas.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
            }
            //if (textBox_Buscar_Materia_Prima.Text != "")
            //{
            //    dataGridView_Materias_Primas.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView_Materias_Primas.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dataGridView_Materias_Primas.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper()).IndexOf(textBox_Buscar_Materia_Prima.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_Materias_Primas.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
            //}
        }

        private void button_Buscar_Materia_Prima_Click(object sender, EventArgs e)
        {
            string categoria = textBox_Buscar_Materia_Prima.Text;
            dataGridView_Materias_Primas.DataSource = MateriaPrima_Neg.listarMateriasPrimas(categoria);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
