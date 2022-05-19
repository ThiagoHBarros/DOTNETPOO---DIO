using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET___POO.src.Entities
{
    public class Mago: Heroi
    {
        public Mago(string Nome, int Level, string tipoHeroi)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.tipoHeroi = tipoHeroi;
        }
        public override string Ataque()
        {
            return this.Nome + " lançou magia";
        }

        public string Ataque(int Bonus)
        {
            if(Bonus > 6)
            {
            return this.Nome + " lançou magia super efetiva com bonus de ataque de " + Bonus;
            }else
            {
                return this.Nome + " lançou uma magia com força fraca com bonus de " + Bonus;
            }

        }
    }
}
