﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRG2
{
    partial class Form_Selecao : PRG2.Form1
    {
        Player jogador1, jogador2;
        public Form_Selecao(Player j1, Player j2)
        {
            InitializeComponent();
            jogador1 = j1;
            jogador2 = j2;

            button_Play.Enabled = false;

        }

        private void habilitar_botao_play()
        {
            bool aux_inu = false;
            bool aux_hum = false;


            if (checkBox_Animal.Checked == true || checkBox_Dragao.Checked == true || checkBox_Troll.Checked == true || checkBox_Zumbi.Checked == true)
            {
                aux_inu = true;
            }
            if (checkBox_Guerreiro.Checked == true || checkBox_Ladrao.Checked == true || checkBox_Mago.Checked == true || checkBox_Paladino.Checked == true)
            {
                aux_hum = true;
            }
            if (aux_hum == true && aux_inu == true)
            {
                button_Play.Enabled = true;
            }
            

            else button_Play.Enabled = false;
        }

        private void checkBox_Guerreiro_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_botao_play();
        }

        private void checkBox_Paladino_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_botao_play();
        }

        private void checkBox_Ladrao_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_botao_play();
        }

        private void checkBox_Mago_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_botao_play();
        }

        private void checkBox_Dragao_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_botao_play();
        }

        private void checkBox_Animal_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_botao_play();
        }

        private void checkBox_Troll_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_botao_play();
        }

        private void checkBox_Zumbi_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_botao_play();
        }
        Form1 novo;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_TelaInicial();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_NovoJogo();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            Classes.Magias Magia;
            int x = 0;

            //Fazer tratamento para quando nenhum personagem for selecionado
            //if () { }

            // Guerreiro
            if (checkBox_Guerreiro.Checked == true)
            {
                Armas armas = new Armas("Porrete", 280);
                Armas armas2 = new Armas("Espada Barroca", 400);
                Humanos Guerreiro = new Humanos("Guerreiro", 4000, 30, 100, 20, 80, 20, 50, armas, armas2);
                jogador1.RecebePersonagem(Guerreiro);
                //
                x = jogador1.GetNumeroPersonagens;
                Magia = new Classes.Magias("Tempestade", 200, 12, false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                jogador1.GetPersonagens[x - 1].vidatotal = 4000;
                jogador1.GetPersonagens[x - 1].manatotal = 30;
            }

            // Paladino
            if (checkBox_Paladino.Checked == true)
            {
                Armas armas = new Armas("Tridente Sagrado", 320);
                Armas armas2 = new Armas("Besta", 320);
                //
                Humanos Paladino = new Humanos("Paladino", 3200, 80, 60, 60, 60, 60, 60, armas, armas2);
                jogador1.RecebePersonagem(Paladino);
                //
                x = jogador1.GetNumeroPersonagens;
                Magia = new Classes.Magias("Poção de Vida", 200, 12,true);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                //
                Magia = new Classes.Magias("Flama Gelada", 320, 14, false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                //
                Magia = new Classes.Magias("Tempestade", 200, 12,false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                jogador1.GetPersonagens[x - 1].vidatotal = 3200;
                jogador1.GetPersonagens[x - 1].manatotal = 80;
            }

            // Ladrao
            if (checkBox_Ladrao.Checked == true)
            {
                Armas armas = new Armas("Cajado", 100);
                Armas armas2 = new Armas("Porrete", 280);
                Armas armas3 = new Armas("Besta", 320);
                Armas armas4 = new Armas("Esfera de Ataque", 300);
                //
                Humanos Ladrao = new Humanos("Ladrao", 2800, 50, 50, 30, 40, 50, 100, armas, armas2, armas3, armas4);
                jogador1.RecebePersonagem(Ladrao);
                //
                x = jogador1.GetNumeroPersonagens;
                Magia = new Classes.Magias("Intoxicação", 280, 12,false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                //
                Magia = new Classes.Magias("Tempestade", 200, 12,false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                jogador1.GetPersonagens[x - 1].vidatotal = 2800;
                jogador1.GetPersonagens[x - 1].manatotal = 50;
            }

            // Mago
            if (checkBox_Mago.Checked == true)
            {
                Armas armas = new Armas("Cajado", 100);
                Armas armas2 = new Armas("Tridente Sagrado", 320);
                //
                Humanos Mago = new Humanos("Mago", 2500, 100, 40, 100, 30, 100, 40, armas);
                jogador1.RecebePersonagem(Mago);
                //
                x = jogador1.GetNumeroPersonagens;
                Magia = new Classes.Magias("Poção de Vida", 200, 12,true);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                //
                Magia = new Classes.Magias("Bio", 360, 14,false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                //
                Magia = new Classes.Magias("Cura", 400, 16,true);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                //
                Magia = new Classes.Magias("Flama Gelada", 320, 14,false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                //
                Magia = new Classes.Magias("Intoxicação", 280, 12,false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                //
                Magia = new Classes.Magias("Tempestade", 200, 12,false);
                jogador1.GetPersonagens[x - 1].AddMagia(Magia);
                jogador1.GetPersonagens[x - 1].vidatotal = 2500;
                jogador1.GetPersonagens[x - 1].manatotal = 100;
            }

            //
            // Inumanos 
            //

            // Dragao
            if (checkBox_Dragao.Checked == true)
            {
                Armas armas = new Armas("Garra Letal", 200);
                //
                Inumanos Dragao = new Inumanos("Dragao", 3000, 40, 100, 20, 100, 50, 80, armas);
                jogador2.RecebePersonagem(Dragao);
                //
                x = jogador2.GetNumeroPersonagens;
                Magia = new Classes.Magias("Hálito de Fogo", 400, 12, false);
                jogador2.GetPersonagens[x - 1].AddMagia(Magia);
                jogador2.GetPersonagens[x - 1].vidatotal = 3000;
                jogador2.GetPersonagens[x - 1].manatotal = 40;
            }
            // Animal
            if (checkBox_Animal.Checked == true)
            {
                Armas armas = new Armas("Garra Letal", 200);
                //
                Inumanos Animal = new Inumanos("Animal", 3200, 30, 80, 20, 90, 20, 50, armas);
                jogador2.RecebePersonagem(Animal);
                //
                x = jogador2.GetNumeroPersonagens;
                Magia = new Classes.Magias("Bio", 360, 14, false);
                jogador2.GetPersonagens[x - 1].AddMagia(Magia);
                jogador2.GetPersonagens[x - 1].vidatotal = 3200;
                jogador2.GetPersonagens[x - 1].manatotal = 30;
            }
            //  Troll
            if (checkBox_Troll.Checked == true)
            {
                Armas armas = new Armas("Cajado", 100);
                Armas armas2 = new Armas("Porrete", 280);
                //
                Inumanos Troll = new Inumanos("Troll", 2800, 20, 100, 20, 100, 20, 20, armas, armas2);
                jogador2.RecebePersonagem(Troll);
                //
                x = jogador2.GetNumeroPersonagens;
                Magia = new Classes.Magias("Intoxicação", 280, 12, false);
                jogador2.GetPersonagens[x - 1].AddMagia(Magia);
                jogador2.GetPersonagens[x - 1].vidatotal = 2800;
                jogador2.GetPersonagens[x - 1].manatotal = 20;
            }
            //  Zumbi
            if (checkBox_Zumbi.Checked == true)
            {
                Armas armas = new Armas("Cajado", 100);
                Armas armas2 = new Armas("Garra Letal", 200);
                Armas armas3 = new Armas("Porrete", 280);
                //
                Inumanos Zumbi = new Inumanos("Zumbi", 2500, 20, 40, 20, 80, 90, 20, armas, armas2, armas3);
                jogador2.RecebePersonagem(Zumbi);
                //
                x = jogador2.GetNumeroPersonagens;
                Magia = new Classes.Magias("Intoxicação", 280, 12, false);
                jogador2.GetPersonagens[x - 1].AddMagia(Magia);
                jogador2.GetPersonagens[x - 1].vidatotal = 2500;
                jogador2.GetPersonagens[x - 1].manatotal = 20;
            }
            this.Hide();
            Form novo = new Form_Batalha(jogador1, jogador2);
            novo.FormClosed += (s, args) => this.Close();
            novo.Show();            
        }
    }
}
