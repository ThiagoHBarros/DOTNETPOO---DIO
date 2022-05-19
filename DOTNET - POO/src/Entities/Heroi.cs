 namespace DOTNET___POO.src.Entities
{
    public abstract class Heroi
    {
        public Heroi(string Nome, int Level, string tipoHeroi)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.tipoHeroi = tipoHeroi;
        }

        public Heroi()
        {
                
        }
        public string Nome { get; set; }
        public int Level { get; set; }
        public string tipoHeroi { get; set; }

        public override string ToString(){
            return this.Nome+ " " + this.Level + " " + this.tipoHeroi;

        }

        public virtual string Ataque()
        {
            return this.Nome + " Atacou com a sua espada";
        }

    }
}
