using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2
{
    class Inumanos : Personagem
    {
        public Inumanos(string nome, int vida, int mana, int ForçaFisica, int ForçaMagica, int ResistenciaFisica, int ResistenciaMagica, int Agilidade, Armas Arsenal)
        {
            this.nome = nome;
            this.vida = vida;
            this.Mana = mana;
            this.ForçaFisica = ForçaFisica;
            this.ForçaMagica = ForçaMagica;
            this.ResistenciaFisica = ResistenciaFisica;
            this.ResistenciaMagica = ResistenciaMagica;
            this.Agilidade = Agilidade;

            GetArmas.Add(Arsenal);

        }
        public Inumanos(string nome, int vida, int mana, int ForçaFisica, int ForçaMagica, int ResistenciaFisica, int ResistenciaMagica, int Agilidade, Armas Arsenal, Armas Arsenal2)
        {
            this.nome = nome;
            this.vida = vida;
            this.Mana = mana;
            this.ForçaFisica = ForçaFisica;
            this.ForçaMagica = ForçaMagica;
            this.ResistenciaFisica = ResistenciaFisica;
            this.ResistenciaMagica = ResistenciaMagica;
            this.Agilidade = Agilidade;

            GetArmas.Add(Arsenal);
            GetArmas.Add(Arsenal2);
        }
        public Inumanos(string nome, int vida, int mana, int ForçaFisica, int ForçaMagica, int ResistenciaFisica, int ResistenciaMagica, int Agilidade, Armas Arsenal, Armas Arsenal2, Armas Arsenal3)
        {
            this.nome = nome;
            this.vida = vida;
            this.Mana = mana;
            this.ForçaFisica = ForçaFisica;
            this.ForçaMagica = ForçaMagica;
            this.ResistenciaFisica = ResistenciaFisica;
            this.ResistenciaMagica = ResistenciaMagica;
            this.Agilidade = Agilidade;

            GetArmas.Add(Arsenal);
            GetArmas.Add(Arsenal2);
            GetArmas.Add(Arsenal3);
        }
        public Inumanos(string nome, int vida, int mana, int ForçaFisica, int ForçaMagica, int ResistenciaFisica, int ResistenciaMagica, int Agilidade, Armas Arsenal, Armas Arsenal2, Armas Arsenal3, Armas Arsenal4)
        {
            this.nome = nome;
            this.vida = vida;
            this.Mana = mana;
            this.ForçaFisica = ForçaFisica;
            this.ForçaMagica = ForçaMagica;
            this.ResistenciaFisica = ResistenciaFisica;
            this.ResistenciaMagica = ResistenciaMagica;
            this.Agilidade = Agilidade;


            GetArmas.Add(Arsenal);
            GetArmas.Add(Arsenal2);
            GetArmas.Add(Arsenal3);
            GetArmas.Add(Arsenal4);
        }
        public void AddMagia(Classes.Magias Magia)
        {
            GetMagias.Add(Magia);
        }
    }
}
