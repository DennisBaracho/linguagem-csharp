using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex046
{
    // Exercício 46
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Crie um programa que calcule e mostre na tela o resultado da soma entre:  
    // 6 + 8 + 10 + 12 + 14 + ... + 98 + 100. 
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 6;
            int soma = 0;
            while (valor <= 100)
            {
                if (valor == 100)
                {
                    Console.WriteLine(valor);
                    soma += valor;
                    valor += 2;
                }
                else
                {
                    Console.Write(valor + " + ");
                    soma += valor;
                    valor += 2;
                }
            }
                Console.WriteLine("O resultado da soma é: " + soma);
                Console.ReadLine();
            }
        }
    }
