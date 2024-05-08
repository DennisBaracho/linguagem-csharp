using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex020
{
    // Exercício 20
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou ÍMPAR.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro, vou dizer se é par ou ímpar: ");
            int numero = int.Parse(Console.ReadLine());
            if(numero%2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é ímpar!");
            }
            Console.ReadLine();
        }
    }
}
