using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ex010
{
    // Exercício 10
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um algoritmo que leia a largura e altura de uma parede, calcule e mostre a área a ser pintada e a qtd. de tinta necessária,
    // Considere que cada litro de tinta pinta uma área de 2metros quadrados
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a largura da sua parede? ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Qual a altura da sua parede? ");
            double altura = double.Parse(Console.ReadLine());
            double area = largura * altura;
            double qtdDeTinta = area / 2;
            Console.WriteLine("Área a ser pintada: " + area + "metros quadrados.");
            Console.WriteLine("Quantidade de tinta necessária para o serviço: " + qtdDeTinta + "litros.");
            Console.ReadLine();
        }
    }
}
