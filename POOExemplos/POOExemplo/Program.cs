using System;
using POOExemplo.src.Entities;

namespace POOExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe
            Heroi arus = new Heroi("Arus", "Guerreiro");
            Mago wedge = new Mago("Wedge", "Mago Negro"); 
            Inimigo kingMummy = new Inimigo("King Mummy", "Zombie");

            System.Console.WriteLine(arus.Atacar());  
            System.Console.WriteLine(kingMummy.Atacar());

            if(arus.ValorUltimoAtaque == kingMummy.ValorUltimoAtaque)
            {
                System.Console.WriteLine(" Empate, ambos deram dano de "+arus.ValorUltimoAtaque);
            }
            else if(arus.ValorUltimoAtaque > kingMummy.ValorUltimoAtaque)
            {
                kingMummy.ReceberDano(arus.ValorUltimoAtaque - kingMummy.ValorUltimoAtaque);
                System.Console.WriteLine(arus.Nome + " Venceu esse round");
            }
            else
            {
                arus.ReceberDano(kingMummy.ValorUltimoAtaque - arus.ValorUltimoAtaque);
                System.Console.WriteLine(kingMummy.Nome + " Venceu esse round");
            }
            
        }
    }
}