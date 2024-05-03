using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex016
{
    // Exercício 16
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um fumante.
    // Pergunte a quantidade de cigarros fumados por dias e quantos anos ele já fumou.
    // Considere que um fumante perde 10 min de vida a cada cigarro. Calcule 
    // quantos dias de vida um fumante perderá e exiba o total em dias
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos cigarros você fuma por dia? ");
            int cigarrosPorDia = int.Parse(Console.ReadLine());
            Console.Write("Há quantos anos você fuma? ");
            int anos = int.Parse(Console.ReadLine());
            int diasPerdidos = ((cigarrosPorDia * (365 * anos))*10)/1440;
            Console.Write("Você perdeu " + diasPerdidos + " dias de vida.");
            Console.ReadLine();
        }
    }
}
