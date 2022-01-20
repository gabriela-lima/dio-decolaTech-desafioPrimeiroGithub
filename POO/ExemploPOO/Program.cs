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

            //Criando arquivo de texto Stream
            var caminhoArquivoStream = Path.Combine(caminho, "Arquivo_Teste_Stream.txt");
            var listaString = new List<string>{"Linha 1", "Linha 2", "Linha 3"};
            helper.CriarArquivoTextoStream(caminhoArquivoStream, listaString);

            
            
            //Mover arquivo
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "Arquivo_Teste_Stream");
            helper.MoverArquivos(caminhoArquivoStream, novoCaminhoArquivo, false);

            //Copiar arquivo
            var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo_Teste.txt");
            var caminhoArquivoCopia = Path.Combine(caminho, "Arquivo_Teste_Bkp.txt");
            helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoCopia, false);
            
            //Deletar arquivo
            helper.DeletarArquivo(caminhoArquivoCopia);

            //Ler arquivo Stream
            helper.LerArquivoStream(caminhoArquivoStream);

            //Adicionando novas linhas a um arquivo Stream
            var listaStringContinuacao = new List<string>{"Linha 4", "Linha 5", "Linha6"};
            helper.AdicionarTextoStream(caminhoArquivoStream, listaStringContinuacao);

            //Criando arquivo de texto WriteAllText
            var caminhoArquivo = Path.Combine(caminho, "Arquivo_Teste.txt");
            helper.CriarArquivoTexto(caminhoArquivo, "Teste de escrita de arquivo");

            //Apagando diretorio
            var caminho2PathCombine = Path.Combine(caminho, "Pasta Teste 1");
            helper.ApagarDiretorio(caminho2PathCombine, true);

            //Criando diretorio
            //Com o Path Combine, bom para nao se importar com outros sistemas operacionais ja que voce nao precisa ficar trocando as barras
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "Subpasta teste 3");
            System.Console.WriteLine("Criando diretorio:" + caminhoPathCombine);
            helper.CriarDiretorio(caminhoPathCombine);

            // //Listando arquivos
            helper.ListarArquivosDiretorios(caminho);
            
            // //Listando diretorios
            helper.ListarDiretorios(caminho);

            ICalculadora cal = new Calculadora();
            System.Console.WriteLine(cal.Somar(10,30));

            // //Mostrando class object
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());

            // //Mostrando classe e metodos abstratos
            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();

            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma:"+ calc.Somar(2,2));
            System.Console.WriteLine("Resultado da segunda soma:" + calc.Somar(2,2,2));
   
            //Mostrando heranca
            Aluno a1 = new Aluno();
            a1.Nome = "Bob";
            a1.Idade = 20;
            a1.Nota = 9;
            a1.Apresentar();

           //Mostrando heranca
            Professor pr1 = new Professor();
            pr1.Nome = "Rob";
            pr1.Idade = 35;
            pr1.Salario = 10000;
            pr1.Apresentar();

            //Mostrando diferencas nos niveis de protecao. private e public
            //valores validos
            Retangulo r  =  new Retangulo();
            r.DefinirMedidas(30,30);
            System.Console.WriteLine($"Area: {r.ObterArea()}");

            // //valores invalidos
            Retangulo r2  =  new Retangulo();
            r.DefinirMedidas(0,0);
            System.Console.WriteLine($"Area: {r2.ObterArea()}");

            //Criando classe
            Pessoa p1 = new Pessoa();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar();
        }
    }
}