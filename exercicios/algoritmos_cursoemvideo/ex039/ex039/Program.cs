using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex039
{
    // Exercício 39
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um algoritmo que mostre na tela a seguinte contagem:
    // 10 9 8 7 6 5 4 3 Acabou!
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 10;
            while (contador >= 3)
            {
                Console.Write($"{ contador--} ");
                if(contador < 3)
                {
                    Console.WriteLine("Acabou!");
                }
            }
            Console.ReadLine();
        }
    }
}
