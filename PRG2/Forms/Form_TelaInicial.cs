using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PRG2
{
    partial class Form_TelaInicial : PRG2.Form1
    {
        public Form_TelaInicial()
        {
            InitializeComponent();
            
        }
        Form1 novo;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_NovoJogo();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_Pontuacao();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_Carregar();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        //Fazer botão de carregar
    }
}
