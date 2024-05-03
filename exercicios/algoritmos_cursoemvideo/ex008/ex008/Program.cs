using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex008
{
    // Exercício 8
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva um programa que leia uma distância em metros e mostre os valores relativos em outras medidas.
internal class Program
{
    static void Main(string[] args)
    {
            Console.Write("Digite uma distância em metros: ");
            float distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("A distância de " + distancia + "m corresponde a:");
            Console.WriteLine((distancia / 1000) + "Km");
            Console.WriteLine((distancia / 100) + "Hm");
            Console.WriteLine((distancia / 10) + "Dam");
            // Math.Round arredonda para evitar números longos demais
            Console.WriteLine(Math.Round((distancia / 0.1),4) + "dm");
            Console.WriteLine(Math.Round((distancia / 0.01),4) + "cm");
            Console.WriteLine(Math.Round((distancia / 0.001),4) + "mm");
            Console.ReadLine();
        }
}
}
