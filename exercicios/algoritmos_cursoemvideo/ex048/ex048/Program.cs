using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex048
{
    // Exercício 48
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um programa que leia 7 números inteiros e no final mostre o somatório 
    // entre eles.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int soma = 0;
            while(i < 7)
            {
                Console.Write("Digite um numero inteiro: ");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
                i++;
            }
            Console.WriteLine("O resultado da soma foi: " + soma);
            Console.ReadLine();
        }
    }
}
