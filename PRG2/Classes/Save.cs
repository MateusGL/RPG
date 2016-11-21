using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2
{
    [Serializable]
    class Save
    {
        List<Player> jogador = new List<Player>();        
        public List<Player> PlayerSave
        {
            get
            {
                return this.jogador;
            }
            set
            {
                this.jogador = value;
            }
        }
        public void RecebePersonagem(Player novo)
        {
            jogador.Add(novo);           
        }


    }
}
