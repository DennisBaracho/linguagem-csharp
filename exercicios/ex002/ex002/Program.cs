using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex002
{
     /* 2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela:
     Ex:
     Qual é o seu nome? João da Silva
     Olá João da Silva, é um prazer te conhecer! */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome + ", é um prazer te conhecer!");
            Console.ReadLine();
        }
    }
}
