using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex043
{
    // Exercício 43
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva um algoritmo que mostre uma contagem regressiva de 30 até 1, 
    // marcando os números que forem divisíveis por 4, exatamente como mostrado abaixo:
    // 30 29 [28] 27 26 25 [24] 23 22 21 [20] 19 18 17 [16]...
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 30;
            while (contador >= 1)
            {
                
                if (contador % 4 == 0)
                {
                    Console.Write($"{contador} ");
                    if(contador == 1)
                    {
                        Console.Write("Acabou!");
                    }
                }
                contador--;
            }
            Console.ReadLine();
        }
    }
}
