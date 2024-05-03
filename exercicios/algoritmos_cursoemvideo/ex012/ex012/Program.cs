using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex012
{
    
    // Exercício 12
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Crie um programa que leia o preço de um produto, calcule e mostre o seu PREÇO PROMOCIONAL, com 5% de desconto.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            double precoPromocional = (preco * 95) / 100;
            Console.WriteLine("Preço promocional, com 5% de desconto: R$" + Math.Round(precoPromocional,2));
            Console.ReadLine();
        }
    }
}
