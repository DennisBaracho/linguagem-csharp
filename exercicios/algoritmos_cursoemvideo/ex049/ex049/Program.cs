using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex049
{
    // Exercício 49
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Crie um programa que leia 6 números inteiros e no final mostre quantos deles 
    // são pares e quantos são ímpares.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int pares = 0;
            int impares = 0;
            while (i < 6)
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                if(numero %2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
                i++;
            }
            Console.WriteLine("Pares: " + pares);
            Console.Write("Impares: " + impares);
            Console.ReadLine();
        }
    }
}
