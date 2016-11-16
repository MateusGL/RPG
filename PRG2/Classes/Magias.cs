using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2.Classes
{
    class Magias
    {
        int dano, custo;
        string nome;
        bool Cura;
        public Magias(string nome1, int dano1, int custo1, bool Cura1)
        {
            dano = dano1;
            nome = nome1;
            custo = custo1;
            Cura = Cura1;
        }
        public bool GetCura
        {
            get
            {
                return this.Cura;
            }
            set
            {
                this.Cura = value;
            }
        }
        public int GetCusto
        {
            get
            {
                return this.custo;
            }
            set
            {
                this.custo = value;
            }
        }
        public int GetDano
        {
            get
            {
                return this.dano;
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
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

    }
}
