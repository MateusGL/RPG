using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRG2
{
    public partial class Form_NovoJogo : PRG2.Form1
    {
        public Form_NovoJogo()
        {
            InitializeComponent();
        }
        Player Jogador1;
        Player Jogador2;
        private void button_Play_Click(object sender, EventArgs e)
        {
            string J1, J2;
            J1 = textBox_Jogador1.Text;
            J2 = textBox_Jogador2.Text;

            Jogador1 = new Player(J1);
            Jogador2 = new Player(J2);
            Form novo = new Form_Selecao(Jogador1,Jogador2);
            novo.Show();
    }
}
}
