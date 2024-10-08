using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex044
{
    // Exercício 44
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Crie um algoritmo que leia o valor inicial da contagem, o valor final e o 
    // incremento, mostrando em seguida todos os valores no intervalo: 
    // Ex: Digite o primeiro Valor: 3 
    // Digite o último Valor: 10 
    // Digite o incremento: 2 
    // Contagem: 3 5 7 9 Acabou! 

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro Valor: ");
            int valor_inicial = int.Parse(Console.ReadLine());
            Console.Write("Digite o ultimo Valor: ");
            int valor_final = int.Parse(Console.ReadLine());
            Console.Write("Digite o incremento: ");
            int i= int.Parse(Console.ReadLine());
            int valor_atual = valor_inicial;
            while (valor_atual < valor_final)
            {
                Console.Write(valor_atual + " ");
                valor_atual += i;
                if(valor_atual > valor_final)
                {
                    Console.WriteLine("Acabou!");
                }
                else if(valor_atual == valor_final)
                {
                    Console.Write(valor_atual);
                }
            }
            Console.ReadLine();

        }
    }
}
