using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex042
{
    // Exercício 42
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um algoritmo que pergunte ao usuário um número inteiro e positivo 
    // qualquer e mostre uma contagem até esse valor:
    // Ex: Digite um valor: 35
    // Contagem: 1 2 3 4 5 6 7 ... 33 34 35 Acabou!
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo qualquer: ");
            int contador = 0;
            int numero = int.Parse(Console.ReadLine());
            while(contador < numero)
            {
                contador++;
                Console.Write($"{contador} ");
                if(contador == numero)
                {
                    Console.Write("Acabou!");
                }
            }
            Console.ReadLine();
        }
    }
}
