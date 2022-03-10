using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        public string jogada = "O";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
         if (jogada == "O")
            {
                btn1.Text = "X";
                jogada = "X";
                goto saida1;
            }
         if (jogada == "X")
            {
                btn1.Text = "O";
                jogada = "O";
                goto saida1;
            }
        saida1:;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                btn2.Text = "X";
                jogada = "X";
                goto saida2;
            }
            if (jogada == "X")
            {
                btn2.Text = "O";
                jogada = "O";
                goto saida2;
            }
        saida2:;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                btn3.Text = "X";
                jogada = "X";
                goto saida3;
            }
            if (jogada == "X")
            {
                btn3.Text = "O";
                jogada = "O";
                goto saida3;
            }
        saida3:;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                btn4.Text = "X";
                jogada = "X";
                goto saida4;
            }
            if (jogada == "X")
            {
                btn4.Text = "O";
                jogada = "O";
                goto saida4;
            }
        saida4:;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                btn5.Text = "X";
                jogada = "X";
                goto saida5;
            }
            if (jogada == "X")
            {
                btn5.Text = "O";
                jogada = "O";
                goto saida5;
            }
        saida5:;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                btn6.Text = "X";
                jogada = "X";
                goto saida6;
            }
            if (jogada == "X")
            {
                btn6.Text = "O";
                jogada = "O";
                goto saida6;
            }
        saida6:;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                btn7.Text = "X";
                jogada = "X";
                goto saida7;
            }
            if (jogada == "X")
            {
                btn7.Text = "O";
                jogada = "O";
                goto saida7;
            }
        saida7:;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                btn8.Text = "X";
                jogada = "X";
                goto saida8;
            }
            if (jogada == "X")
            {
                btn8.Text = "O";
                jogada = "O";
                goto saida8;
            }
        saida8:;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                btn9.Text = "X";
                jogada = "X";
                goto saida9;
            }
            if (jogada == "X")
            {
                btn9.Text = "O";
                jogada = "O";
                goto saida9;
            }
        saida9:;
        }

        private void btnRecriar_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }
    }
}
