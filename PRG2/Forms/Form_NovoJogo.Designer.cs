namespace PRG2
{
    partial class Form_NovoJogo
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
            this.label3 = new System.Windows.Forms.Label();
            this.button_Play = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Jogador1 = new System.Windows.Forms.TextBox();
            this.textBox_Jogador2 = new System.Windows.Forms.TextBox();
            this.button_cadastroj1 = new System.Windows.Forms.Button();
            this.button_cadastroj2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(300, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Novo Jogo";
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(319, 245);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(75, 23);
            this.button_Play.TabIndex = 5;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jogador 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jogador2";
            // 
            // textBox_Jogador1
            // 
            this.textBox_Jogador1.Location = new System.Drawing.Point(184, 151);
            this.textBox_Jogador1.Name = "textBox_Jogador1";
            this.textBox_Jogador1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Jogador1.TabIndex = 1;
            this.textBox_Jogador1.TextChanged += new System.EventHandler(this.textBox_Jogador1_TextChanged);
            // 
            // textBox_Jogador2
            // 
            this.textBox_Jogador2.Location = new System.Drawing.Point(492, 151);
            this.textBox_Jogador2.Name = "textBox_Jogador2";
            this.textBox_Jogador2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Jogador2.TabIndex = 3;
            this.textBox_Jogador2.TextChanged += new System.EventHandler(this.textBox_Jogador2_TextChanged);
            // 
            // button_cadastroj1
            // 
            this.button_cadastroj1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cadastroj1.Location = new System.Drawing.Point(196, 191);
            this.button_cadastroj1.Name = "button_cadastroj1";
            this.button_cadastroj1.Size = new System.Drawing.Size(75, 23);
            this.button_cadastroj1.TabIndex = 2;
            this.button_cadastroj1.Text = "Cadastrar";
            this.button_cadastroj1.UseVisualStyleBackColor = true;
            this.button_cadastroj1.Click += new System.EventHandler(this.button_cadastroj1_Click);
            // 
            // button_cadastroj2
            // 
            this.button_cadastroj2.Location = new System.Drawing.Point(507, 191);
            this.button_cadastroj2.Name = "button_cadastroj2";
            this.button_cadastroj2.Size = new System.Drawing.Size(75, 23);
            this.button_cadastroj2.TabIndex = 4;
            this.button_cadastroj2.Text = "Cadastrar";
            this.button_cadastroj2.UseVisualStyleBackColor = true;
            this.button_cadastroj2.Click += new System.EventHandler(this.button_cadastroj2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tela Inicial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_NovoJogo
            // 
            this.AcceptButton = this.button_Play;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::PRG2.Properties.Resources._635981677272857326_143439568_18aq641a8axnnjpg;
            this.ClientSize = new System.Drawing.Size(723, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cadastroj2);
            this.Controls.Add(this.button_cadastroj1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Jogador1);
            this.Controls.Add(this.textBox_Jogador2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form_NovoJogo";
            this.Text = "Novo Jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Jogador1;
        private System.Windows.Forms.TextBox textBox_Jogador2;
        private System.Windows.Forms.Button button_cadastroj1;
        private System.Windows.Forms.Button button_cadastroj2;
        private System.Windows.Forms.Button button1;
    }
}
