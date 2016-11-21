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
    partial class Form_Salvar : PRG2.Form1
    {
        Save save;
        Form1 novo;
        public Form_Salvar(Save dados)
        {
            InitializeComponent();
            save = dados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save
            if (File.Exists("playerinfo1.dat"))
            {
                var confirmResult = MessageBox.Show("Deseja subscrever esse slot?",
                                     "Save preenchido",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Create("playerinfo1.dat");
                    bf.Serialize(file, save);
                    file.Close();
                    MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
                }
            }
            else {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create("playerinfo1.dat");
                bf.Serialize(file, save);
                file.Close();
                MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //save
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save
            if (File.Exists("playerinfo2.dat"))
            {
                var confirmResult = MessageBox.Show("Deseja subscrever esse slot?",
                                     "Save preenchido",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Create("playerinfo2.dat");
                    bf.Serialize(file, save);
                    file.Close();
                    MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                }
            }
            else {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create("playerinfo2.dat");
                bf.Serialize(file, save);
                file.Close();
                MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //save
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save
            if (File.Exists("playerinfo3.dat"))
            {
                var confirmResult = MessageBox.Show("Deseja subscrever esse slot?",
                                     "Save preenchido",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Create("playerinfo3.dat");
                    bf.Serialize(file, save);
                    file.Close();
                    MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                }
            }
            else {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create("playerinfo3.dat");
                bf.Serialize(file, save);
                file.Close();
                MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //save
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //save
            if (File.Exists("playerinfo4.dat"))
            {
                var confirmResult = MessageBox.Show("Deseja subscrever esse slot?",
                                     "Save preenchido",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Create("playerinfo4.dat");
                    bf.Serialize(file, save);
                    file.Close();
                    MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                }
            }
            else {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create("playerinfo4.dat");
                bf.Serialize(file, save);
                file.Close();
                MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //save
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //save
            if (File.Exists("playerinfo5.dat"))
            {
                var confirmResult = MessageBox.Show("Deseja subscrever esse slot?",
                                     "Save preenchido",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Create("playerinfo5.dat");
                    bf.Serialize(file, save);
                    file.Close();
                    MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                }
            }
            else {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create("playerinfo5.dat");
                bf.Serialize(file, save);
                file.Close();
                MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //save
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //save
            if (File.Exists("playerinfo6.dat"))
            {
                var confirmResult = MessageBox.Show("Deseja subscrever esse slot?",
                                     "Save preenchido",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Create("playerinfo6.dat");
                    bf.Serialize(file, save);
                    file.Close();
                    MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                }
            }
            else {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create("playerinfo6.dat");
                bf.Serialize(file, save);
                file.Close();
                MessageBox.Show("Jogo Salvo com sucesso.", "Jogo Salvo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //save
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_TelaInicial();
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            novo = new Form_Batalha(save.PlayerSave[0], save.PlayerSave[1]);
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }
    }
}
