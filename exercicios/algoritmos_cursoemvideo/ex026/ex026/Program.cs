using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex026
{
    // Exercício 26
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando
    // na tela uma das mensagens abaixo:
    // - O primeiro valor é o maior
    // - O segundo valor é o maior
    // - Não existe valor maior, os dois são iguais
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            if(n1 > n2)
            {
                Console.WriteLine("O primeiro valor é maior");
            }
            else if(n2 > n1)
            {
                Console.WriteLine("O segundo valor é maior");
            }
            else
            {
                Console.WriteLine("Não existe valor maior, os dois são iguais.");
            }
            Console.ReadLine();
        }
    }
}
