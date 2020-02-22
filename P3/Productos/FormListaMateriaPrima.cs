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
    public partial class FormListaMateriaPrima : Form
    {
        public FormListaMateriaPrima()
        {
            InitializeComponent();
            //dataGridView_lista_materia_prima.DataSource = MateriaPrima_Neg.listarMateriasPrimas();
            comboBox_ingrediente.DataSource = MateriaPrima_Neg.listarIngredientes();
            comboBox_ingrediente.DisplayMember = "categoria";
            comboBox_ingrediente.ValueMember = "id_materiaprima";
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            //foreach(DataGridViewRow row in dataGridView_lista_materia_prima.SelectedRows)
            //{
            //    string A;
            //    string B;
            //    string C;
            //    string D;
            //    string E;
            //    string F;
            //    string G;

            //    A = this.dataGridView_lista_materia_prima.CurrentRow.Cells[0].Value.ToString();
            //    B = this.dataGridView_lista_materia_prima.CurrentRow.Cells[1].Value.ToString();
            //    C = this.dataGridView_lista_materia_prima.CurrentRow.Cells[2].Value.ToString();
            //    D = this.dataGridView_lista_materia_prima.CurrentRow.Cells[3].Value.ToString();
            //    E = this.dataGridView_lista_materia_prima.CurrentRow.Cells[4].Value.ToString();
            //    F = this.dataGridView_lista_materia_prima.CurrentRow.Cells[5].Value.ToString();
            //    G = this.dataGridView_lista_materia_prima.CurrentRow.Cells[6].Value.ToString();

            //    FormArmarProductoCompuesto dato = new FormArmarProductoCompuesto();
            //    foreach(Form frm in Application.OpenForms)
            //    {
            //        if(frm.Name == "FormArmarProductoCompuesto")
            //        {
            //            dato = (FormArmarProductoCompuesto)frm;
            //            dato.dataGridView_armar.Rows.Add(A, B, C, D, E, F, G);

            //            this.Close();
            //            break;
            //        }
            //    }
            //}
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            //FormArmarProductoCompuesto dato = new FormArmarProductoCompuesto();
            //int valor = Convert.ToInt32(textBox_cantidad.Text);
            //dato.dataGridView_armar.Rows.Add(comboBox_ingrediente.SelectedValue, comboBox_ingrediente.SelectedText,valor);
            //this.Close();

            FormArmarProductoCompuesto dato = new FormArmarProductoCompuesto();
            int valor = Convert.ToInt32(textBox_cantidad.Text);
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "FormArmarProductoCompuesto")
                {
                    dato = (FormArmarProductoCompuesto)frm;
                    dato.dataGridView_armar.Rows.Add(comboBox_ingrediente.SelectedValue, valor);

                    this.Close();
                    break;
                }
            }
        }
    }
}
