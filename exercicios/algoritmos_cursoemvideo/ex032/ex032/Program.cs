using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex032
{
    // Exercício 32
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: [DESAFIO] Crie um jogo onde o computador vai sortear um número entre 1 e 5 o
    // jogador vai tentar descobrir qual foi o valor sorteado.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorteando...");

            Random numero = new Random();
            int numeroSorteado = numero.Next(1,6);
            Console.WriteLine("Tente descobrir o número que acaba de ser sorteado!");
            int palpite = int.Parse(Console.ReadLine());
            if(palpite == numeroSorteado)
            {
                Console.WriteLine("Você acertou! Parabéns!");
            }
            else
            {
                Console.WriteLine("Você errou.");
            }
            Console.ReadLine();
        }
    }
}
