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
    public partial class Form_NovoJogo : PRG2.Form1
    {
        public Form_NovoJogo()
        {
            InitializeComponent();

            button_Play.Enabled = false;
            button_cadastroj1.Enabled = false;
            button_cadastroj2.Enabled = false;

        }

        private void verifica_campo_vazio()
        {
            if (string.IsNullOrWhiteSpace(textBox_Jogador1.Text))
            {
                button_cadastroj1.Enabled = false;
            }
            else button_cadastroj1.Enabled = true;

            if (string.IsNullOrWhiteSpace(textBox_Jogador2.Text))
            {
                button_cadastroj2.Enabled = false;
            }
            else button_cadastroj2.Enabled = true;

            if (string.IsNullOrWhiteSpace(textBox_Jogador1.Text) || string.IsNullOrWhiteSpace(textBox_Jogador2.Text))
            {
                button_Play.Enabled = false;
            }
            else button_Play.Enabled = true;
        }

        Player Jogador1;
        Player Jogador2;

        //Só passar para o próxima página se usuários estiverem cadastrados

        private void button_Play_Click(object sender, EventArgs e)
        {
            string J1, J2;
            bool jogador1teste = false, jogador2teste = false;
            J1 = textBox_Jogador1.Text;
            J2 = textBox_Jogador2.Text;
            if (File.Exists("ficha.txt"))
            {
                Stream leitura = File.Open("ficha.txt", FileMode.Open);
                StreamReader e2 = new StreamReader(leitura);
                string[] verificar = new string[2];
                while (e2.Peek() >= 0)
                {
                    verificar = e2.ReadLine().Split(':');
                    if (verificar[0].ToUpper() == J1.ToUpper())
                    {
                        Jogador1 = new Player(J1); 
                        Jogador1.GetVitorias = Convert.ToInt32(verificar[1]);  //Atualiza vitorias do jogador
                        jogador1teste = true;
                    }
                    else if (verificar[0].ToUpper() == J2.ToUpper())
                    {
                        Jogador2 = new Player(J2);
                        Jogador2.GetVitorias = Convert.ToInt32(verificar[1]); //Atualiza vitorias do jogador
                        jogador2teste = true;
                    }
                }
                e2.Close();
                if (jogador1teste == true && jogador2teste == true)
                {                    
                    

                    this.Hide();
                    Form novo = new Form_Selecao(Jogador1, Jogador2);
                    novo.FormClosed += (s, args) => this.Close();
                    novo.Show();
                }
                else if (jogador1teste == false && jogador2teste == false)
                {
                    MessageBox.Show("jogadores não cadastrado, cadastre um novo jogador.", "Jogadores sem cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (jogador1teste == false)
                {
                    MessageBox.Show("Jogador 1 não cadastrado, cadastre o jogador 1.", "Jogador sem cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (jogador2teste == false)
                {
                    MessageBox.Show("Jogador 2 não cadastrado, cadastre o jogador 2.", "Jogador sem cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Nenhum jogador cadastrado.", "Jogadores sem cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox_Jogador1_TextChanged(object sender, EventArgs e)
        {
            verifica_campo_vazio();
        }

        private void textBox_Jogador2_TextChanged(object sender, EventArgs e)
        {
            verifica_campo_vazio();
        }

        private void cadastroj1()
        {
            string J1, ficha;
            J1 = textBox_Jogador1.Text;
            bool jogadorexiste = false;
            if (File.Exists("ficha.txt"))
            {
                Stream leitura = File.Open("ficha.txt", FileMode.Open);
                StreamReader e2 = new StreamReader(leitura);
                string[] verificar = new string[2];
                while (e2.Peek() >= 0)
                {
                    verificar = e2.ReadLine().Split(':');
                    if (verificar[0].ToUpper() == J1.ToUpper())
                    {
                        jogadorexiste = true;
                        MessageBox.Show("Insira outro nome.", "Jogador 1 existente",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                e2.Close();
                if (jogadorexiste == false)
                {
                    Stream escrita = File.Open("ficha.txt", FileMode.Append); //Cria arquivo de entrada
                    StreamWriter e1 = new StreamWriter(escrita);
                    ficha = J1 + ":0:";
                    e1.WriteLine(ficha);
                    e1.Close();
                    MessageBox.Show("Jogador cadastrado com sucesso.", "Jogador 1 cadastrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                Stream escrita = File.Open("ficha.txt", FileMode.Append); //Cria arquivo de entrada
                StreamWriter e1 = new StreamWriter(escrita);
                ficha = J1 + ":0:";
                e1.WriteLine(ficha);
                e1.Close();
                MessageBox.Show("Jogador cadastrado com sucesso.", "Jogador 1 cadastrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cadastroj2()
        {
            string J2, ficha;
            J2 = textBox_Jogador2.Text;
            bool jogadorexiste = false;
            if (File.Exists("ficha.txt"))
            {
                Stream leitura = File.Open("ficha.txt", FileMode.Open);
                StreamReader e2 = new StreamReader(leitura);
                string[] verificar = new string[2];
                while (e2.Peek() >= 0)
                {
                    verificar = e2.ReadLine().Split(':');
                    if (verificar[0].ToUpper() == J2.ToUpper())
                    {
                        jogadorexiste = true;
                        MessageBox.Show("Insira outro nome.", "Jogador 2 existente",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                e2.Close();
                if (jogadorexiste == false)
                {
                    Stream escrita = File.Open("ficha.txt", FileMode.Append); //Cria arquivo de entrada
                    StreamWriter e1 = new StreamWriter(escrita);
                    ficha = J2 + ":0:";
                    e1.WriteLine(ficha);
                    e1.Close();
                    MessageBox.Show("Jogador cadastrado com sucesso.", "Jogador 2 cadastrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                Stream escrita = File.Open("ficha.txt", FileMode.Append); //Cria arquivo de entrada
                StreamWriter e1 = new StreamWriter(escrita);
                ficha = J2 + ":0:";
                e1.WriteLine(ficha);
                e1.Close();
                MessageBox.Show("Jogador cadastrado com sucesso.", "Jogador 2 cadastrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_cadastroj1_Click(object sender, EventArgs e)
        {
            cadastroj1();
        }

        private void button_cadastroj2_Click(object sender, EventArgs e)
        {
            cadastroj2();
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