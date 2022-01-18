using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma:"+ calc.Somar(2,2));
            System.Console.WriteLine("Resultado da segunda soma:" + calc.Somar(2,2,2));

            Aluno a1 = new Aluno();
            a1.Nome = "Bob";
            a1.Idade = 20;
            a1.Nota = 9;
            a1.Apresentar();

            Professor pr1 = new Professor();
            pr1.Nome = "Rob";
            pr1.Idade = 35;
            pr1.Salario = 10000;
            pr1.Apresentar();

            // //valores validos
            Retangulo r  =  new Retangulo();
            r.DefinirMedidas(30,30);
            System.Console.WriteLine($"Area: {r.ObterArea()}");

            // //valores invalidos
            Retangulo r2  =  new Retangulo();
            r.DefinirMedidas(0,0);
            System.Console.WriteLine($"Area: {r2.ObterArea()}");

            Pessoa p1 = new Pessoa();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar();
        }
    }
}