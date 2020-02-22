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
    public partial class FormMesa2 : Form
    {
        public FormMesa2()
        {
            InitializeComponent();
            dataGridView_Mesas.DataSource = Mesa_Neg.listarMesas();
            label_Mesa.Enabled = false;
            textBox_ID_Mesa.Enabled = false;
            button_Guardar_Modificado_Mesa.Enabled = false;
            //comboBox_estado.DataSource = Mesa_Neg.Combo_box_Mesa_Estado();
            //comboBox_estado.ValueMember = "id_estado";
            //comboBox_estado.DisplayMember = "nombre_estado";
        }

        private void limpiar()
        {
            textBox_ID_Mesa.Text = "";
            textBox_Numero_Mesa.Text = "";
            //comboBox_estado.SelectedIndex = 0;
        }

        private void resetear()
        {
            textBox_ID_Mesa.Enabled = false;
            label_Mesa.Enabled = false;
            button_Guardar_Modificado_Mesa.Enabled = false;
            button_Agregar_Mesa.Enabled = true;
        }

        private void button_Agregar_Mesa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mesa_Neg.guardarMesa(Convert.ToInt32(textBox_Numero_Mesa.Text), 0))
                {
                    Funciones.mOk(this, "Se a guardado correctamente");
                    limpiar();
                    dataGridView_Mesas.DataSource = Mesa_Neg.listarMesas();
                }
                else
                {
                    Funciones.mError(this, "Error al guardar");
                }
            }
            catch (Exception ex)
            {
                Funciones.mError(this, "Error" + ex);
            }
        }

        private void button_Cancelar_Mesa_Click(object sender, EventArgs e)
        {
            limpiar();
            resetear();
        }

        private void button_Modificar_Mesa_Click(object sender, EventArgs e)
        {
            textBox_ID_Mesa.Enabled = true;
            label_Mesa.Enabled = true;

            string indice = Convert.ToString(dataGridView_Mesas.CurrentRow.Cells["id_mesa"].Value);
            string numero = Convert.ToString(dataGridView_Mesas.CurrentRow.Cells["numero"].Value);
            //int estado = Convert.ToInt32(dataGridView_Mesas.CurrentRow.Cells["estado"].Value);

            button_Guardar_Modificado_Mesa.Enabled = true;
            button_Agregar_Mesa.Enabled = false;

            textBox_ID_Mesa.Text = indice;
            textBox_Numero_Mesa.Text = numero;
            //textBox_Estado_Mesa.Text = estado;
            //comboBox_estado.SelectedIndex = estado;

            string indice_modificado = textBox_ID_Mesa.Text;
            string numero_modificado = textBox_Numero_Mesa.Text;
            //string estado_modificado = textBox_Estado_Mesa.Text;
            //int estado_modificado = comboBox_estado.SelectedIndex;
        }

        private void button_Guardar_Modificado_Mesa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mesa_Neg.guardarModificadoMesa(Convert.ToInt32(textBox_ID_Mesa.Text), Convert.ToInt32(textBox_Numero_Mesa.Text)))
                {
                    Funciones.mOk(this, "Se a modificado correctamente");
                    limpiar();
                    dataGridView_Mesas.DataSource = Mesa_Neg.listarMesas();
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

        private void button_Eliminar_Mesa_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(dataGridView_Mesas.CurrentRow.Cells["id_mesa"].Value);

            try
            {
                if (Mesa_Neg.eliminarMesa(indice))
                {
                    Funciones.mOk(this, "Se a eliminado correctamente");
                    dataGridView_Mesas.DataSource = Mesa_Neg.listarMesas();
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

        private void textBox_Buscar_Mesa_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Buscar_Mesa.Text == "")
            {
                dataGridView_Mesas.DataSource = Mesa_Neg.listarMesas();
            }
            //if (textBox_Buscar_Mesa.Text != "")
            //{
            //    dataGridView_Mesas.CurrentCell = null;
            //    foreach (DataGridViewRow r1 in dataGridView_Mesas.Rows)
            //    {
            //        r1.Visible = false;
            //    }

            //    foreach (DataGridViewRow r1 in dataGridView_Mesas.Rows)
            //    {
            //        foreach (DataGridViewCell c1 in r1.Cells)
            //        {
            //            if ((c1.Value.ToString().ToUpper()).IndexOf(textBox_Buscar_Mesa.Text.ToUpper()) == 0)
            //            {
            //                r1.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_Mesas.DataSource = Mesa_Neg.listarMesas();
            //}
        }

        private void button_Buscar_Mesa_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox_Buscar_Mesa.Text);
            dataGridView_Mesas.DataSource = Mesa_Neg.listarMesas(numero);
        }
    }
}
