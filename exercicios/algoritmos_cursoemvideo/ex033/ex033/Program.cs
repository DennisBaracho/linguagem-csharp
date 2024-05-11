using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex033
{
    // Exercício 33
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Escreva um programa para aprovar ou não o empréstimo bancário para a compra
    // de uma casa.O programa vai perguntar o valor da casa, o salário do comprador e
    // em quantos anos ele vai pagar.Calcule o valor da prestação mensal, sabendo que
    // ela não pode exceder 30% do salário ou então o empréstimo será negado.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o valor da casa? R$");
            double valorCasa = double.Parse(Console.ReadLine());
            Console.Write("Qual o seu salário? R$");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Em quantos anos você vai pagar? ");
            double anos = double.Parse(Console.ReadLine());
            double prestacao = valorCasa/(anos*12);
            Console.WriteLine("\nO preço da prestação mensal será de " + prestacao.ToString("C"));
            if(prestacao > (salario * 130 / 100))
            {
                Console.WriteLine("O empréstimo foi negado. pois a prestação mensal ultrapassa 30% do seu salário.");
            }
            else
            {
                Console.WriteLine("Empréstimo aprovado!");
            }
            Console.ReadLine();
        }
    }
}
