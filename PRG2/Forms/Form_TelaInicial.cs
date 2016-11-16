using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRG2
{
    partial class Form_TelaInicial : PRG2.Form1
    {
        public Form_TelaInicial()
        {
            InitializeComponent();
            
        }
        Form1 novo;
        private void button1_Click(object sender, EventArgs e)
        {
            novo = new Form_NovoJogo();
            novo.Show();
        }
    }
}
