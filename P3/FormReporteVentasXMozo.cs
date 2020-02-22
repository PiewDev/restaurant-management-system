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
    public partial class FormReporteVentasXMozo : Form
    {
        public FormReporteVentasXMozo()
        {
            InitializeComponent();
            dataGridView_VentasXMozo.DataSource = Reportes_Neg.listarVentasXMozo();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        dataGridView_VentasXMozo.DataSource = Reportes_Neg.listarVentasXMozo(textBox_Mozo.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        Funciones.mError(this, "Error al guardar" + ex);
        //    }
        //}

        private void textBox_Mozo_TextChanged(object sender, EventArgs e)
        {
            //if(textBox_Mozo.Text == "")
            //{
            //    dataGridView_VentasXMozo.DataSource = Reportes_Neg.listarVentasXMozo();
            //}
            //if (textBox_Mozo.Text != "")
            //{
            //    dataGridView_VentasXMozo.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView_VentasXMozo.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dataGridView_VentasXMozo.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper()).IndexOf(textBox_Mozo.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    dataGridView_VentasXMozo.DataSource = Reportes_Neg.listarVentasXMozo();
            //}
        }

        private void button_Buscar_Venta_Mozo_Click(object sender, EventArgs e)
        {
            //string mozo = textBox_Mozo.Text;
            //dataGridView_VentasXMozo.DataSource = Reportes_Neg.listarVentasXMozo();
        }

        private void dataGridView_VentasXMozo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
