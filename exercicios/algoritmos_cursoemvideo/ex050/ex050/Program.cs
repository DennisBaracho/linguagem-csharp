using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex050
{
    // Exercício 50
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva um programa que faça o sorteio de 20 números entre 0 e 10 e mostre na tela: 
    // a) Quais foram os números sorteados
    // b) Quantos números estão acima de 5 
    // c) Quantos números são divisíveis por 3 
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int acimaCinco = 0;
            int divisivelTres = 0;
            Random rnd = new Random();
            Console.WriteLine("Números sorteados: ");
            while (i < 20)
            {
                int numero  = rnd.Next(0, 10);
                Console.Write(numero + " ");
                if(numero > 5)
                {
                    acimaCinco++;
                }
                if((numero % 3 == 0) && (numero > 0))
                {
                    divisivelTres++;
                }
                i++;
                numero = 0;
                
            }
            Console.WriteLine();
            Console.WriteLine("Dos números sorteados, " + acimaCinco + " estavam acima de cinco e " + divisivelTres + " eram divisíveis por 3.");
            Console.ReadLine();
        }
    }
}
