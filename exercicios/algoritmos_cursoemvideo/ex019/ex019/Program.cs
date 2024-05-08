using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ex019
{
    // Exercício 19
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua
    // média e mostre na tela. No final, analise a média e mostre se o aluno teve ou
    // não um bom aproveitamento(se ficou acima da média 7.0).
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual foi sua primeira nota? ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("E a segunda? ");
            double nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2) / 2;
            Console.WriteLine("Sua média foi: " + media);
            if (media > 7.0)
            {
                Console.WriteLine("Você teve um bom apoveitamento!");
            }
            else
            {
                Console.WriteLine("Você não teve um bom aproveitamento.");
            }
            Console.ReadLine();
        }
    }
}
