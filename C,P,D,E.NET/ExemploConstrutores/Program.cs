using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrando funcionamento dos construtores com herenca
            //O construtor da classe pessoa eh chamado primeiro e so dps eh chaamdo o construtor da classe aluno
            Aluno a1 = new Aluno("Gabriela", "Lima", "Jogos");

            //Provando que a propriedade do log2 eh a do log, sao o mesmo objeto
            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste Instancia";
            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            //Nao funciona, pois o construtor eh privado
            ////Log log = new Log();

            // Pessoa p = new Pessoa("Gabriela", "Lima");
            // p.Apresentar();

        }
    }
}