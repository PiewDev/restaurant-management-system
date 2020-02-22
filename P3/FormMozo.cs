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
    public partial class FormMozo : Form
    {
        public FormMozo()
        {
            InitializeComponent();
            textBox_ID_Mozo.Enabled = false;
            label_ID_Mozo.Enabled = false;
            dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos();
            button_Guardar_Modificado.Enabled = false;
        }

        private void limpiar()
        {
            textBox_ID_Mozo.Text = "";
            textBox_Nombre_Mozo.Text = "";
            textBox_Apellido_Mozo.Text = "";
            textBox_DNI_Mozo.Text = "";
            textBox_Fecha_Nacimiento.Text = "";
        }

        private void button_Agregar_Mozo_Click(object sender, EventArgs e)
        {
            try
            {
                //Mozo_Neg mozo = new Mozo_Neg();

                if (Mozo_Neg.guardarMozo(textBox_Nombre_Mozo.Text, textBox_Apellido_Mozo.Text, textBox_DNI_Mozo.Text, textBox_Fecha_Nacimiento.Text,0))
                {
                    Funciones.mOk(this, "Se a guardado correctamente");
                    limpiar();
                    dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos();
                }
                else
                {
                    Funciones.mError(this, "Error al guardar, estoy en el ELSE");
                }
            }
            catch(Exception ex)
            {
                Funciones.mError(this, "Error al guardar"+ex);
            }
        }

        private void resetear()
        {
            textBox_ID_Mozo.Enabled = false;
            label_ID_Mozo.Enabled = false;
            button_Guardar_Modificado.Enabled = false;
            button_Agregar_Mozo.Enabled = true;
        }

        private void button_Mozo_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            resetear();
        }

        private void Mozo_Load(object sender, EventArgs e)
        {

        }

        private void button_Buscar_Mozo_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dataGridView_Mozos.DataSource = Mozo_Neg.buscarMozos(textBox_Buscar_Mozo.Text);            
            //}
            //catch(Exception)
            //{
            //    Funciones.mOk(this, "No se a encontrado");
            //}

            //if(textBox_Buscar_Mozo.Text != "")
            //{
            //    dataGridView_Mozos.CurrentCell = null;
            //    foreach(DataGridViewRow r in dataGridView_Mozos.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach(DataGridViewRow r in dataGridView_Mozos.Rows)
            //    {
            //        foreach(DataGridViewCell c in r.Cells)
            //        {
            //            if((c.Value.ToString().ToUpper()).IndexOf(textBox_Buscar_Mozo.Text.ToUpper())==0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos();
            //}
        }

        private void dataGridView_Mozos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            string indice = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["id"].Value);
            string nombre = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["nombre"].Value);
            string apellido = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["apellido"].Value);
            string dni = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["dni"].Value);
            string fecha_nacimiento = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["fecha_nacimiento"].Value);

            textBox_ID_Mozo.Text = indice;
            textBox_Nombre_Mozo.Text = nombre;
            textBox_Apellido_Mozo.Text = apellido;
            textBox_DNI_Mozo.Text = dni;
            textBox_Fecha_Nacimiento.Text = fecha_nacimiento;
            */
        }

        private void button_Modificar_Mozo_Click(object sender, EventArgs e)
        {
            textBox_ID_Mozo.Enabled = true;
            label_ID_Mozo.Enabled = true;

            string indice = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["id_mozo"].Value);
            string nombre = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["nombre"].Value);
            string apellido = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["apellido"].Value);
            string dni = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["dni"].Value);
            string fecha_nacimiento = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["fecha_nacimiento"].Value);

            button_Guardar_Modificado.Enabled = true;
            button_Agregar_Mozo.Enabled = false;

            textBox_ID_Mozo.Text = indice;
            textBox_Nombre_Mozo.Text = nombre;
            textBox_Apellido_Mozo.Text = apellido;
            textBox_DNI_Mozo.Text = dni;
            textBox_Fecha_Nacimiento.Text = fecha_nacimiento;

            string indice_modificado = textBox_ID_Mozo.Text;
            string nombre_modificado = textBox_Nombre_Mozo.Text;
            string apellido_modificado = textBox_Apellido_Mozo.Text;
            string dni_modificado = textBox_DNI_Mozo.Text;
            string fecha_nacimiento_modificado = textBox_Fecha_Nacimiento.Text;
        }

        private void button_Guardar_Modificado_Click(object sender, EventArgs e)
        {
            try
            {
                //Mozo_Neg mozo = new Mozo_Neg();

                if (Mozo_Neg.guardarModificadoMozo(Convert.ToInt32(textBox_ID_Mozo.Text),textBox_Nombre_Mozo.Text, textBox_Apellido_Mozo.Text, textBox_DNI_Mozo.Text, textBox_Fecha_Nacimiento.Text))
                {
                    Funciones.mOk(this, "Se a modificado correctamente");
                    limpiar();
                    dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos();
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

        private void button_Eliminar_Mozo_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(dataGridView_Mozos.CurrentRow.Cells["id_mozo"].Value);

            try
            {
                Mozo_Neg mozo = new Mozo_Neg();

                if(mozo.eliminarMozo(indice))
                {
                    Funciones.mOk(this, "Se a eliminado correctamente");
                    dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos();
                }
                else
                {
                    Funciones.mError(this, "Error al eliminar");
                }

            }
            catch(Exception)
            {
                Funciones.mError(this, "Error al eliminar");
            }
        }

        private void textBox_Buscar_Mozo_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Buscar_Mozo.Text == "")
            {
                dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos();
            }
            //if (textBox_Buscar_Mozo.Text != "")
            //{
            //    dataGridView_Mozos.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView_Mozos.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dataGridView_Mozos.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper()).IndexOf(textBox_Buscar_Mozo.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos();
            //}
        }

        private void button_Buscar_Mozo_Click_1(object sender, EventArgs e)
        {
            //string nombre = Convert.ToString(dataGridView_Mozos.CurrentRow.Cells["nombre"].Value);
            string nombre = textBox_Buscar_Mozo.Text;
            dataGridView_Mozos.DataSource = Mozo_Neg.listarMozos(nombre);
        }
    }
}
