namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        //Ref eh para passar a referencia da variavel, dessa forma o que for feito no metodo vai mudar a variavel do codigo em si
        public void OrdenarBubbleSort(ref int[] array)
        {
            //Serve para fazer a troca sem perder o valor anterior
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //-1 para que ele nao compare com uma posicao que nao existe
                for (int j = 0; j < array.Length - 1; j++)
                {
                    //se o proximo elemento for maior que o elemento atual
                    if(array[j] > array[j+1])
                    {
                        //temp vai receber o proximo elemento, o menor
                        temp = array[j+1];
                        //vai trocar o proximo pelo atual
                        array[j+1] = array[j];
                        //o array atual vai receber o valor de temp
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            //Eh possivel imprimir o array utilizando o for (pior, consome mais)
            // for (int i = 0; i < array.Length; i++)
            // {
            //     System.Console.WriteLine(array[i]);
            // }
            //ou dessa forma, colocando a juncao das linhas do array em uma variavel e imprimindo ela
            //imprime tudo em uma linha com os numeros separados por uma virgula e um espaco
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }

        //Metodo Sort que ja vem com os arrays em c# e serve para organizar os arrays
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        //Metodo Copy, ja vem com os arrays de c# e serve para copiar arrays
        //voce pode decidir se vai copiar todo o array ou apenas uma parte dele e acordo com o tamanho do array
        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        //Metodo Exists serve verifica se um numero existe em um array
        //caso ache o numero vai retornar verdadeiro, caso nao retorna falso
        public bool Existe(int[] array, int valor)
        {
            //eh possivel colocar outras expressoes, caso coloque elemento > valor ele vai informar se existe algum elemento maior que o valor que foi passado no array
            return Array.Exists(array, elemento => elemento == valor);
        }

        //Utiliza o metodo TrueForAll para verificar se TODOS os elementos do array seguem o que foi passado na expressao
        public bool TodosMaiorQue(int[] array, int valor)
        {
            //nesse caso, ele vai retornar true se TODOS os elementos do array forem maior que o valor passado
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        //Metodo Find retorna a primeira ocorrencia no array
        //procura de acordo com a expressao passada
        public int ObterValor(int[] array, int valor)
        {
            //no caso, vai procurar por elementos iguais ao valor que foi passado
            return Array.Find(array, element => element == valor);
        }

        //Metodo IndexOf para encontrar o indice de um valor procurado
        //sempre vai procurar por uma condicao de igualdade
        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        //Usa o metodo Resize para redimensionar o tamanho do array
        //o array eh passado como referencia pois ele deve ser modificado
        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        //Metodo ConvertAll converte o tipo de array para outro de acordo com a expressao
        //eh necessario uma expressao que informe como converter
        public string[] ConverterParaArrayString(int[] array)
        {
            //no caso aqui vai convertar para string, pois pela expressao os elementos do array devem ser convertido para string (metodo toString)
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

    }
}