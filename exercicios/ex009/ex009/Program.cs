using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009
{
    // Exercício 9
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) e mostre quantos dólares ela pode comprar.
    // Considere US$1,00 = R$3,45.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos reais você tem na carteira?");
            double reais = double.Parse(Console.ReadLine());
            double dolares = reais/3.45;
            // Arredondamos para que o resultado seja escrito como a moeda, com 2 casas decimais
            Console.WriteLine("Você pode comprar U$" + Math.Round(dolares,2) + ".");
            Console.ReadLine();
        }
    }
}
