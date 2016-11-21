using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2
{
    [Serializable]
    class Personagem
    {
        List<Armas> Arma = new List<Armas>();
        List<Classes.Magias> Magia = new List<Classes.Magias>();
        Save save = new Save();

        

        
        public List<Armas> GetArmas
        {
            get
            {
                return this.Arma;
            }
            set
            {
                this.Arma = value;
            }
        }
        public List<Classes.Magias> GetMagias
        {
            get
            {
                return this.Magia;
            }
            set
            {
                this.Magia = value;
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
                nome = value;
            }
        }
        public int GetVida
        {
            get
            {
                return this.vida;
            }
            set
            {
                vida = value;
            }
        }
        public int GetMana
        {
            get
            {
                return this.Mana;
            }
            set
            {
                this.Mana = value;
            }
        }

        public int VidaTotal
        {
            get
            {
                return vidatotal;
            }
            set
            {
                vidatotal = value;
            }
        }

        public int ManaTotal
        {
            get
            {
                return manatotal;
            }
            set
            {
                manatotal = value;
            }
        }

        public int vida;
        public int Mana;
        public int vidatotal;
        public int manatotal;
        public int ForçaFisica;
        public int ForçaMagica;
        public int ResistenciaFisica;
        public int ResistenciaMagica;
        public int Agilidade;
        public string nome;        
        public void AtaqueF(int Dano)
        {
           vida -= (Dano - ResistenciaFisica);
        }
        public void AtaqueM(int Dano)
        {
            vida -= (Dano - ResistenciaMagica);
        }
        public void AddMagia(Classes.Magias Magia)
        {
            GetMagias.Add(Magia);
        }
                

    }
}
