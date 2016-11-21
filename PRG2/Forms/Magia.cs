using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2
{
    partial class Form_Magia : Form
    {
        //public Form_Selecao(Player j1, Player j2)
        Player Jogador1, Jogador2;
        bool VezdoJogador;
        int Pativo1, Pativo2;
        Form_Batalha Batalha;
        public Form_Magia(Player j1, Player j2, int P1, int P2, bool Vez)
        {

            Jogador1 = j1;
            Jogador2 = j2;
            VezdoJogador = Vez;
            Pativo1 = P1;
            Pativo2 = P2;
            InitializeComponent();



            int NMagias = Jogador1.GetPersonagens[Pativo1].GetMagias.Count();
            //
            ListViewItem item;
            //
            for (int x = 0; x < NMagias; x++)
            {
                item = new ListViewItem(Jogador1.GetPersonagens[Pativo1].GetMagias[x].GetNome.ToString());
                item.SubItems.Add(Jogador1.GetPersonagens[Pativo1].GetMagias[x].GetDano.ToString());
                item.SubItems.Add(Jogador1.GetPersonagens[Pativo1].GetMagias[x].GetCusto.ToString());
                listView_Magias.Items.Add(item);
            }

        }

        private void button_Magia_Click(object sender, EventArgs e)
        {
            int x = listView_Magias.SelectedItems.Count;

            if (VezdoJogador == true)
            {
                if ((Jogador2.GetPersonagens[Pativo2].GetVida - (Jogador1.GetPersonagens[Pativo1].GetMagias[x].GetDano + Jogador1.GetPersonagens[Pativo1].ForçaMagica)) > 0)
                {
                    Jogador2.GetPersonagens[Pativo2].AtaqueM(Jogador1.GetPersonagens[Pativo1].GetMagias[x].GetDano +
                    Jogador1.GetPersonagens[Pativo1].ForçaMagica);
                }
                else
                {
                    Jogador2.GetPersonagens[Pativo2].GetVida = 0;
                }
            }
            else
            {
                if ((Jogador2.GetPersonagens[Pativo2].GetVida - (Jogador1.GetPersonagens[Pativo1].GetMagias[x].GetDano + Jogador1.GetPersonagens[Pativo1].ForçaMagica)) > 0)
                {
                    Jogador1.GetPersonagens[Pativo1].AtaqueM(Jogador2.GetPersonagens[Pativo2].GetMagias[x].GetDano +
                    Jogador2.GetPersonagens[Pativo2].ForçaMagica);
                }
                else
                {
                    Jogador2.GetPersonagens[Pativo2].GetVida = 0;
                }
                
            }
            //
            //
            //
            this.Close();
        }
    }
}
