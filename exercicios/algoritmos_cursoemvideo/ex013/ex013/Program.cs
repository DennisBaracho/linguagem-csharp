using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex013
{
    // Exercício 13
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o seu novo salário, com 15% de aumento
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu salário: ");
            double salarioAntigo = double.Parse(Console.ReadLine());
            double salarioNovo = (salarioAntigo * 115) / 100;
            Console.WriteLine("Esse é seu novo salário, com 15% de aumento: R$" + salarioNovo);
            Console.ReadLine();
        }
    }
}
