using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.AliceBlue;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_MouseLeave(object sender, EventArgs e)
        {
            btnRegistro.BackColor = SystemColors.Control;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por registrarte!");
        }
    }
}
