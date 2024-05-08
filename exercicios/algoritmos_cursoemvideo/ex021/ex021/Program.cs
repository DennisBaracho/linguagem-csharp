using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex021
{
    // Exercício 21
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um algoritmo que leia um determinado ano e mostre se ele é ou não BISSEXTO.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um ano, vou dizer se é bissexto ou não: ");
            int ano = int.Parse(Console.ReadLine());
            if(ano%4 == 0)
            {
                Console.WriteLine("O ano é bissexto!");
            }
            else
            {
                Console.WriteLine("O ano não é bissexto.");
            }
            Console.ReadLine();
        }
    }
}
