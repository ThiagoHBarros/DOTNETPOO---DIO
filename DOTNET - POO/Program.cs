using DOTNET___POO.src.Entities;
using System;


namespace dotnetpoo
{

    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro heroi = new Guerreiro("Arus", 29, "Guerreiro");
            Mago oponente = new Mago("Maleficus", 23, "Mago");

            Console.WriteLine(oponente.Ataque(1));
            Console.WriteLine(heroi.Ataque());
           
        }
    }

}