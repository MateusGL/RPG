using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2
{
    class Player
    {
        string Nome;
        int i = 0, vitorias;
        List<Personagem> Personagens = new List<Personagem>();
        public int GetVitorias
        {
            get
            {
                return this.vitorias;
            }
            set
            {
                this.vitorias = value;
            }
        }
        public int GetNumeroPersonagens
        {
            get
            {
                return this.i;
            }
            set
            {
                i = value;
            }
        }
        public string GetNome
        {
            get
            {
                return this.Nome;
            }
            set
            {
                Nome = value;
            }
        }
        public List<Personagem> GetPersonagens
        {
            get
            {
                return this.Personagens;
            }
            set
            {
                this.Personagens = value;
            }
        }
        public Player(string nome)
        { 
            Nome = nome;
        }
        public void RecebePersonagem(Personagem novo)
        {
            Personagens.Add(novo);
            i++;
        }
    }
}
