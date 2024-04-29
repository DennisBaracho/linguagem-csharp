using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Como armazenar mais de um valor em uma única variável?
            // Tipo do array, nome, tamanho do array (guarda até o limite)
            string[] produtos = new string[5] {"Batata", // 0
                "Pão", // 1
                "Maçã", // 2
                "Uva", // 3
                "Morango" // 4
            };
            int[] valores = { 40, 50, 60, 70, 20 }; // Maneira mais simples de criar um array, o C# identifica tamanho e tipo

            Console.WriteLine(produtos[1]); // Acessamos o produto pela sua posição

            produtos[1] = "Pão de batata";
            Console.WriteLine(produtos[1]); // Produto alterado

            Console.ReadLine();
        }
    }
}
