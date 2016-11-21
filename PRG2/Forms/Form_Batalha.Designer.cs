namespace PRG2
{
    partial class Form_Batalha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Batalha));
            this.label_nome1 = new System.Windows.Forms.Label();
            this.label_nome2 = new System.Windows.Forms.Label();
            this.pictureBox_Personagem1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Personagem2 = new System.Windows.Forms.PictureBox();
            this.label_ArmaAtual = new System.Windows.Forms.Label();
            this.label_Personagem1 = new System.Windows.Forms.Label();
            this.comboBox_Arma2 = new System.Windows.Forms.ComboBox();
            this.button_Magia2 = new System.Windows.Forms.Button();
            this.button_TrocarArma1 = new System.Windows.Forms.Button();
            this.button_TrocaPersonagem = new System.Windows.Forms.Button();
            this.label_Vida1 = new System.Windows.Forms.Label();
            this.label_Vida2 = new System.Windows.Forms.Label();
            this.button_Ataque = new System.Windows.Forms.Button();
            this.comboBox_Arma1 = new System.Windows.Forms.ComboBox();
            this.label_Personagem2 = new System.Windows.Forms.Label();
            this.label_TrocaVez = new System.Windows.Forms.Label();
            this.button_TrocarArma2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_Vida1 = new System.Windows.Forms.ProgressBar();
            this.progressBar_Vida2 = new System.Windows.Forms.ProgressBar();
            this.progressBar_Mana1 = new System.Windows.Forms.ProgressBar();
            this.progressBar_Mana2 = new System.Windows.Forms.ProgressBar();
            this.comboBox_Magia2 = new System.Windows.Forms.ComboBox();
            this.button_Magia1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Mana2 = new System.Windows.Forms.Label();
            this.label_Mana1 = new System.Windows.Forms.Label();
            this.comboBox_Magia1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Personagens = new System.Windows.Forms.ComboBox();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Personagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Personagem2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nome1
            // 
            this.label_nome1.BackColor = System.Drawing.Color.Transparent;
            this.label_nome1.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome1.ForeColor = System.Drawing.Color.White;
            this.label_nome1.Location = new System.Drawing.Point(181, 1);
            this.label_nome1.Name = "label_nome1";
            this.label_nome1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_nome1.Size = new System.Drawing.Size(113, 18);
            this.label_nome1.TabIndex = 0;
            this.label_nome1.Text = "Jogador1";
            // 
            // label_nome2
            // 
            this.label_nome2.AutoSize = true;
            this.label_nome2.BackColor = System.Drawing.Color.Transparent;
            this.label_nome2.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome2.ForeColor = System.Drawing.Color.White;
            this.label_nome2.Location = new System.Drawing.Point(602, 1);
            this.label_nome2.Margin = new System.Windows.Forms.Padding(0);
            this.label_nome2.Name = "label_nome2";
            this.label_nome2.Size = new System.Drawing.Size(79, 23);
            this.label_nome2.TabIndex = 1;
            this.label_nome2.Text = "Jogador2";
            // 
            // pictureBox_Personagem1
            // 
            this.pictureBox_Personagem1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Personagem1.Image")));
            this.pictureBox_Personagem1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox_Personagem1.Name = "pictureBox_Personagem1";
            this.pictureBox_Personagem1.Size = new System.Drawing.Size(150, 90);
            this.pictureBox_Personagem1.TabIndex = 2;
            this.pictureBox_Personagem1.TabStop = false;
            // 
            // pictureBox_Personagem2
            // 
            this.pictureBox_Personagem2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Personagem2.Image")));
            this.pictureBox_Personagem2.Location = new System.Drawing.Point(730, 110);
            this.pictureBox_Personagem2.Name = "pictureBox_Personagem2";
            this.pictureBox_Personagem2.Size = new System.Drawing.Size(150, 90);
            this.pictureBox_Personagem2.TabIndex = 3;
            this.pictureBox_Personagem2.TabStop = false;
            // 
            // label_ArmaAtual
            // 
            this.label_ArmaAtual.AutoSize = true;
            this.label_ArmaAtual.BackColor = System.Drawing.Color.Transparent;
            this.label_ArmaAtual.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ArmaAtual.ForeColor = System.Drawing.Color.White;
            this.label_ArmaAtual.Location = new System.Drawing.Point(13, 237);
            this.label_ArmaAtual.Name = "label_ArmaAtual";
            this.label_ArmaAtual.Size = new System.Drawing.Size(37, 16);
            this.label_ArmaAtual.TabIndex = 4;
            this.label_ArmaAtual.Text = "Arma";
            // 
            // label_Personagem1
            // 
            this.label_Personagem1.AutoSize = true;
            this.label_Personagem1.BackColor = System.Drawing.Color.Transparent;
            this.label_Personagem1.Cursor = System.Windows.Forms.Cursors.No;
            this.label_Personagem1.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Personagem1.ForeColor = System.Drawing.Color.White;
            this.label_Personagem1.Location = new System.Drawing.Point(10, 203);
            this.label_Personagem1.Name = "label_Personagem1";
            this.label_Personagem1.Size = new System.Drawing.Size(72, 16);
            this.label_Personagem1.TabIndex = 5;
            this.label_Personagem1.Text = "Personagem";
            // 
            // comboBox_Arma2
            // 
            this.comboBox_Arma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Arma2.FormattingEnabled = true;
            this.comboBox_Arma2.Location = new System.Drawing.Point(698, 229);
            this.comboBox_Arma2.Name = "comboBox_Arma2";
            this.comboBox_Arma2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Arma2.TabIndex = 7;
            // 
            // button_Magia2
            // 
            this.button_Magia2.Location = new System.Drawing.Point(698, 323);
            this.button_Magia2.Name = "button_Magia2";
            this.button_Magia2.Size = new System.Drawing.Size(75, 23);
            this.button_Magia2.TabIndex = 8;
            this.button_Magia2.Text = "Magia";
            this.button_Magia2.UseVisualStyleBackColor = true;
            this.button_Magia2.Click += new System.EventHandler(this.button_Magia2_Click);
            // 
            // button_TrocarArma1
            // 
            this.button_TrocarArma1.Location = new System.Drawing.Point(62, 261);
            this.button_TrocarArma1.Name = "button_TrocarArma1";
            this.button_TrocarArma1.Size = new System.Drawing.Size(75, 23);
            this.button_TrocarArma1.TabIndex = 9;
            this.button_TrocarArma1.Text = "Trocar Arma";
            this.button_TrocarArma1.UseVisualStyleBackColor = true;
            this.button_TrocarArma1.Click += new System.EventHandler(this.button_TrocarArma1_Click);
            // 
            // button_TrocaPersonagem
            // 
            this.button_TrocaPersonagem.Enabled = false;
            this.button_TrocaPersonagem.Location = new System.Drawing.Point(384, 337);
            this.button_TrocaPersonagem.Name = "button_TrocaPersonagem";
            this.button_TrocaPersonagem.Size = new System.Drawing.Size(120, 23);
            this.button_TrocaPersonagem.TabIndex = 10;
            this.button_TrocaPersonagem.Text = "Trocar Personagem";
            this.button_TrocaPersonagem.UseVisualStyleBackColor = true;
            this.button_TrocaPersonagem.Click += new System.EventHandler(this.button_TrocaPersonagem_Click);
            // 
            // label_Vida1
            // 
            this.label_Vida1.AutoSize = true;
            this.label_Vida1.BackColor = System.Drawing.Color.Transparent;
            this.label_Vida1.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Vida1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label_Vida1.Location = new System.Drawing.Point(-1, 3);
            this.label_Vida1.Name = "label_Vida1";
            this.label_Vida1.Size = new System.Drawing.Size(39, 21);
            this.label_Vida1.TabIndex = 12;
            this.label_Vida1.Text = "vida";
            // 
            // label_Vida2
            // 
            this.label_Vida2.BackColor = System.Drawing.Color.Transparent;
            this.label_Vida2.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Vida2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label_Vida2.Location = new System.Drawing.Point(829, 3);
            this.label_Vida2.Name = "label_Vida2";
            this.label_Vida2.Size = new System.Drawing.Size(58, 18);
            this.label_Vida2.TabIndex = 14;
            this.label_Vida2.Text = "vida";
            this.label_Vida2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Ataque
            // 
            this.button_Ataque.Location = new System.Drawing.Point(407, 177);
            this.button_Ataque.Name = "button_Ataque";
            this.button_Ataque.Size = new System.Drawing.Size(75, 23);
            this.button_Ataque.TabIndex = 15;
            this.button_Ataque.Text = "Ataque";
            this.button_Ataque.UseVisualStyleBackColor = true;
            this.button_Ataque.Click += new System.EventHandler(this.button_Ataque_Click);
            // 
            // comboBox_Arma1
            // 
            this.comboBox_Arma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Arma1.FormattingEnabled = true;
            this.comboBox_Arma1.Location = new System.Drawing.Point(62, 234);
            this.comboBox_Arma1.Name = "comboBox_Arma1";
            this.comboBox_Arma1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Arma1.TabIndex = 16;
            // 
            // label_Personagem2
            // 
            this.label_Personagem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Personagem2.BackColor = System.Drawing.Color.Transparent;
            this.label_Personagem2.Cursor = System.Windows.Forms.Cursors.No;
            this.label_Personagem2.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Personagem2.ForeColor = System.Drawing.Color.White;
            this.label_Personagem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Personagem2.Location = new System.Drawing.Point(765, 203);
            this.label_Personagem2.Margin = new System.Windows.Forms.Padding(0);
            this.label_Personagem2.Name = "label_Personagem2";
            this.label_Personagem2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Personagem2.Size = new System.Drawing.Size(122, 13);
            this.label_Personagem2.TabIndex = 18;
            this.label_Personagem2.Text = "Personagem";
            this.label_Personagem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_TrocaVez
            // 
            this.label_TrocaVez.AutoSize = true;
            this.label_TrocaVez.BackColor = System.Drawing.Color.Transparent;
            this.label_TrocaVez.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TrocaVez.ForeColor = System.Drawing.Color.White;
            this.label_TrocaVez.Location = new System.Drawing.Point(383, 121);
            this.label_TrocaVez.Name = "label_TrocaVez";
            this.label_TrocaVez.Size = new System.Drawing.Size(123, 23);
            this.label_TrocaVez.TabIndex = 19;
            this.label_TrocaVez.Text = "Vez do jogador";
            // 
            // button_TrocarArma2
            // 
            this.button_TrocarArma2.Location = new System.Drawing.Point(698, 256);
            this.button_TrocarArma2.Name = "button_TrocarArma2";
            this.button_TrocarArma2.Size = new System.Drawing.Size(75, 23);
            this.button_TrocarArma2.TabIndex = 20;
            this.button_TrocarArma2.Text = "Trocar Arma";
            this.button_TrocarArma2.UseVisualStyleBackColor = true;
            this.button_TrocarArma2.Click += new System.EventHandler(this.button_TrocarArma2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(849, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Arma";
            // 
            // progressBar_Vida1
            // 
            this.progressBar_Vida1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar_Vida1.ForeColor = System.Drawing.Color.Red;
            this.progressBar_Vida1.Location = new System.Drawing.Point(2, 24);
            this.progressBar_Vida1.Maximum = 3000;
            this.progressBar_Vida1.Name = "progressBar_Vida1";
            this.progressBar_Vida1.Size = new System.Drawing.Size(286, 23);
            this.progressBar_Vida1.Step = 50;
            this.progressBar_Vida1.TabIndex = 11;
            this.progressBar_Vida1.Value = 3000;
            // 
            // progressBar_Vida2
            // 
            this.progressBar_Vida2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_Vida2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar_Vida2.ForeColor = System.Drawing.Color.Red;
            this.progressBar_Vida2.Location = new System.Drawing.Point(605, 24);
            this.progressBar_Vida2.Maximum = 3000;
            this.progressBar_Vida2.Name = "progressBar_Vida2";
            this.progressBar_Vida2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar_Vida2.RightToLeftLayout = true;
            this.progressBar_Vida2.Size = new System.Drawing.Size(286, 23);
            this.progressBar_Vida2.Step = 50;
            this.progressBar_Vida2.TabIndex = 13;
            this.progressBar_Vida2.Value = 3000;
            // 
            // progressBar_Mana1
            // 
            this.progressBar_Mana1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar_Mana1.ForeColor = System.Drawing.Color.Red;
            this.progressBar_Mana1.Location = new System.Drawing.Point(2, 53);
            this.progressBar_Mana1.Maximum = 3000;
            this.progressBar_Mana1.Name = "progressBar_Mana1";
            this.progressBar_Mana1.Size = new System.Drawing.Size(240, 23);
            this.progressBar_Mana1.Step = 50;
            this.progressBar_Mana1.TabIndex = 22;
            this.progressBar_Mana1.Value = 3000;
            // 
            // progressBar_Mana2
            // 
            this.progressBar_Mana2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_Mana2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar_Mana2.ForeColor = System.Drawing.Color.Red;
            this.progressBar_Mana2.Location = new System.Drawing.Point(651, 53);
            this.progressBar_Mana2.Maximum = 3000;
            this.progressBar_Mana2.Name = "progressBar_Mana2";
            this.progressBar_Mana2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar_Mana2.RightToLeftLayout = true;
            this.progressBar_Mana2.Size = new System.Drawing.Size(240, 23);
            this.progressBar_Mana2.Step = 50;
            this.progressBar_Mana2.TabIndex = 23;
            this.progressBar_Mana2.Value = 3000;
            // 
            // comboBox_Magia2
            // 
            this.comboBox_Magia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Magia2.FormattingEnabled = true;
            this.comboBox_Magia2.Location = new System.Drawing.Point(698, 296);
            this.comboBox_Magia2.Name = "comboBox_Magia2";
            this.comboBox_Magia2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Magia2.TabIndex = 24;
            // 
            // button_Magia1
            // 
            this.button_Magia1.Location = new System.Drawing.Point(61, 323);
            this.button_Magia1.Name = "button_Magia1";
            this.button_Magia1.Size = new System.Drawing.Size(75, 23);
            this.button_Magia1.TabIndex = 25;
            this.button_Magia1.Text = "Magia";
            this.button_Magia1.UseVisualStyleBackColor = true;
            this.button_Magia1.Click += new System.EventHandler(this.button_Magia1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(849, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Magia";
            // 
            // label_Mana2
            // 
            this.label_Mana2.BackColor = System.Drawing.Color.Transparent;
            this.label_Mana2.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mana2.ForeColor = System.Drawing.Color.Indigo;
            this.label_Mana2.Location = new System.Drawing.Point(832, 79);
            this.label_Mana2.Name = "label_Mana2";
            this.label_Mana2.Size = new System.Drawing.Size(55, 18);
            this.label_Mana2.TabIndex = 29;
            this.label_Mana2.Text = "Mana";
            this.label_Mana2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Mana1
            // 
            this.label_Mana1.AutoSize = true;
            this.label_Mana1.BackColor = System.Drawing.Color.Transparent;
            this.label_Mana1.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mana1.ForeColor = System.Drawing.Color.Indigo;
            this.label_Mana1.Location = new System.Drawing.Point(3, 79);
            this.label_Mana1.Name = "label_Mana1";
            this.label_Mana1.Size = new System.Drawing.Size(48, 21);
            this.label_Mana1.TabIndex = 30;
            this.label_Mana1.Text = "Mana";
            // 
            // comboBox_Magia1
            // 
            this.comboBox_Magia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Magia1.FormattingEnabled = true;
            this.comboBox_Magia1.Location = new System.Drawing.Point(61, 296);
            this.comboBox_Magia1.Name = "comboBox_Magia1";
            this.comboBox_Magia1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Magia1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Magia";
            // 
            // comboBox_Personagens
            // 
            this.comboBox_Personagens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personagens.Enabled = false;
            this.comboBox_Personagens.FormattingEnabled = true;
            this.comboBox_Personagens.Location = new System.Drawing.Point(384, 291);
            this.comboBox_Personagens.Name = "comboBox_Personagens";
            this.comboBox_Personagens.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Personagens.TabIndex = 33;
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(805, 423);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 35;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // button_Salvar
            // 
            this.button_Salvar.Location = new System.Drawing.Point(407, 423);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(75, 23);
            this.button_Salvar.TabIndex = 36;
            this.button_Salvar.Text = "Salvar";
            this.button_Salvar.UseVisualStyleBackColor = true;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // Form_Batalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::PRG2.Properties.Resources.fight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 458);
            this.Controls.Add(this.button_Salvar);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.comboBox_Personagens);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Magia1);
            this.Controls.Add(this.label_Mana1);
            this.Controls.Add(this.label_Mana2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Magia1);
            this.Controls.Add(this.comboBox_Magia2);
            this.Controls.Add(this.progressBar_Mana2);
            this.Controls.Add(this.progressBar_Mana1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_TrocarArma2);
            this.Controls.Add(this.label_TrocaVez);
            this.Controls.Add(this.label_Personagem2);
            this.Controls.Add(this.comboBox_Arma1);
            this.Controls.Add(this.button_Ataque);
            this.Controls.Add(this.label_Vida2);
            this.Controls.Add(this.progressBar_Vida2);
            this.Controls.Add(this.label_Vida1);
            this.Controls.Add(this.progressBar_Vida1);
            this.Controls.Add(this.button_TrocaPersonagem);
            this.Controls.Add(this.button_TrocarArma1);
            this.Controls.Add(this.button_Magia2);
            this.Controls.Add(this.comboBox_Arma2);
            this.Controls.Add(this.label_Personagem1);
            this.Controls.Add(this.label_ArmaAtual);
            this.Controls.Add(this.pictureBox_Personagem2);
            this.Controls.Add(this.pictureBox_Personagem1);
            this.Controls.Add(this.label_nome1);
            this.Controls.Add(this.label_nome2);
            this.Name = "Form_Batalha";
            this.Text = "Batalha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Personagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Personagem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome1;
        private System.Windows.Forms.Label label_nome2;
        private System.Windows.Forms.PictureBox pictureBox_Personagem1;
        private System.Windows.Forms.PictureBox pictureBox_Personagem2;
        private System.Windows.Forms.Label label_ArmaAtual;
        private System.Windows.Forms.Label label_Personagem1;
        private System.Windows.Forms.ComboBox comboBox_Arma2;
        private System.Windows.Forms.Button button_Magia2;
        private System.Windows.Forms.Button button_TrocarArma1;
        private System.Windows.Forms.Button button_TrocaPersonagem;
        private System.Windows.Forms.ProgressBar progressBar_Vida1;
        private System.Windows.Forms.Label label_Vida1;
        private System.Windows.Forms.ProgressBar progressBar_Vida2;
        private System.Windows.Forms.Label label_Vida2;
        private System.Windows.Forms.Button button_Ataque;
        private System.Windows.Forms.ComboBox comboBox_Arma1;
        private System.Windows.Forms.Label label_Personagem2;
        private System.Windows.Forms.Label label_TrocaVez;
        private System.Windows.Forms.Button button_TrocarArma2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_Mana2;
        private System.Windows.Forms.ProgressBar progressBar_Mana1;
        private System.Windows.Forms.ComboBox comboBox_Magia2;
        private System.Windows.Forms.Button button_Magia1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Mana2;
        private System.Windows.Forms.Label label_Mana1;
        private System.Windows.Forms.ComboBox comboBox_Magia1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Personagens;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button_Salvar;
    }
}
