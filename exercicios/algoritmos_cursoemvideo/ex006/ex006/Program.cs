using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex006
{
    // Exercício 6
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O antecessor de " + num + " é " + (num - 1));
            Console.WriteLine("O sucessor de " + num + " é " + (num + 1));
            Console.ReadLine();
        }
    }
}
