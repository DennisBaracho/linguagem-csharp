using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex029
{
    // Exercício 29
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva um programa que leia o nome de um funcionário, seu salário,
    // quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de
    // acordo com a tabela a seguir:
    // - Até 3 anos de empresa: aumento de 3%
    // - entre 3 e 10 anos: aumento de 12.5%
    // - 10 anos ou mais: aumento de 20%
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Há quantos anos ele trabalha na empresa? ");
            int anos = int.Parse(Console.ReadLine());
            double novoSalario;
            if(anos < 3)
            {
                novoSalario = (salario * 103)/100;
            }
            else if((anos >= 3) && (anos < 10))
            {
                novoSalario = (salario * 112.5)/100; 
            }
            else
            {
                novoSalario = (salario * 120)/100;
            }
            Console.WriteLine("Novo salário: "+ novoSalario.ToString("C"));
            Console.ReadLine();

        }
    }
}
