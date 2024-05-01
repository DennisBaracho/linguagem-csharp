using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex011
{
    // Exercício 11
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva uma lógica que leia os valores de A, B e C de uma equação do segundo grau e mostre o valor de Delta.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double valorA = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            double valorB = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            double valorC = double.Parse(Console.ReadLine());
            // Delta = (b^2) - 4.a.c
            double delta = (valorB * valorB) -4*(valorA*valorC);
            Console.Write("Valor de delta: " + delta);
            Console.ReadLine();
        }
    }
}
