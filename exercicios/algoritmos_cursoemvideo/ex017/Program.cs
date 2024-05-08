using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex017
{
    // Exercício 17
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: 17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse
    // 80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba
    // o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a velocidade do carro? ");
            double velocidade = double.Parse(Console.ReadLine());
            if (velocidade > 80)
            {
                double multa = 5 * (velocidade - 80);
                Console.WriteLine("Você foi multado! Valor da multa: R$"+multa+".");
            }
            else
            {
                Console.WriteLine("Pode passar.");
            }
            Console.ReadLine();
        }
    }
}
