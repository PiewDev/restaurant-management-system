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
    public partial class FormReporteVentasDiaria : Form
    {
        public FormReporteVentasDiaria()
        {
            InitializeComponent();
            //dataGridView_VentasDiarias.DataSource = Reportes_Neg.listarVentasDiaria();
        }

        //private void button_Buscar_Venta_Diaria_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        dataGridView_VentasDiarias.DataSource = Reportes_Neg.listarVentasDiaria(textBox_Fecha_Venta_Diaria.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        Funciones.mError(this, "Error" + ex);
        //    } 
        //}

        private void textBox_Fecha_Venta_Diaria_TextChanged(object sender, EventArgs e)
        {
            //if(textBox_Fecha_Venta_Diaria.Text == "")
            //{
            //    dataGridView_VentasDiarias.DataSource = Reportes_Neg.listarVentasDiaria();
            //}
            //if (textBox_Fecha_Venta_Diaria.Text != "")
            //{
            //    dataGridView_VentasDiarias.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView_VentasDiarias.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dataGridView_VentasDiarias.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper()).IndexOf(textBox_Fecha_Venta_Diaria.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_VentasDiarias.DataSource = Reportes_Neg.listarVentasDiaria();
            //}
        }

        private void button_Buscar_Fecha_Click(object sender, EventArgs e)
        {
            string fecha = textBox_Fecha_Venta_Diaria.Text;
            dataGridView_VentasDiarias.DataSource = Reportes_Neg.listarVentasDiaria(fecha);
        }

        private void dataGridView_VentasDiarias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
