using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ex037
{
    // Exercício 37
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Uma empresa precisa reajustar o salário dos seus funcionários, dando um 
    // aumento de acordo com alguns fatores. Faça um programa que leia o salário atual,
    // o gênero do funcionário e há quantos anos esse funcionário trabalha na empresa. 
    // No final, mostre o seu novo salário, baseado na tabela a seguir:
    // - Mulheres
    // - menos de 15 anos de empresa: +5%
    // - de 15 até 20 anos de empresa: +12%
    // - mais de 20 anos de empresa: +23%
    // - Homens
    // - menos de 20 anos de empresa: +3%
    // - de 20 até 30 anos de empresa: +13%
    // - mais de 30 anos de empresa: +25%
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Digite seu gênero (M/F): ");
            char genero = char.Parse(Console.ReadLine());
            Console.Write("Há quantos anos trabalha na empresa? ");
            int anos = int.Parse(Console.ReadLine());
            double salarioReajustado;
            if (genero == 'F')
            {
                if (anos < 15)
                {
                    salarioReajustado = (salario * 105) / 100;
                }
                else if ((anos >= 15) && (anos < 20))
                {
                    salarioReajustado = (salario * 112) / 100;
                }
                else
                {
                    salarioReajustado = (salario * 123) / 100;
                }
            }
            else
            {
                if (anos < 20)
                {
                    salarioReajustado = (salario * 103) / 100;
                }
                else if ((anos >= 20) && (anos < 30))
                {
                    salarioReajustado = (salario * 113) / 100;
                }
                else
                {
                    salarioReajustado = (salario * 125) / 100;
                }
            }
            Console.WriteLine($"Este é seu novo salário: {salarioReajustado.ToString("C")}.");
            Console.ReadLine();
        }
    }
}
