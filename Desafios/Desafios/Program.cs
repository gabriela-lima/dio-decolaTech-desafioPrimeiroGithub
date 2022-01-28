
//Desafio quadrado dos pares
// using System; 

// class DIO {

//     static void Main(string[] args) { 

//       int n = int.Parse(Console.ReadLine());
//             for(int i = 1; i <= n; i++)
//             {
//               if(i % 2 == 0)
//               {
//                 int b = i * i;
//                 Console.WriteLine($"{i}^2 = {b}");
//               }
//             }
//     }

// }


//Desafio sequencia S
// using System; 

// class DIO {

//     static void Main(string[] args) { 

//       double a, c, S= 0;
//             for (a = 1; a <= 100; a++)
//             {
//                 c = 1/a;  //coloque a sua lógica nos espaços em branco
//                 S += c;
//             }
//             var x = Math.Round(S,2);
//             Console.WriteLine(x);

//     }

// }


//Desafio Sucessor par
// using System; 

// class DIO {

//     static void Main(string[] args) { 

//     int x = int.Parse(Console.ReadLine());
//       if(x % 2 == 0)
//       {
//         x = x + 2;
//       }
//       else
//       {
//         x++;
//       }
//       Console.WriteLine(x);
//     }

// }


//Desafio Sequencia IJ 2
// using System; 

// class DIO {

//     static void Main(string[] args) { 

//        for(int i = 1; i < 10; i += 2)
//             {
//                 for(int j = 7; j > 4; j--)    
//                 {
//                     Console.WriteLine($"I={i} J={j}");
//                 }
//             }
//     }

// }


//Desafio vai ter copa
// using System; 

// class DIO {

//     static void Main(string[] args) { 

//      string str;
//             while((str=Console.ReadLine())!= null)
//             {
              
//                     int x = int.Parse(str);
//                     if (x == 0)
//                     {
//                     Console.WriteLine("vai ter copa!"); 
//                     }
//                     else
//                     {
//                         Console.WriteLine("vai ter duas!");
//                     }
                
//             }

//     }

// }
 

using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            { 
                var esferas = int.Parse(Console.ReadLine());
                var esferaNova = esferas - Math.Floor(Math.Sqrt(esferas));
                Console.WriteLine(esferaNova);

            }
        }
    }
}


