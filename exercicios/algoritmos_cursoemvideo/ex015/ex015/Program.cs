using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ex015
{
    // Exercício 15
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Crie um programa que leia o número de dias trabalhados em um mês e mostre o salário de um funcionário,
    // sabendo que ele trabalha 8 horas por dia e ganha R$25 por hora trabalhada
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de dias trabalhados no mês: ");
            int diasTrabalhados = int.Parse(Console.ReadLine());
            double salario = 8 * 25 * diasTrabalhados;
            Console.WriteLine("O salário é de: R$" + Math.Round(salario,2));
            Console.ReadLine();
        }
    }
}
