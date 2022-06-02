using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtNv_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 jg = new Form2();
            button1.Text = "¿OTRO INTENTO?";
            jg.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inicialmente, el jugador deberá elegir la posición de sus cuatro barcos haciendo clic en los botones de la mesa. Gana el que consiga más muertes de barcos en un ciclo de 10 rondas. Los enemigos pueden ganar puntos al retrasar el movimiento del jugador, por lo que el juego tendrá algunas dificultades. ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
