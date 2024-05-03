using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ex005
{
    // Exercício 5
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2) / 2;
            Console.Write("A média entre " + nota1 + " e " + nota2 + " é igual a " + media);
            Console.ReadLine();
        }
    }
}
