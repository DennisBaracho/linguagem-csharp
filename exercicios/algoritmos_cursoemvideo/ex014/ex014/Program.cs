using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex014
{
    // Exercício 14
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva um programa que pergunte a qtd. de Km percorridos
    // por um carro alugado e a quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar,
    // sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Km foram percorridos pelo carro alugado? ");
            double kmPercorridos = double.Parse(Console.ReadLine());
            Console.Write("Por quantos dias o carro foi alugado? ");
            int diasAlugado = int.Parse(Console.ReadLine());
            double precoTotal = diasAlugado * 90 + kmPercorridos * 0.20;
            Console.WriteLine("O preço total a se pagar é: R$" + (Math.Round(precoTotal, 2)));
            Console.ReadLine();
        }
    }
}
