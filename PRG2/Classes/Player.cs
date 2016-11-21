using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2
{
    [Serializable]
    class Player
    {
        string Nome;
        int i = 0, vitorias;
        int ArmaAtiva1 = 0,  PAtivo1 = 0,  Magia1,  MaxMana1;
        bool ativo = false;
        List<Personagem> Personagens = new List<Personagem>();

        public bool Ativo
        {
            get { return ativo; }
            set {
                if (value == true) ativo = false;
                else ativo = true;                
            }
        }

        public int armaativa
        {
            get { return ArmaAtiva1; }
            set { ArmaAtiva1 = value; }
        }

        
        public int Pativo
        {
            get { return PAtivo1; }
            set { PAtivo1 = value; }
        }

        

        public int magia
        {
            get { return Magia1; }
            set { Magia1 = value; }
        }

        

        public int maxmana
        {
            get { return MaxMana1; }
            set { MaxMana1 = value; }
        }

        

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
