using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsApplication1.Properties;
namespace WindowsFormsApplication1
{

    public partial class Form2 : Form
    {
        public static int RODADA = 1;
        public static int barcosP = 5;
        public static int barcosE = 5;
        int rodadas = 10;
        Random aleatorio = new Random();
        public static int pontuacionP = 0;
        public static int pontuacionE = 0;
        List<Button> botonesjugador;
        List<Button> botonesenemigos;


        //criando numero aleatório
        public Form2()
        {
            InitializeComponent();
                barcosP = 5;
            RODADA = 1;
            pontuacionE = 0;
            pontuacionP = 0;
            this.DoubleBuffered = true;
            botones();
            alo.Text = null;
            inimigoCasas.Enabled = false;
            inimigoCasas.Text = null;
            textoAuxiliar.Text = "Poscionamiento de su navio clickeado los botones";
            alo.Text = "Rondas: " + rodadas;
            PONTUACAOE.Text = "Puntuación enemiga: "+pontuacionE;
            PONTUACAOP.Text = "Su puntuación: " + pontuacionP;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tempoJogadaInimigo_Tick(object sender, EventArgs e)
        {

        }

        private void Btn_a2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void AtaqueBot(object sender, EventArgs e)
        {
            if (rodadas == 0)
            {
                if (pontuacionE > pontuacionP)
                {
                    MessageBox.Show("RIVAL HA GANADO, HAS PERDIDO!!" +
                                " :( ");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);
                }
                else if (pontuacionP > pontuacionE)
                {
                    MessageBox.Show("RIVAL HA PERDIDO, LA VICTORIA ES TUYA!!" +
                                " :) ");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("EMPATE");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);

                }
            }
            for (int i = 0; i < 1; i++)
            {
                if (RODADA == 0)
                {
                    int resultado = aleatorio.Next(botonesenemigos.Count);
                    if (botonesenemigos[resultado].Tag == "NAVIO")
                    {
                        botonesenemigos[resultado].Tag = "";
                        botonesenemigos[resultado].BackgroundImage = Properties.Resources.bombardeiroEncontrado;
                        pontuacionE++;
                        PONTUACAOE.Text = "Puntuación enemiga: " + pontuacionE;
                        inimigoCasas.Enabled = true;
                        rodadas--;
                        alo.Text = "Rondas: " + rodadas;
                    }
                    else {

                        botonesenemigos[resultado].BackgroundImage = Properties.Resources.ONDA;
                    inimigoCasas.Enabled = true;
                        rodadas--;
                        alo.Text = "Rondas: " + rodadas;
                    }
                }
            }
            RODADA = 1;
        }
        private void inimigoCasas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (inimigoCasas.Text != "")
            {
                if (rodadas == 0)
                {
                    if (pontuacionE > pontuacionP)
                    {
                        MessageBox.Show("RIVAL HA GANADO, HAS PERDIDO!!" +
                                    " :(  ");
                        inimigoCasas.Enabled = false;
                        Environment.Exit(1);
                    }
                    else if (pontuacionP > pontuacionE)
                    {
                        MessageBox.Show("RIVAL HA PERDIDO, LA VICTORIA ES TUYA!!" +
                                    " :) ");
                        inimigoCasas.Enabled = false;
                        Environment.Exit(1);
                    }
                    else
                    {
                        MessageBox.Show("EMPATE");
                        inimigoCasas.Enabled = false;
                        Environment.Exit(1);

                    }
                }
                var escolha = inimigoCasas.Text;
                escolha = escolha.ToLower();
                int coordenada = botonesjugador.FindIndex(a => a.Name == escolha);
                if (botonesjugador[coordenada].Enabled)
                {

                    if (botonesjugador[coordenada].Tag == "NAVIO")
                    {
                        pontuacionP++;
                        PONTUACAOP.Text = "Su Puntuación: " + pontuacionP;
                        botonesjugador[coordenada].Enabled = false;
                        botonesjugador[coordenada].BackgroundImage = Properties.Resources.bombardeiroEncontrado;
                        inimigoCasas.Enabled = false; RODADA = 0;
                        RODADA = 0;
                        AtaqueBot(sender,e);
                    }
                    else
                    {
                        botonesjugador[coordenada].Enabled = false;
                        botonesjugador[coordenada].BackgroundImage = Properties.Resources.ONDA;
                        inimigoCasas.Enabled = false; RODADA = 0;
                        AtaqueBot(sender, e);
                    }
                }
            }
            else
            {
                textoAuxiliar.Text = "Elija una casilla existente";
            }
        }

        private void jogadorTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void posiçãodeataqueinimigo(object sender, EventArgs e)
        {

        }
        private void botones()
        {
            botonesjugador = new List<Button> { a1, a2, a3, a4, a5, this.b1, this.b2, this.b3, this.b4, this.b5, c1, c3, c2, c4, c5, d1, d2, d3, d4, d5, e1, e2, e3, e4, e5};
            botonesenemigos = new List<Button> { BtnBot_a1, BtnBot_a2, BtnBot_a3, BtnBot_a4, BtnBot_a5, BtnBot_b1, BtnBot_b2, BtnBot_b3, BtnBot_b4, BtnBot_b5, BtnBot_c1, BtnBot_c2, BtnBot_c3, BtnBot_c4, BtnBot_c5, BtnBot_d1, BtnBot_d2, BtnBot_d3, BtnBot_d4 , BtnBot_d5,
            BtnBot_e1, BtnBot_e2, BtnBot_e3, BtnBot_e4, BtnBot_e5};
            for (int i = 0; i < botonesjugador.Count; i++)
            {
                botonesjugador[i].Tag = i;

            }
            for (int i = 0; i < botonesenemigos.Count; i++)
            {
                botonesenemigos[i].Tag = null;
                inimigoCasas.Items.Add(botonesenemigos[i].Text);
            }
            //  PARTE MAIS ARCAICA DO PROGAMA 
            Random aleatorio = new Random();
            int b1 = 0; int b2 = 0; int b3 = 0; int b4 = 0; int b5 = 0; int l1 = 0; int l2 = 0; int l3 = 0; int l4 = 0; int l5 = 0;
            for (int i = 0; i < 5; i++)
            {


                int linha = aleatorio.Next(1, 5);
                int coluna = aleatorio.Next(1, 5);

                switch (i)
                {
                    case 0:
                        l1 = linha;
                        b1 = coluna;

                        break;
                    case 1:
                        l2 = linha;
                        b2 = coluna;

                        break;
                    case 2:

                        l3 = linha;
                        b3 = coluna;
                        break;
                    case 3:

                        l4 = linha;
                        b4 = coluna;
                        break;
                    case 4:

                        l5 = linha;
                        b5 = coluna;
                        break;

                }


                if (i == 3)
                {
                    if (l1 == l2 && b2 == b1)
                    {
                        i = -1;
                    }
                    if (l1 == l3 && b1 == b3)
                    {
                        i = -1;
                    }
                    if (l1 == l4 && b1 == b4)
                    {
                        i = -1;
                    }
                    if (l1 == l5 && b1 == b5)
                    {
                        i = -1;
                    }
                    if (l3 == l2 && b2 == b3)
                    {
                        i = -1;
                    }
                    if (l3 == l5 && b5 == b3)
                    {
                        i = -1;
                    }
                    if (l4 == l3 && b4 == b3)
                    {
                        i = -1;
                    }
                    if (l4 == l2 && b2 == b4)
                    {
                        i = -1;
                    }
                    if (l4 == l5 && b4 == b5)
                    {
                        i = -1;
                    }
                    if (l2 == l5 && b2 == b5)
                    {
                        i = -1;
                    }
                }

            }
            string[] a = new string[5] { "a", "b", "c", "d" , "e"};
            string l11 = "";
            string l22 = "";
            string l33 = "";
            string l44 = "";
            string l55 = "";

            int pa = 1;
            for (int i = 0; i < 5; i++)
            {

                if (l1 == pa)
                {
                    l11 = a[i];
                }
                if (l2 == pa)
                {
                    l22 = a[i];
                }
                if (l3 == pa)
                {
                    l33 = a[i];
                }
                if (l4 == pa)
                {
                    l44 = a[i];
                }
                if (l5 == pa)
                {
                    l55 = a[i];
                }
                pa++;
            }
            l11 += (b1);
            l22 += (b2);
            l33 += (b3);
            l44 += (b4);
            l55 += (b5);
            int coordenada1 = botonesjugador.FindIndex(b => b.Name == l11);            
            int coordenada2 = botonesjugador.FindIndex(b => b.Name == l22);
            int coordenada3 = botonesjugador.FindIndex(b => b.Name == l33);
            int coordenada4 = botonesjugador.FindIndex(b => b.Name == l44);
            int coordenada5 = botonesjugador.FindIndex(b => b.Name == l55);
            botonesjugador[coordenada1].Tag = "NAVIO";
            botonesjugador[coordenada2].Tag = "NAVIO";
            botonesjugador[coordenada3].Tag = "NAVIO";
            botonesjugador[coordenada4].Tag = "NAVIO";
            botonesjugador[coordenada5].Tag = "NAVIO";
        }

   


        private void Posiciondelenemigo(object sender, EventArgs e)

        {
            if (barcosP > 0)
            {
                
                var butao = (Button)sender;
                butao.Enabled = false;
                indicadorNavioslb.Text = "Navios Restantes: " + (barcosP -1);
                butao.Tag = "NAVIO";
                butao.BackgroundImage = Properties.Resources.bombardeiro;
                barcosP--;

            }
            if (barcosP == 0)
            {
               
                textoAuxiliar.Top = 100;
                textoAuxiliar.Left = 70;
                textoAuxiliar.Text = "Ahora elige la posición de bombardeo enemiga ";
                if (RODADA == 1)
                {
                    inimigoCasas.Enabled = true;
                    RODADA = 0;
                }
               
            }
            if (rodadas == 0)
            {
                if (pontuacionE > pontuacionP)
                {
                    MessageBox.Show("RIVAL HA GANADO, HAS PERDIDO!!" +
                                " :( ");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);
                }
                else if (pontuacionP > pontuacionE)
                {
                    MessageBox.Show("RIVAL HA PERDIDO, LA VICTORIA ES TUYA!!" +
                                " :)  ");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("EMPATE");
                    inimigoCasas.Enabled = false;
                    Environment.Exit(1);

                }
            }
        }

        private void Butao_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void a1_Click(object sender, EventArgs e)
        {

        }
    }
}
