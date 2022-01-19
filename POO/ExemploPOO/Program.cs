using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora cal = new Calculadora();
            System.Console.WriteLine(cal.Somar(10,30));

            // //Mostrando class object
            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // //Mostrando classe e metodos abstratos
            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

        //     Calculadora calc = new Calculadora();
        //     System.Console.WriteLine("Resultado da primeira soma:"+ calc.Somar(2,2));
        //     System.Console.WriteLine("Resultado da segunda soma:" + calc.Somar(2,2,2));
   
        //    //Mostrando heranca
        //     Aluno a1 = new Aluno();
        //     a1.Nome = "Bob";
        //     a1.Idade = 20;
        //     a1.Nota = 9;
        //     a1.Apresentar();

        //     //Mostrando heranca
        //     Professor pr1 = new Professor();
        //     pr1.Nome = "Rob";
        //     pr1.Idade = 35;
        //     pr1.Salario = 10000;
        //     pr1.Apresentar();

        //     //Mostrando diferencas nos niveis de protecao. private e public
        //     // //valores validos
        //     Retangulo r  =  new Retangulo();
        //     r.DefinirMedidas(30,30);
        //     System.Console.WriteLine($"Area: {r.ObterArea()}");

        //     // //valores invalidos
        //     Retangulo r2  =  new Retangulo();
        //     r.DefinirMedidas(0,0);
        //     System.Console.WriteLine($"Area: {r2.ObterArea()}");

        //     //Criando classe
        //     Pessoa p1 = new Pessoa();
        //     p1.Nome = "Bob";
        //     p1.Idade = 20;
        //     p1.Apresentar();
        }
    }
}