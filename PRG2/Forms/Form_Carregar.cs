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
    public partial class Form_Carregar : PRG2.Form1
    {
        Form1 novo;
        public Form_Carregar()
        {
            InitializeComponent();
        }

        private void Button_TelaInicial(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_TelaInicial();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        private void Button_Slot1(object sender, EventArgs e)
        {
            if (File.Exists("playerinfo1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open("playerinfo1.dat", FileMode.Open);
                Save save = (Save)bf.Deserialize(file);
                file.Close();
                this.Hide();
                novo = new Form_Batalha(save.PlayerSave[0], save.PlayerSave[1]);
                novo.Closed += (s, args) => this.Close();
                novo.Show();
            }
            else
            {
                MessageBox.Show("Teste outro slot ou salve um novo jogo.", "Slot vazio",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button_Slot2(object sender, EventArgs e)
        {
            if (File.Exists("playerinfo2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open("playerinfo2.dat", FileMode.Open);
                Save save = (Save)bf.Deserialize(file);
                file.Close();
                this.Hide();
                novo = new Form_Batalha(save.PlayerSave[0], save.PlayerSave[1]);
                novo.Closed += (s, args) => this.Close();
                novo.Show();
            }
            else
            {
                MessageBox.Show("Teste outro slot ou salve um novo jogo.", "Slot vazio",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button_Slot3(object sender, EventArgs e)
        {
            if (File.Exists("playerinfo3.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open("playerinfo3.dat", FileMode.Open);
                Save save = (Save)bf.Deserialize(file);
                file.Close();
                this.Hide();
                novo = new Form_Batalha(save.PlayerSave[0], save.PlayerSave[1]);
                novo.Closed += (s, args) => this.Close();
                novo.Show();
            }
            else
            {
                MessageBox.Show("Teste outro slot ou salve um novo jogo.", "Slot vazio",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button_Slot4(object sender, EventArgs e)
        {
            if (File.Exists("playerinfo4.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open("playerinfo4.dat", FileMode.Open);
                Save save = (Save)bf.Deserialize(file);
                file.Close();
                this.Hide();
                novo = new Form_Batalha(save.PlayerSave[0], save.PlayerSave[1]);
                novo.Closed += (s, args) => this.Close();
                novo.Show();
            }
            else
            {
                MessageBox.Show("Teste outro slot ou salve um novo jogo.", "Slot vazio",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button_Slot5(object sender, EventArgs e)
        {
            if (File.Exists("playerinfo5.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open("playerinfo5.dat", FileMode.Open);
                Save save = (Save)bf.Deserialize(file);
                file.Close();
                this.Hide();
                novo = new Form_Batalha(save.PlayerSave[0], save.PlayerSave[1]);
                novo.Closed += (s, args) => this.Close();
                novo.Show();
            }
            else
            {
                MessageBox.Show("Teste outro slot ou salve um novo jogo.", "Slot vazio",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button_Slot6(object sender, EventArgs e)
        {
            if (File.Exists("playerinfo6.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open("playerinfo6.dat", FileMode.Open);
                Save save = (Save)bf.Deserialize(file);
                file.Close();
                this.Hide();
                novo = new Form_Batalha(save.PlayerSave[0], save.PlayerSave[1]);
                novo.Closed += (s, args) => this.Close();
                novo.Show();
            }
            else
            {
                MessageBox.Show("Teste outro slot ou salve um novo jogo.", "Slot vazio",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
