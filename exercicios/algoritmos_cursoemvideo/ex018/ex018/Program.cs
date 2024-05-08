using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex018
{
    // Exercício 18
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade
    // dela e depois mostre se ela pode ou não votar.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu?");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            int idade = 2024 - anoDeNascimento;
            if (idade > 16)
            {
                Console.WriteLine("Você pode votar.");
            }
            else
            {
                Console.WriteLine("Você não pode votar.");
            }
            Console.ReadLine();
        }
    }
}
