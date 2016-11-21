using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PRG2
{
    partial class Form_Batalha : PRG2.Form1
    {
        Player jogador1, jogador2;
        bool Ativo = false;
        string nome, img1, img2, aplicacao;
        int ArmaAtiva1 = 0, ArmaAtiva2 = 0, PAtivo1 = 0, PAtivo2 = 0, Magia1, Magia2, MaxMana1, MaxMana2;
        // 
        public Form_Batalha(Player j1, Player j2)
        {
            InitializeComponent();



            // colocar todas as inicializações em uma função para facilitar a troca de personagem
            //
            pictureBox_Personagem2.ImageLocation = "PRG2/Dragao1.jpg";
            aplicacao = Application.StartupPath;
            //
            //MessageBox.Show(aplicacao);
            //
            label_TrocaVez.Text = "Vez do Jogador 1";
            //
            jogador1 = j1;
            jogador2 = j2;
            //

            ArmaAtiva1 = jogador1.armaativa;
            ArmaAtiva2 = jogador2.armaativa;
            PAtivo1 = jogador1.Pativo;
            PAtivo2 = jogador2.Pativo;
            Magia1 = jogador1.magia;
            Magia2 = jogador2.magia;
            MaxMana1 = jogador1.maxmana;
            MaxMana2 = jogador2.maxmana;
            Ativo = jogador1.Ativo;

            //
            img1 = aplicacao + "/imgs/" + jogador1.GetPersonagens[PAtivo1].GetNome + ".jpg";
            img2 = aplicacao + "/imgs/" + jogador2.GetPersonagens[PAtivo2].GetNome + ".jpg";
            pictureBox_Personagem1.ImageLocation = img1;
            pictureBox_Personagem2.ImageLocation = img2;
            //
            MaxMana1 = jogador1.GetPersonagens[PAtivo1].GetMana;
            MaxMana2 = jogador2.GetPersonagens[PAtivo2].GetMana;
            //
            label_nome1.Text = jogador1.GetNome;
            label_nome2.Text = jogador2.GetNome;
            label_Mana1.Text = jogador1.GetPersonagens[PAtivo1].ManaTotal.ToString();
            label_Mana2.Text = jogador2.GetPersonagens[PAtivo2].ManaTotal.ToString();
            label_Vida1.Text = jogador1.GetPersonagens[PAtivo1].VidaTotal.ToString();
            label_Vida2.Text = jogador2.GetPersonagens[PAtivo2].VidaTotal.ToString();
            label_Personagem1.Text = jogador1.GetPersonagens[PAtivo1].GetNome;
            label_Personagem2.Text = jogador2.GetPersonagens[PAtivo2].GetNome;
            //
            comboBox_Arma2.Enabled = false;
            button_TrocarArma2.Enabled = false;
            //
            comboBox_Magia2.Enabled = false;
            button_Magia2.Enabled = false;
            //
            progressBar_Vida1.Maximum = jogador1.GetPersonagens[PAtivo1].VidaTotal;
            progressBar_Vida2.Maximum = jogador2.GetPersonagens[PAtivo2].VidaTotal;
            progressBar_Vida1.Value = jogador1.GetPersonagens[PAtivo1].VidaTotal;
            progressBar_Vida2.Value = jogador2.GetPersonagens[PAtivo2].VidaTotal;
            progressBar_Mana1.Maximum = jogador1.GetPersonagens[PAtivo1].ManaTotal;
            progressBar_Mana2.Maximum = jogador2.GetPersonagens[PAtivo2].ManaTotal;
            progressBar_Mana1.Value = jogador1.GetPersonagens[PAtivo1].ManaTotal;
            progressBar_Mana2.Value = jogador2.GetPersonagens[PAtivo2].ManaTotal;
            //
            label_nome2.BringToFront();
            label_nome2.BackColor = Color.Transparent;
            //
            label_Vida1.Enabled = true;
            //
            for (int i = 0; i < jogador1.GetPersonagens[PAtivo1].GetArmas.Count; i++)
            {
                comboBox_Arma1.Items.Add(jogador1.GetPersonagens[PAtivo1].GetArmas[i].GetNome);
            }
            for (int i = 0; i < jogador2.GetPersonagens[PAtivo2].GetArmas.Count; i++)
            {
                comboBox_Arma2.Items.Add(jogador2.GetPersonagens[PAtivo2].GetArmas[i].GetNome);
            }
            comboBox_Arma1.SelectedIndex = ArmaAtiva1;
            comboBox_Arma2.SelectedIndex = ArmaAtiva2;
            //            

            for (int x = 0; x < jogador1.GetPersonagens[PAtivo1].GetMagias.Count; x++)
            {
                comboBox_Magia1.Items.Add(jogador1.GetPersonagens[PAtivo1].GetMagias[x].GetNome);
            }
            for (int x = 0; x < jogador2.GetPersonagens[PAtivo2].GetMagias.Count; x++)
            {
                comboBox_Magia2.Items.Add(jogador2.GetPersonagens[PAtivo2].GetMagias[x].GetNome);
            }
            TrocaVez();
            TrocaPersonagem();   //caso Carregar seja feito com algum personagem com vida = 0.   
        }
        //
        //Verificar se o combobox foi mudado antes de executar o metodo de ataque
        private void button_TrocarArma1_Click(object sender, EventArgs e)
        {
            TrocaArma();
        }
        //
        //Verificar se o combobox foi mudado antes de executar o metodo de ataque
        private void button_TrocarArma2_Click(object sender, EventArgs e)
        {
            TrocaArma();
        }
        //
        private void button_Ataque_Click(object sender, EventArgs e)
        {
            AtaqueFisico();
        }
        //
        //Verificar se O combobox está vazio ou se foi mudado antes de executar o metodo de ataque
        private void button_Magia1_Click(object sender, EventArgs e)
        {
            AtaqueMagico();
        }
        Form1 novo;

        private void button_Sair_Click(object sender, EventArgs e)
        {
            Player retornarjogador1 = new Player(jogador1.GetNome);
            retornarjogador1.GetVitorias = jogador1.GetVitorias;
            Player retornarjogador2 = new Player(jogador2.GetNome);
            retornarjogador2.GetVitorias = jogador1.GetVitorias;
            this.Hide();
            novo = new Form_TelaInicial();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            //save

            Save data = new Save();
            jogador1.armaativa = ArmaAtiva1;
            jogador2.armaativa = ArmaAtiva2;
            jogador1.Pativo = PAtivo1;
            jogador2.Pativo = PAtivo2;
            jogador1.magia = Magia1;
            jogador2.magia = Magia2;
            jogador1.maxmana = MaxMana1;
            jogador2.maxmana = MaxMana2;
            jogador1.Ativo = Ativo;
            data.PlayerSave.Add(jogador1);
            data.PlayerSave.Add(jogador2);
            this.Hide();
            novo = new Form_Salvar(data);
            novo.Closed += (s, args) => this.Close();
            novo.Show();

            //save
        }

        //Verificar se O combobox está vazio ou se foi mudado antes de executar o metodo de ataque
        private void button_Magia2_Click(object sender, EventArgs e)
        {
            AtaqueMagico();
        }

        //
        public void AtaqueFisico()
        {
            if (Ativo == true)
            {
                //Jogador 2 Recebe ataque fisico
                if (jogador1.GetPersonagens[PAtivo1].GetMana + 10 < MaxMana1)
                { jogador1.GetPersonagens[PAtivo1].GetMana += 10; }
                else
                //
                { jogador1.GetPersonagens[PAtivo1].GetMana = MaxMana1; }
                if ((jogador2.GetPersonagens[PAtivo2].GetVida - (jogador1.GetPersonagens[PAtivo1].GetArmas[ArmaAtiva1].GetDano + jogador1.GetPersonagens[PAtivo1].ForçaFisica)) > 0)
                {
                    jogador2.GetPersonagens[PAtivo2].AtaqueF(jogador1.GetPersonagens[PAtivo1].GetArmas[ArmaAtiva1].GetDano + jogador1.GetPersonagens[PAtivo1].ForçaFisica);
                    TrocaVez();
                }
                //
                else
                {
                    jogador2.GetPersonagens[PAtivo2].GetVida = 0;
                    progressBar_Vida2.Value = jogador2.GetPersonagens[PAtivo2].GetVida;
                    label_Vida2.Text = jogador2.GetPersonagens[PAtivo2].GetVida.ToString();
                    MessageBox.Show("O " + jogador2.GetPersonagens[PAtivo2].GetNome + " Morreu");
                    TrocaPersonagem();
                }
            }
            //
            else
            {
                //Jogador 1 Recebe ataque fisico
                if (jogador2.GetPersonagens[PAtivo2].GetMana + 10 < MaxMana2)
                { jogador2.GetPersonagens[PAtivo2].GetMana += 10; }
                else
                { jogador2.GetPersonagens[PAtivo2].GetMana = MaxMana2; }
                if ((jogador1.GetPersonagens[PAtivo1].GetVida - (jogador2.GetPersonagens[PAtivo2].GetArmas[ArmaAtiva2].GetDano + jogador2.GetPersonagens[PAtivo2].ForçaFisica)) > 0)
                {
                    jogador1.GetPersonagens[PAtivo1].AtaqueF(jogador2.GetPersonagens[PAtivo2].GetArmas[ArmaAtiva2].GetDano + jogador2.GetPersonagens[PAtivo2].ForçaFisica);
                    TrocaVez();
                }
                else
                {
                    jogador1.GetPersonagens[PAtivo1].GetVida = 0;
                    progressBar_Vida1.Value = jogador1.GetPersonagens[PAtivo1].GetVida;
                    label_Vida1.Text = jogador1.GetPersonagens[PAtivo1].GetVida.ToString();
                    MessageBox.Show("O " + jogador1.GetPersonagens[PAtivo1].GetNome + " Morreu");
                    TrocaPersonagem();
                }

            }
        }
        public void AtaqueMagico()
        { //MAGIA NEGRA NAO MEXER
            if (Ativo == true)
            {
                Magia1 = comboBox_Magia1.SelectedIndex;
                if (jogador1.GetPersonagens[PAtivo1].GetMana >= jogador1.GetPersonagens[PAtivo1].GetMagias[Magia1].GetCusto)
                {
                    if (jogador1.GetPersonagens[PAtivo1].GetMagias[Magia1].GetCura == true)// ...função cura
                    {
                        jogador1.GetPersonagens[PAtivo1].GetVida += jogador1.GetPersonagens[PAtivo1].GetMagias[Magia1].GetDano;
                        progressBar_Vida1.Value = jogador1.GetPersonagens[PAtivo1].GetVida;
                        label_Vida1.Text = jogador1.GetPersonagens[PAtivo1].GetVida.ToString();
                        TrocaVez();
                    }
                    else
                    {
                        jogador1.GetPersonagens[PAtivo1].GetMana -= jogador1.GetPersonagens[PAtivo1].GetMagias[Magia1].GetCusto;
                        if ((jogador2.GetPersonagens[PAtivo2].GetVida - (jogador1.GetPersonagens[PAtivo1].GetMagias[Magia1].GetDano + jogador1.GetPersonagens[PAtivo1].ForçaMagica)) > 0)
                        {
                            jogador2.GetPersonagens[PAtivo2].AtaqueM(jogador1.GetPersonagens[PAtivo1].GetMagias[Magia1].GetDano +
                            jogador1.GetPersonagens[PAtivo1].ForçaMagica);
                            TrocaVez();
                        }
                        else
                        {
                            jogador2.GetPersonagens[PAtivo2].GetVida = 0;
                            progressBar_Vida2.Value = 0;
                            MessageBox.Show("O " + jogador2.GetPersonagens[PAtivo2].GetNome + "Morreu");
                            TrocaPersonagem();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sem mana");
                }
            }
            else
            {
                Magia2 = comboBox_Magia2.SelectedIndex;
                if (jogador2.GetPersonagens[PAtivo2].GetMana >= jogador2.GetPersonagens[PAtivo2].GetMagias[Magia2].GetCusto)
                {
                    if (jogador2.GetPersonagens[PAtivo2].GetMagias[Magia2].GetCura == true)// ...função cura
                    {
                        jogador2.GetPersonagens[PAtivo2].GetVida += jogador2.GetPersonagens[PAtivo2].GetMagias[Magia2].GetDano;
                        TrocaPersonagem();
                    }
                    else
                    {
                        jogador2.GetPersonagens[PAtivo2].GetMana -= jogador2.GetPersonagens[PAtivo2].GetMagias[Magia2].GetCusto;
                        if ((jogador1.GetPersonagens[PAtivo1].GetVida - (jogador2.GetPersonagens[PAtivo2].GetMagias[Magia2].GetDano + jogador2.GetPersonagens[PAtivo2].ForçaMagica)) > 0)
                        {
                            jogador1.GetPersonagens[PAtivo1].AtaqueM(jogador2.GetPersonagens[PAtivo2].GetMagias[Magia2].GetDano +
                            jogador2.GetPersonagens[PAtivo2].ForçaMagica);
                            TrocaVez();
                        }
                        else
                        {
                            jogador1.GetPersonagens[PAtivo1].GetVida = 0;
                            progressBar_Vida1.Value = 0;
                            MessageBox.Show("O " + jogador1.GetPersonagens[PAtivo1].GetNome + "Morreu");
                            TrocaPersonagem();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sem mana");
                }
            }
        }
        //
        public void TrocaVez()
        {
            if (Ativo == true)
            {
                label_TrocaVez.Text = "Vez do Jogador 2";
                //
                progressBar_Vida1.Value = jogador1.GetPersonagens[PAtivo1].GetVida;
                progressBar_Vida2.Value = jogador2.GetPersonagens[PAtivo2].GetVida;
                progressBar_Mana1.Value = jogador1.GetPersonagens[PAtivo1].GetMana;
                progressBar_Mana2.Value = jogador2.GetPersonagens[PAtivo2].GetMana;
                //
                label_Vida2.Text = jogador2.GetPersonagens[PAtivo2].GetVida.ToString();
                label_Mana1.Text = jogador1.GetPersonagens[PAtivo1].GetMana.ToString();
                //
                if (jogador2.GetPersonagens[PAtivo2].GetArmas.Count > 1)
                {
                    comboBox_Arma2.Enabled = true;
                    button_TrocarArma2.Enabled = true;
                }
                //                
                comboBox_Magia2.Enabled = true;
                button_Magia2.Enabled = true;
                //
                comboBox_Arma1.Enabled = false;
                button_TrocarArma1.Enabled = false;
                comboBox_Magia1.Enabled = false;
                button_Magia1.Enabled = false;
                //
                Ativo = false;
            }
            else
            {
                label_TrocaVez.Text = "Vez do Jogador 1";
                //
                progressBar_Vida1.Value = jogador1.GetPersonagens[PAtivo1].GetVida;
                progressBar_Vida2.Value = jogador2.GetPersonagens[PAtivo2].GetVida;
                progressBar_Mana1.Value = jogador1.GetPersonagens[PAtivo1].GetMana;
                progressBar_Mana2.Value = jogador2.GetPersonagens[PAtivo2].GetMana;
                //
                label_Vida1.Text = jogador1.GetPersonagens[PAtivo1].GetVida.ToString();
                label_Mana2.Text = jogador2.GetPersonagens[PAtivo2].GetMana.ToString();
                //
                if (jogador1.GetPersonagens[PAtivo1].GetArmas.Count > 1)
                {
                    comboBox_Arma1.Enabled = true;
                    button_TrocarArma1.Enabled = true;
                }
                comboBox_Magia1.Enabled = true;
                button_Magia1.Enabled = true;
                //
                comboBox_Arma2.Enabled = false;
                button_TrocarArma2.Enabled = false;
                comboBox_Magia2.Enabled = false;
                button_Magia2.Enabled = false;
                //
                Ativo = true;

            }
        }
        public void TrocaArma()
        {
            if (Ativo == true)
            {
                ArmaAtiva1 = comboBox_Arma1.SelectedIndex;
                TrocaVez();
            }
            else
            {
                ArmaAtiva2 = comboBox_Arma2.SelectedIndex;
                TrocaVez();
            }
        }
        public void TrocaPersonagem()
        {
            Venceu();
            if (jogador1.GetPersonagens[PAtivo1].GetVida == 0)
            {
                //Personagem 1 morreu
                comboBox_Personagens.Enabled = true;
                button_TrocaPersonagem.Enabled = true;
                comboBox_Personagens.Items.Clear();
                for (int i = PAtivo1; i < jogador1.GetNumeroPersonagens; i++)
                {
                    if (jogador1.GetPersonagens[i].GetVida > 0)
                        comboBox_Personagens.Items.Add(jogador1.GetPersonagens[i].GetNome);
                }
            }
            else if (jogador2.GetPersonagens[PAtivo2].GetVida == 0)
            {
                comboBox_Personagens.Enabled = true;
                button_TrocaPersonagem.Enabled = true;
                // personagem 2 morreu
                comboBox_Personagens.Items.Clear();
                for (int i = PAtivo2; i < jogador2.GetNumeroPersonagens; i++)
                {
                    if (jogador2.GetPersonagens[i].GetVida > 0)
                        comboBox_Personagens.Items.Add(jogador2.GetPersonagens[i].GetNome);
                }

            }
        }
        //edita arquivo ficha.txt trocando a linha do jogador vitorioso e a substituindo pela quantidade de vitorias
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
        //fim de edição

        //busca a linha no arquivo ficha.txt na qual o jogador está salvo.
        public int numLine(string fileName, string name)
        {
            int i = 0;
            if (File.Exists("ficha.txt"))
            {
                Stream leitura = File.Open("ficha.txt", FileMode.Open);
                StreamReader e2 = new StreamReader(leitura);


                string[] verifica = new string[2];
                while (e2.Peek() >= 0)
                {
                    verifica = e2.ReadLine().Split(':');
                    if (name == verifica[0])
                    {
                        e2.Close();
                        return i;
                    }
                    else if ((name != verifica[0]))
                    {
                        i++;
                    }
                }
                e2.Close();

            }
            return i;
        }


        public void Venceu()
        {
            int j1 = jogador1.GetNumeroPersonagens;
            int j2 = jogador2.GetNumeroPersonagens;
            int x = 0, line;
            string edit;
            string file = "ficha.txt";
            if (Ativo == true)
            {
                for (int i = 0; i < j2; i++)
                {

                    if (jogador2.GetPersonagens[i].GetVida == 0)
                    { x++; }
                }
                if (x == j2)
                {
                    jogador1.GetVitorias++;
                    MessageBox.Show("O jogador " + jogador2.GetNome + " Perdeu");
                    MessageBox.Show("" + jogador1.GetVitorias);
                    edit = (jogador1.GetNome + ":" + jogador1.GetVitorias + ":");
                    line = numLine(file, jogador1.GetNome);
                    lineChanger(edit, file, line);
                    //
                    comboBox_Arma1.Enabled = false;
                    button_TrocarArma1.Enabled = false;
                    comboBox_Magia1.Enabled = false;
                    button_Magia1.Enabled = false;
                    //
                    comboBox_Arma2.Enabled = false;
                    button_TrocarArma2.Enabled = false;
                    comboBox_Magia2.Enabled = false;
                    button_Magia2.Enabled = false;
                    //
                    button_Ataque.Enabled = false;
                    comboBox_Personagens.Enabled = false;
                    button_TrocaPersonagem.Enabled = false;
                    //
                    button_Sair.Enabled = true;
                    button_Salvar.Enabled = true;
                }
            }
            else
            {
                for (int i = 0; i < j1; i++)
                {

                    if (jogador1.GetPersonagens[i].GetVida == 0)
                    { x++; }
                }
                if (x == j1)
                {
                    jogador2.GetVitorias++;
                    MessageBox.Show("O jogador " + jogador1.GetNome + " Perdeu");
                    edit = (jogador2.GetNome + ":" + jogador2.GetVitorias + ":");
                    line = numLine(file, jogador2.GetNome);
                    lineChanger(edit, file, line);
                    this.Enabled = false;
                    button_Sair.Enabled = true;
                    button_Salvar.Enabled = true;
                }
            }
        }
        //
        private void button_TrocaPersonagem_Click(object sender, EventArgs e)
        {
            if (Ativo == false)
            {
                if (jogador1.GetNumeroPersonagens > PAtivo1)
                {
                    nome = comboBox_Personagens.SelectedItem.ToString();
                    MessageBox.Show(nome);
                    for (int i = 0; i < jogador1.GetPersonagens.Count; i++)
                    {
                        if (nome == jogador1.GetPersonagens[i].nome)
                        {
                            PAtivo1 = i;
                        }
                    }
                    //
                    //Personagem do jogador 1 morreu trocar personagem do jogador 1
                    img1 = aplicacao + "/imgs/" + jogador1.GetPersonagens[PAtivo1].GetNome + ".jpg";
                    pictureBox_Personagem1.ImageLocation = img1;
                    //
                    label_Mana1.Text = jogador1.GetPersonagens[PAtivo1].GetMana.ToString();
                    label_Personagem1.Text = jogador1.GetPersonagens[PAtivo1].GetNome;
                    //
                    progressBar_Vida1.Maximum = jogador1.GetPersonagens[PAtivo1].GetVida;
                    progressBar_Mana1.Maximum = jogador1.GetPersonagens[PAtivo1].GetMana;
                    MaxMana1 = jogador1.GetPersonagens[PAtivo1].GetMana;
                    //
                    comboBox_Arma1.Items.Clear();

                    if (jogador1.GetPersonagens[PAtivo1].GetArmas.Count <= 1)
                    {
                        comboBox_Arma1.Enabled = false;
                        comboBox_Arma1.Items.Add(jogador1.GetPersonagens[PAtivo1].GetArmas[0].GetNome);
                    }
                    else
                    {
                        for (int i = 0; i < jogador1.GetPersonagens[PAtivo1].GetArmas.Count; i++)
                        {
                            comboBox_Arma1.Items.Add(jogador1.GetPersonagens[PAtivo1].GetArmas[i].GetNome);
                        }
                    }
                    comboBox_Magia1.Items.Clear();
                    comboBox_Magia1.SelectedText = null;
                    for (int x = 0; x < jogador1.GetPersonagens[PAtivo1].GetMagias.Count; x++)
                    {
                        comboBox_Magia1.Items.Add(jogador1.GetPersonagens[PAtivo1].GetMagias[x].GetNome);
                    }
                    //
                    comboBox_Arma1.SelectedIndex = 0;
                    TrocaVez();
                    button_TrocaPersonagem.Enabled = false;
                }
            }
            else
            {
                if (jogador2.GetNumeroPersonagens > PAtivo2)
                {
                    nome = comboBox_Personagens.SelectedItem.ToString();
                    MessageBox.Show(nome);
                    for (int i = 0; i < jogador2.GetPersonagens.Count; i++)
                    {
                        if (nome == jogador2.GetPersonagens[i].nome)
                        {
                            PAtivo2 = i;
                        }
                    }
                    //
                    img2 = aplicacao + "/imgs/" + jogador2.GetPersonagens[PAtivo2].GetNome + ".jpg";
                    pictureBox_Personagem2.ImageLocation = img2;
                    //                
                    label_Mana2.Text = jogador2.GetPersonagens[PAtivo2].GetMana.ToString();
                    label_Personagem2.Text = jogador2.GetPersonagens[PAtivo2].GetNome;
                    //                
                    progressBar_Vida2.Maximum = jogador2.GetPersonagens[PAtivo2].GetVida;
                    progressBar_Mana2.Maximum = jogador2.GetPersonagens[PAtivo2].GetMana;
                    MaxMana2 = jogador2.GetPersonagens[PAtivo2].GetMana;
                    //
                    comboBox_Arma2.Items.Clear();

                    if (jogador2.GetPersonagens[PAtivo2].GetArmas.Count <= 1)
                    {
                        comboBox_Arma2.Enabled = false;
                        comboBox_Arma2.Items.Add(jogador2.GetPersonagens[PAtivo2].GetArmas[0].GetNome);
                    }
                    else
                    {
                        for (int i = 0; i < jogador2.GetPersonagens[PAtivo2].GetArmas.Count; i++)
                        {
                            comboBox_Arma2.Items.Add(jogador2.GetPersonagens[PAtivo2].GetArmas[i].GetNome);
                        }
                    }
                    comboBox_Magia2.Items.Clear();
                    comboBox_Magia1.SelectedText = null;
                    for (int x = 0; x < jogador2.GetPersonagens[PAtivo2].GetMagias.Count; x++)
                    {
                        comboBox_Magia2.Items.Add(jogador2.GetPersonagens[PAtivo2].GetMagias[x].GetNome);
                    }
                    //
                    comboBox_Personagens.Enabled = false;
                    comboBox_Arma2.SelectedIndex = 0;
                    TrocaVez();
                    button_TrocaPersonagem.Enabled = false;
                }
            }
        }
        //
    }
}