using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/join"); // Redirigir a esta pag
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/enterprise"); // Redirigir a esta pag
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Llamar al formulario que queremos usar
            var formularioSigIn = new FormSignIn();

            // Mostrar el formulario
            formularioSigIn.Show();

            // Cerrar el actual
            // this.Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Llamar al formulario FormConfigure
            var formularioFormConfigure = new FormConfigure();

            // Mosrar el formulario
            formularioFormConfigure.Show();
        }
    }
}
