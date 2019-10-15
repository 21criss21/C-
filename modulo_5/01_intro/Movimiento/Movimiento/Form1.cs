using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Obtener el valor de la tecla
            var keyValue = e.KeyValue;

            var posicionX = label1.Location.X;
            var posicionY = label1.Location.Y;

            // Reset
            if (keyValue == 82)
            {
                // Centrado relativo al padre
                var anchoPadre = label3.Width;
                var anchoHijo = label1.Width;
                var margenX = label3.Location.X;

                var centroX = ((anchoPadre + anchoHijo) / 2) - margenX;

                var altoPadre = label3.Height;
                var altoHijo = label1.Height;
                var margenY = label3.Location.Y;

                var centroY = ((altoPadre + altoHijo) / 2) - margenY;

                // Centrado absoluto (al formulario)
                anchoPadre = this.Width;
                anchoHijo = label1.Width;
                
                alturaPadre = this.Height;
                alturaHijo = label1.Height;
               

                centroY = (alturaPadre + alturaHijo) / 2;
                centroX = (anchoPadre + anchoHijo) / 2;

                MessageBox.Show("Reseting game...");
                label1.Location = new System.Drawing.Point(centroX, centroY);
            }

            // Cambiar color
            if (keyValue == 67)
            {
                MessageBox.Show("Cambiando color...");
            }

           

            // MessageBox.Show( posicionX.ToString() );
            // MessageBox.Show( posicionY.ToString() );

            // label1.Location = new System.Drawing.Point(0, 0);

            // Izquierda
            if (keyValue == 37 || keyValue == 65)
            {

                if (posicionX <= 15)
                {
                    return;
                }
                // MessageBox.Show("Flecha a la izquierda");
                label1.Location = new System.Drawing.Point(posicionX - 5, posicionY);
                label2.Text = label1.Location.ToString();
            }

            // Derecha
            if (keyValue == 39 || keyValue == 68)
            {

                if (posicionX >= 332)
                {
                    return;
                }
                // MessageBox.Show("Flecha a la derecha");
                label1.Location = new System.Drawing.Point(posicionX + 5, posicionY);
                label2.Text = label1.Location.ToString();
            }

            // Abajo
            if (keyValue == 40 || keyValue == 83)
            {

                if (posicionY >= 409)
                {
                    return;
                }
                // MessageBox.Show("Flecha para abajo");
                label1.Location = new System.Drawing.Point(posicionX, posicionY + 5);
                label2.Text = label1.Location.ToString();
            }

            // Arriba
            if (keyValue == 38 || keyValue == 87)
            {

                if (posicionY <= 39)
                {
                    return;
                }
                // MessageBox.Show("Flecha para arriba");
                label1.Location = new System.Drawing.Point(posicionX, posicionY - 5);
                label2.Text = label1.Location.ToString();
            }

            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void o(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
