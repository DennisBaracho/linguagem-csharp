using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex024
{
    // Exercício 24
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um algoritmo que pergunte a distância que um passageiro deseja
    // percorrer em Km.Calcule o preço da passagem, cobrando R$0.50 por Km para
    // viagens até 200Km e R$0.45 para viagens mais longas.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a distância que você deseja percorrer em Km? ");
            double distancia = double.Parse(Console.ReadLine());
            double precoPassagem;
            if (distancia < 200) {
                precoPassagem = distancia * 0.5;
            }
            else
            {
                precoPassagem = distancia * 0.45;
            }
            Console.WriteLine("Você pagará " + precoPassagem.ToString("C"));
            Console.ReadLine();
        }
    }
}
