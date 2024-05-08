using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ex025
{
    // Exercício 25
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta.
    // Analise seus comprimentos e diga se é possível formar um triângulo com essas
    // retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento
    // de cada lado deve ser menor que a soma dos outros dois.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do primeiro segmento de reta: ");
            double reta1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do segundo segmento de reta: ");
            double reta2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do teceiro segmento de reta: ");
            double reta3 = double.Parse(Console.ReadLine());
            if((reta1 < reta2 + reta3) && (reta2 < reta1 + reta3) && (reta3 < reta2 + reta1))
            {
                Console.WriteLine("Os segmentos podem formar um triângulo!");
            }
            else
            {
                Console.WriteLine("Os segmentos não podem formar um triângulo.");
            }
            Console.ReadLine();
        }
    }
}
