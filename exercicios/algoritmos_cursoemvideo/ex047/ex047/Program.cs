using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ex047
{
    // Exercício 47
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Desenvolva um aplicativo que mostre na tela o resultado da expressão:
    // 500 + 450 + 400 + 350 + 300 + ... + 50 + 0 
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 500;
            int soma = 0;
            while(valor > 0)
            {
            Console.Write(valor + " + ");
            soma += valor;
            valor -= 50;
                if (valor == 0)
                {
                    Console.WriteLine(valor);
                }
            }
            Console.WriteLine("O resultado da soma é: " + soma);
            Console.ReadLine();
        }
    }
}
