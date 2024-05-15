using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex038
{
    // Exercício 38
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Escreva um programa que mostre na tela a seguinte contagem: 
    // 6 7 8 9 10 11 Acabou
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 6;
            while (contador < 12)
            {
                Console.Write($"{contador++} ");
                if(contador == 12)
                {
                    Console.WriteLine("Acabou!");
                }
            }
            Console.ReadLine();
        }
    }
}
