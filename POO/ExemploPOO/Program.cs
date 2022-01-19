using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.IO;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            var caminho = "C:\\TrabalhandoComArquivos";
            FileHelper helper = new FileHelper();

            //Apagando diretorio
            var caminho2PathCombine = Path.Combine(caminho, "Pasta Teste 1");
            helper.ApagarDiretorio(caminho2PathCombine, true);

            //Criando diretorio
            //Com o Path Combine, bom para nao se importar com outros sistemas operacionais ja que voce nao precisa ficar trocando as barras
            //var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "Subpasta teste 3");
            // System.Console.WriteLine("Criando diretorio:" + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);

            // //Listando arquivos
            // helper.ListarArquivosDiretorios(caminho);
            
            // //Listando diretorios
            // helper.ListarDiretorios(caminho);

            // ICalculadora cal = new Calculadora();
            // System.Console.WriteLine(cal.Somar(10,30));

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