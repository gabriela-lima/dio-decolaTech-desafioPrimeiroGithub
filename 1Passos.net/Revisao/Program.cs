using System;

namespace Revisao
{
    class Program
    {
        static void Main (string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcao();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    Console.WriteLine("Informe o nome do aluno:");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine("Informe a nota do aluno");
                    
                    //Parse vai retornar o decimal da string 
                    // Var pega o tipo da variavel automaticamente o que estiver sendo atribuido
                    //var nota = decimal.Parse(Console.ReadLine());
                    //Se o usuario digitar algo nao decimal vai dar erro
                    //aluno.Nota = decimal.Parse(Console.ReadLine());
                    //Uma forma eh usar o if try parse, nesse caso ele so vai transformar em decimal se ele conseguir
                    if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                        aluno.Nota = nota;
                    }
                    else
                    {
                        throw new ArgumentException("O valor da nota deve ser decimal");
                    }

                    alunos[indiceAluno] = aluno;
                    indiceAluno++;

                    break;
                    case "2":
                    foreach(var a in alunos)
                    {
                        if(!string.IsNullOrEmpty(a.Nome))
                        {
                            Console.WriteLine($"Aluno: {a.Nome} - Nota {a.Nota}");
                        }
                            
                    }

                    break;

                    case "3":
                        decimal notaTotal = 0;
                        var numAlunos = 0;
                        for(int i=0; i<alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numAlunos++;
                            }
                        } 

                        var mediaGeral = notaTotal/numAlunos;
                        Conceito conceitoGeral;

                         if(mediaGeral<= 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(mediaGeral <= 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if(mediaGeral <= 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(mediaGeral <= 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Media geral: {mediaGeral} - Conceito geral: {conceitoGeral}");

                       
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcao();
            }
        }

        private static string ObterOpcao()
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}