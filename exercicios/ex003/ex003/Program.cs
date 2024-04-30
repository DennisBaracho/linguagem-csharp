using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex003
{
    /* 3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no
       final uma mensagem.
       Ex:
       Nome do Funcionário: Maria do Carmo
       Salário: 1850,45
       O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário:");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Nome do Funcionário: " + nome);
            Console.WriteLine("Salário: {0:C2} ", salario);
            Console.WriteLine("O funcionário " + nome + " tem um salário de {0:C2} em Junho.", salario);
            Console.ReadLine();
        }
    }
}
