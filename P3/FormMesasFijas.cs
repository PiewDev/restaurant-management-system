using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class FormMesasFijas : Form
    {
        public FormMesasFijas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormComandaTemporal temporal = new FormComandaTemporal();

            temporal.Nro_Mesa(button_mesa_1.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormComandaTemporal temporal = new FormComandaTemporal();

            temporal.Nro_Mesa(button_mesa_2.Text.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormComandaTemporal temporal = new FormComandaTemporal();

            temporal.Nro_Mesa(button_mesa_3.Text.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormComandaTemporal temporal = new FormComandaTemporal();

            temporal.Nro_Mesa(button_mesa_4.Text.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormComandaTemporal temporal = new FormComandaTemporal();

            temporal.Nro_Mesa(button_mesa_5.Text.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormComandaTemporal temporal = new FormComandaTemporal();

            temporal.Nro_Mesa(button_mesa_6.Text.ToString());
        }
    }
}
