using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex030
{
    // Exercício 30
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo
    // de triângulo será formado:
    // - EQUILÁTERO: todos os lados iguais
    // - ISÓSCELES: dois lados iguais
    // - ESCALENO: todos os lados diferentes
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do primeiro segmento de reta: ");
            double reta1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o tamanho do segundo segmento de reta: ");
            double reta2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o tamanho do teceiro segmento de reta: ");
            double reta3 = double.Parse(Console.ReadLine());
            if ((reta1 < reta2 + reta3) && (reta2 < reta1 + reta3) && (reta3 < reta2 + reta1))
            {
                Console.WriteLine("Os segmentos podem formar um triângulo!");
                if ((reta1 == reta2) && (reta1 == reta3))
                {
                    Console.WriteLine("É um triângulo equilátero!");
                }
                else if ((reta1 == reta2) || (reta2 == reta3) || (reta1 == reta3))
                {
                    Console.WriteLine("É um triângulo isósceles!");
                }
                else
                {
                    Console.WriteLine("É um triângulo escaleno!");
                }
            }
            else
            {
                Console.WriteLine("Os segmentos não podem formar um triângulo.");
            }
            Console.ReadLine();
        }
    }
}
