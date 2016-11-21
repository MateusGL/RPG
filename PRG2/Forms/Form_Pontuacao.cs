using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PRG2
{
    public partial class Form_Pontuacao : PRG2.Form1
    {
        public Form_Pontuacao()
        {
            InitializeComponent();            
            listBox1.Items.Clear();
            if (File.Exists("ficha.txt"))
            {
                Stream leitura = File.Open("ficha.txt", FileMode.Open);
                StreamReader e2 = new StreamReader(leitura);
                string[] auxiliar = new string[2];
                List<Player> lista = new List<Player>();
                Player p;

                while (e2.Peek() >= 0)
                {
                    auxiliar = e2.ReadLine().Split(':');
                    p = new Player(auxiliar[0]);
                    p.GetVitorias = Convert.ToInt32(auxiliar[1]);
                    lista.Add(p);
                }
                e2.Close();
                listBox1.Items.Add("Jogador" + "\t\t" + "Vitorias");
                foreach (var i in lista)
                {
                    listBox1.Items.Add(i.GetNome + "\t\t" + i.GetVitorias);
                }
            }
            else listBox1.Items.Add("Não existem jogadores cadastrados. ");
        }
        Form1 novo;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_TelaInicial();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }
    }
}
