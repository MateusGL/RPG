using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2
{
    [Serializable]
    class Armas
    {
        string nome;
        int dano;
        public int GetDano
        {
            get
            {
                return dano;
            }
            set
            {
                this.dano = value;
            }
        }
        public string GetNome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }
        }
        public Armas(string nome, int dano)
        {
            this.nome = nome;
            this.dano = dano;
        }
    }
}
