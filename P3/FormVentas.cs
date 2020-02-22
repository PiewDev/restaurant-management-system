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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            dataGridView_Ventas.DataSource = Comanda.listarComanda();
        }

        private void dataGridView_Ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
