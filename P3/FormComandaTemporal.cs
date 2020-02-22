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
    public partial class FormComandaTemporal : Form
    {
        public FormComandaTemporal()
        {
            InitializeComponent();
            dataGridView_temporal.DataSource = ComandaTemporal.listarComandaTemporal();
            //comboBox_Mozo.ValueMember = "nombre";
        }

        private void FormComanda_Load(object sender, EventArgs e)
        {
            int total = 0;      

            foreach (DataGridViewRow row in dataGridView_temporal.Rows)
            {

                total += Convert.ToInt32(row.Cells[4].Value);
            }

            label_valor_total.Text = total.ToString();
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            int p_u = Convert.ToInt32(textBox_PrecioUnitario.Text);
            int cant = Convert.ToInt32(textBox_Cantidad.Text);
            int total = 0;

            dataGridView_Comanda.Rows.Add(textBox_IDComanda.Text, textBox_Categoria.Text, textBox_Tipo.Text, textBox_PrecioUnitario.Text, textBox_Cantidad.Text, p_u * cant);

            foreach (DataGridViewRow row in dataGridView_Comanda.Rows)
            {

                total += Convert.ToInt32(row.Cells[5].Value);
            }

            label13.Text = total.ToString();
        }
        */
        public void Nro_Mesa(string nro)
        {
            if (nro=="1")
            {
                label_valor_nro_mesa.Text = nro;
            }
            else
            {
                if (nro=="2")
                {
                    label_valor_nro_mesa.Text = nro;
                }
                else
                {
                    if(nro=="3")
                    {
                        label_valor_nro_mesa.Text = nro; 
                    }
                    else
                    {
                        if(nro=="4")
                        {
                            label_valor_nro_mesa.Text = nro;
                        }
                        else
                        {
                            if(nro=="5")
                            {
                                label_valor_nro_mesa.Text = nro;
                            }
                            else
                            {
                                if(nro=="6")
                                {
                                    label_valor_nro_mesa.Text = nro;
                                }
                            }
                        }
                    }
                }
            }
        }

        public int valor_mesa()
        {
            return Convert.ToInt32(label_valor_nro_mesa.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormQueProducto que_producto = new FormQueProducto();
            que_producto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nro_comanda = Convert.ToString(dataGridView_temporal.CurrentRow.Cells["id_temporal"].Value);
            string cod_producto_simple = Convert.ToString(dataGridView_temporal.CurrentRow.Cells["id_productosimple"].Value);
            string cod_producto_compuesto = Convert.ToString(dataGridView_temporal.CurrentRow.Cells["id_productocompuesto"].Value);
            string apellido = Convert.ToString(dataGridView_temporal.CurrentRow.Cells["apellido"].Value);
            string dni = Convert.ToString(dataGridView_temporal.CurrentRow.Cells["dni"].Value);
            string fecha_nacimiento = Convert.ToString(dataGridView_temporal.CurrentRow.Cells["fecha_nacimiento"].Value);

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

        private void button_aceptar_modificado_Click(object sender, EventArgs e)
        {
            try
            {

                if (Mozo_Neg.guardarModificadoMozo(Convert.ToInt32(textBox_ID_Mozo.Text), textBox_Nombre_Mozo.Text, textBox_Apellido_Mozo.Text, textBox_DNI_Mozo.Text, textBox_Fecha_Nacimiento.Text))
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
    }
}
