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
            //dataGridView_temporal.DataSource = ComandaTemporal.listarComandaTemporal();
            //comboBox_Mozo.ValueMember = "nombre";
        }

        private void FormComanda_Load(object sender, EventArgs e)
        {
            int total = 0;      

            foreach (DataGridViewRow row in dataGridViewProductos.Rows)
            {

                total += Convert.ToInt32(row.Cells[4].Value);
            }

            
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
                
        }

        private void button_aceptar_modificado_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_temporal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
