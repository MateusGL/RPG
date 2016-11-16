namespace PRG2
{
    partial class Form_Selecao
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
            this.checkBox_Guerreiro = new System.Windows.Forms.CheckBox();
            this.checkBox_Paladino = new System.Windows.Forms.CheckBox();
            this.checkBox_Ladrao = new System.Windows.Forms.CheckBox();
            this.checkBox_Mago = new System.Windows.Forms.CheckBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Zumbi = new System.Windows.Forms.CheckBox();
            this.checkBox_Troll = new System.Windows.Forms.CheckBox();
            this.checkBox_Animal = new System.Windows.Forms.CheckBox();
            this.checkBox_Dragao = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_Guerreiro
            // 
            this.checkBox_Guerreiro.AutoSize = true;
            this.checkBox_Guerreiro.Location = new System.Drawing.Point(144, 138);
            this.checkBox_Guerreiro.Name = "checkBox_Guerreiro";
            this.checkBox_Guerreiro.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Guerreiro.TabIndex = 0;
            this.checkBox_Guerreiro.Text = "Guerreiro ";
            this.checkBox_Guerreiro.UseVisualStyleBackColor = true;
            // 
            // checkBox_Paladino
            // 
            this.checkBox_Paladino.AutoSize = true;
            this.checkBox_Paladino.Location = new System.Drawing.Point(144, 166);
            this.checkBox_Paladino.Name = "checkBox_Paladino";
            this.checkBox_Paladino.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Paladino.TabIndex = 1;
            this.checkBox_Paladino.Text = "Paladino";
            this.checkBox_Paladino.UseVisualStyleBackColor = true;
            // 
            // checkBox_Ladrao
            // 
            this.checkBox_Ladrao.AutoSize = true;
            this.checkBox_Ladrao.Location = new System.Drawing.Point(144, 195);
            this.checkBox_Ladrao.Name = "checkBox_Ladrao";
            this.checkBox_Ladrao.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Ladrao.TabIndex = 3;
            this.checkBox_Ladrao.Text = "Ladrao";
            this.checkBox_Ladrao.UseVisualStyleBackColor = true;
            // 
            // checkBox_Mago
            // 
            this.checkBox_Mago.AutoSize = true;
            this.checkBox_Mago.Location = new System.Drawing.Point(144, 223);
            this.checkBox_Mago.Name = "checkBox_Mago";
            this.checkBox_Mago.Size = new System.Drawing.Size(53, 17);
            this.checkBox_Mago.TabIndex = 4;
            this.checkBox_Mago.Text = "Mago";
            this.checkBox_Mago.UseVisualStyleBackColor = true;
            // 
            // button_Play
            // 
            this.button_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button_Play.Location = new System.Drawing.Point(308, 274);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(80, 30);
            this.button_Play.TabIndex = 5;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(239, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha Seus Personagens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.Location = new System.Drawing.Point(140, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Humanos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.Location = new System.Drawing.Point(502, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inumanos";
            // 
            // checkBox_Zumbi
            // 
            this.checkBox_Zumbi.AutoSize = true;
            this.checkBox_Zumbi.Location = new System.Drawing.Point(506, 223);
            this.checkBox_Zumbi.Name = "checkBox_Zumbi";
            this.checkBox_Zumbi.Size = new System.Drawing.Size(55, 17);
            this.checkBox_Zumbi.TabIndex = 11;
            this.checkBox_Zumbi.Text = "Zumbi";
            this.checkBox_Zumbi.UseVisualStyleBackColor = true;
            // 
            // checkBox_Troll
            // 
            this.checkBox_Troll.AutoSize = true;
            this.checkBox_Troll.Location = new System.Drawing.Point(506, 195);
            this.checkBox_Troll.Name = "checkBox_Troll";
            this.checkBox_Troll.Size = new System.Drawing.Size(46, 17);
            this.checkBox_Troll.TabIndex = 10;
            this.checkBox_Troll.Text = "Troll";
            this.checkBox_Troll.UseVisualStyleBackColor = true;
            // 
            // checkBox_Animal
            // 
            this.checkBox_Animal.AutoSize = true;
            this.checkBox_Animal.Location = new System.Drawing.Point(506, 166);
            this.checkBox_Animal.Name = "checkBox_Animal";
            this.checkBox_Animal.Size = new System.Drawing.Size(57, 17);
            this.checkBox_Animal.TabIndex = 9;
            this.checkBox_Animal.Text = "Animal";
            this.checkBox_Animal.UseVisualStyleBackColor = true;
            // 
            // checkBox_Dragao
            // 
            this.checkBox_Dragao.AutoSize = true;
            this.checkBox_Dragao.Location = new System.Drawing.Point(506, 138);
            this.checkBox_Dragao.Name = "checkBox_Dragao";
            this.checkBox_Dragao.Size = new System.Drawing.Size(61, 17);
            this.checkBox_Dragao.TabIndex = 8;
            this.checkBox_Dragao.Text = "Dragao";
            this.checkBox_Dragao.UseVisualStyleBackColor = true;
            // 
            // Form_Selecao
            // 
            this.AcceptButton = this.button_Play;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(723, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_Zumbi);
            this.Controls.Add(this.checkBox_Troll);
            this.Controls.Add(this.checkBox_Animal);
            this.Controls.Add(this.checkBox_Dragao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.checkBox_Mago);
            this.Controls.Add(this.checkBox_Ladrao);
            this.Controls.Add(this.checkBox_Paladino);
            this.Controls.Add(this.checkBox_Guerreiro);
            this.Name = "Form_Selecao";
            this.Text = "Seleção de Personagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Guerreiro;
        private System.Windows.Forms.CheckBox checkBox_Paladino;
        private System.Windows.Forms.CheckBox checkBox_Ladrao;
        private System.Windows.Forms.CheckBox checkBox_Mago;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Zumbi;
        private System.Windows.Forms.CheckBox checkBox_Troll;
        private System.Windows.Forms.CheckBox checkBox_Animal;
        private System.Windows.Forms.CheckBox checkBox_Dragao;
    }
}
