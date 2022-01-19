using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            //o GetDirectories tem opcoes a mais de busca, o * para buscar todos os tipos de arquivos e as opcoes podem ser definidar para top(apenas as da raiz) ou all (pastas, subpastas e etc)
            //Caso nao coloque essa opcao ele vai realizar o padrao que eh procurar apenas top
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        } 

        public void ListarArquivosDiretorios(string caminho)
        {
            //O .txt eh para mostrar/pegar apenas arquivos txt com a numerao 2
            var retornoArquivos = Directory.GetFiles(caminho, "*2.txt", SearchOption.AllDirectories);
            foreach(var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            //Dessa forma apaga o diretorio apenas se ele estiver vazio
            //Directory.Delete(caminho);

            //Dessa forma ele apaga o diretorio e todos os arquivos dentro dele
            Directory.Delete(caminho, apagarArquivos);
        }
    }
}