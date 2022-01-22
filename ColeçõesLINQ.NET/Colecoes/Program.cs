using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista(); 

            //Mostrando como declarar e acessar uma lista
            //Declaracao de lista
            //nao precisamos passar o tamanho da lista, nao precisamos nos preocupar em manipular o tamanho da lista
            List<string> estados = new List<string>();
            //Adicionando elementos a nossa lista
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");
            //Acessando elementos da lista
            //Metodo Count retorna a quantidade de elementos contidos na lista
            //System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            //Imprimindo os elementos de uma lista
            //Melhor usar o foreach se tratando de listas
            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }
            //mas tbm eh possivel utilizar o for, e ele sabe o indice do elemento
            //esse for foi colocado no ImprimirListaString na classe OperacoesLista
            // for (int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"Indice {i}, valor: {estados[i]}");
            // }
            opLista.ImprimirListaString(estados);

            //Remover um elemento da lista
            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");
            // opLista.ImprimirListaString(estados);

            //Mostrando como adicionar elementos de uma colecao a outra colecao sem perder os elementos originais
            //Nesse caso um eh array e o outro eh uma lista
            string[] estadosArray = new string[2] {"SC", "MT"};
            //metodo AddRange vai manter os elementos originais e adicionar os outros ao final da lista
            //estados.AddRange(estadosArray);
            //Metodo Insert se voce quiser adicionar um novo elemento em um indice especifico
            estados.Insert(1, "RJ");
            opLista.ImprimirListaString(estados);


            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // int valorProcurado = 9;

            //Mostrando como converter um array de tipo int para string
            //string[] arrayString = op.ConverterParaArrayString(array);

            //Mostrando a redimensao de um array
            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
            // op.RedimensionarArray(ref array, array.Length*2);
            // System.Console.WriteLine($"Capacidade atual do array apos redimensionar: {array.Length}");

            //Mostrando como achar o indice de um valor procurado no array
            // int indice = op.ObterIndice(array, valorProcurado);
            // if(indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} eh: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("O valor nao existe no array");
            // }

            //Mostrando como procurar um elemento em um array e retornar a primeira ocorrencia
            // int valorAchado = op.ObterValor(array, valorProcurado);
            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Nao encontrei o valor {0}", valorProcurado);
            // }

            //Mostrando como verificar se todos os elementos do array seguem uma expressao passada no metodo
            // bool todoMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            // if(todoMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores sao maior que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existem valores que nao sao maiores que {0}", valorProcurado);
            // }

            //Mostrando como verificar se um elemento existe no array com o metodo Exists
            // bool existe = op.Existe(array, valorProcurado);
            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o numero {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Nao encontrei o numero {0}", valorProcurado);
            // }

            //Mostrando como copiar um array
            // int[] arrayCopia = new int[10]; 
            // System.Console.WriteLine("Array antes da copia");
            // op.ImprimirArray(arrayCopia);
            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array depois da copia");
            // op.ImprimirArray(arrayCopia);

            //Mostrando o metodo Sort(metodo que ja vem com os arrays em c# e serve para organizar os arrays)
            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);
            // op.Ordenar(ref array);
            // System.Console.WriteLine("Array Ordenado");
            // op.ImprimirArray(array);

            // //Mostrando o algoritmo de ordenacao bubblesort
            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);
            // //Tem que passar como referencia pois o metodo pede
            // op.OrdenarBubbleSort(ref array);
            // System.Console.WriteLine("Array Ordenado");
            // op.ImprimirArray(array);
            

            //Mostrando Array multi dimensional
            //Declarando e atribuindo valores ao array
            // int[,] matriz = new int[4, 2]
            // {      
            //     {8, 8}, 
            //     {10, 20},
            //     {50, 100},
            //     {90, 200}
            // };
            //Declarando/manipulando o array multi dimensional diretamente
            //matriz[0, 0] = 5;

            //Percorrer Array Multi dimensional
            //usar dois for alinhados, um percorre as linhas e o outro as colunas
            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }

            //Mostrando Array
            //Declarando um array de tamanho 3
            //int[] arrayInteiros = new int[3];
            //Atribuindo/manipulando valores ao array diretamente
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            //int.Parse converte a string para inteiros, dessa forma eh possivel colocar no array ja que o parse retorna um inteiro
            //mas so funciona para string de numeros e nao de letras
            //arrayInteiros[2] = int.Parse("30");
            
            //Percorrer o array imprimindo cada elemento
            //eh possivel percorrer com o for
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }
            //ou com o foreach
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}