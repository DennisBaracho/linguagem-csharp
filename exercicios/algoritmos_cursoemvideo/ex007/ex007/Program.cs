using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex007
{
    // Exercício 7
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            float numReal = float.Parse(Console.ReadLine());
            Console.WriteLine("O dobro de " + numReal + " é " + (2 * numReal));
            Console.WriteLine("A terça parte de " + numReal + " é " + (numReal / 3));
            Console.ReadLine();
        }
    }
}
