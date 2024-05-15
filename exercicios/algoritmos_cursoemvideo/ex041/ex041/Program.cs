using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex041
{
    // Exercício 41
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva um programa que mostre na tela a seguinte contagem:
    // 100 95 90 85 80 ... 0 Acabou!
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 100;
            while (contador > 0)
            {
                contador -= 5;
                Console.Write($"{contador} ");
                if (contador == 0)
                {
                    Console.Write("Acabou!");
                }
            }
            Console.ReadLine();
        }
    }
}
