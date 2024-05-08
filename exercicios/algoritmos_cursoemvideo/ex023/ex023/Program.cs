using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex023
{
    // Exercício 23
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos
    // para todos, mas especialmente para mulheres. Faça um programa que leia nome,
    // sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo que:
    // - Homens ganham 5% de desconto
    // - Mulheres ganham 13% de desconto
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aproveite nossa promoção de Dia da Mulher! 13% de desconto para Mulheres e 5% de desconto para Homens.");
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é o seu sexo? Feminino ou Masculino? ");
            string sexo = Console.ReadLine();
            Console.Write("Qual o valor das suas compras? R$");
            double valorBruto = double.Parse(Console.ReadLine());
            double valorComDesconto;
            if (sexo == "Feminino")
            {
                valorComDesconto = (valorBruto * 87) / 100;
            }
            else
            {
                valorComDesconto = (valorBruto * 95) / 100;
            }
            Console.WriteLine("Esse é o novo valor das suas compras: "+valorComDesconto.ToString("C"));
            Console.ReadLine();
        }
    }
}
