using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex004
{
    // Exercício 4
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o outro valor: ");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.Write("A soma entre " + num1 + " e " + num2 + " é igual a " + soma + ".");
            Console.ReadLine();
        }
    }
}
