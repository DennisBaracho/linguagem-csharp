using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ex028
{
    // Exercício 28
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um programa que leia a largura e o comprimento de um terreno
    // retangular, calculando e mostrando a sua área em m². O programa também
    // deve mostrar a classificação desse terreno, de acordo com a lista abaixo:
    // - Abaixo de 100m² = TERRENO POPULAR
    // - Entre 100m² e 500m² = TERRENO MASTER
    // - Acima de 500m² = TERRENO VIP
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine());
            double area = comprimento * largura;
            if(area < 100)
            {
                Console.WriteLine("TERRENO POPULAR");
            }else if((area >= 100) && (area <= 500)){
                Console.WriteLine("TERRENO MASTER");
            }
            else
            {
                Console.WriteLine("TERRENO VIP");
            }
            Console.ReadLine();
        }
    }
}
