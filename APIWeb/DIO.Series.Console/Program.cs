using System;

namespace DIO.Series.Console
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluirSerie();
                        break;

                    case "5":
                        VisualizarSerie();
                        break;

                    case "6":
                        RestaurarSerie();
                        break;
                    case "C":
                        System.Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void ListarSeries()
        {
            System.Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                System.Console.WriteLine("Sem séries cadastradas.");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                System.Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }

        private static void InserirSerie()
        {
            ListarGeneros();
            System.Console.WriteLine("Por favor digite o gênero da série entre as opções acima: ");
            int entradaGenero = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite o titulo da série: ");
            string entradaTitulo = System.Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de incio da série: ");
            int entradaAno = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = System.Console.ReadLine();


            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie()
        {
            System.Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(System.Console.ReadLine());

            ListarGeneros();
            System.Console.WriteLine("Por favor digite o gênero da série entre as opções acima: ");
            int entradaGenero = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite o titulo da série: ");
            string entradaTitulo = System.Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de incio da série: ");
            int entradaAno = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = System.Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void ExcluirSerie()
        {
            System.Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Você tem certeza que deseja excluir a série?");
            System.Console.WriteLine("1- Sim");
            System.Console.WriteLine("2- Não");
            int respostaUsuario = int.Parse(System.Console.ReadLine());
            if (respostaUsuario == 1)
            {
                repositorio.Exclui(indiceSerie);
                System.Console.WriteLine("Série excluida");
            }
        }

        private static void VisualizarSerie()
        {
            System.Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(System.Console.ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);
            System.Console.WriteLine(serie);
        }

        private static void ListarGeneros()
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
        }

        private static void RestaurarSerie()
        {
            System.Console.WriteLine("Digite o ID da série a ser restaurada: ");
            int indiceSerie = int.Parse(System.Console.ReadLine());
            repositorio.Restaurar(indiceSerie);
            System.Console.WriteLine("Série restaurada");
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Jetflix a seu dispor!");
            System.Console.WriteLine("Por favor informe a opção desejada:");

            System.Console.WriteLine("1- Listar as séries");
            System.Console.WriteLine("2- Inserir nova série");
            System.Console.WriteLine("3- Atualizar série");
            System.Console.WriteLine("4- Excluir série");
            System.Console.WriteLine("5- Visualizar série");
            System.Console.WriteLine("6- Restaurar série");
            System.Console.WriteLine("C- Limpar a tela");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcaoUsuario = System.Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
