using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET___POO.src.Entities
{
    internal class Guerreiro: Heroi
    {
       public Guerreiro(string Nome, int Level, string tipoHeroi)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.tipoHeroi = tipoHeroi;
        }
    }
}
