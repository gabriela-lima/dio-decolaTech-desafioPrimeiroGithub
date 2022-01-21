using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrando Array multi dimensional
            //Declarando e atribuindo valores ao array
            int[,] matriz = new int[4, 2]
            {      
                {8, 8}, 
                {10, 20},
                {50, 100},
                {90, 200}
            };
            //Declarando/manipulando o array multi dimensional diretamente
            //matriz[0, 0] = 5;

            //Percorrer Array Multi dimensional
            //usar dois for alinhados, um percorre as linhas e o outro as colunas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }

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