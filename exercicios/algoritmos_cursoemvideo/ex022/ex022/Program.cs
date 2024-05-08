using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ex022
{
    // Exercício 22
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua
    // situação em relação ao alistamento militar.
    // - Se estiver antes dos 18 anos, mostre em quantos anos faltam para o alistamento.
    // - Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do alistamento.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, rapaz. Em que ano você nasceu? ");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            int idade = 2024 - anoDeNascimento;
            if(idade > 18)
            {
                int anosDesdeAlistamento = idade - 18;
                Console.WriteLine("Já se passaram " + anosDesdeAlistamento + " anos.");
            }
            else
            {
                int anosParaAlistamento = 18 - idade;
                Console.WriteLine("Ainda faltam " + anosParaAlistamento + " anos.");
            }
            Console.ReadLine();
        }
    }
}
