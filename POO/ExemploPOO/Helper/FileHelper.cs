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

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }   
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.CreateText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }  
            }
        }
        
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.AppendText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }  
            }
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach(var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }  

        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using(var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine())!= null)
                {
                    System.Console.WriteLine(linha);         
                }    
            }
        }  

        public void MoverArquivos(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

    }
}