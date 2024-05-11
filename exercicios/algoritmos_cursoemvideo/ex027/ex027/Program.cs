using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex027
{
    // Exercício 27
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função:  Crie um programa que leia duas notas de um aluno e calcule a sua média,
    // mostrando uma mensagem no final, de acordo com a média atingida:
    // - Média até 4.9: REPROVADO
    // - Média entre 5.0 e 6.9: RECUPERAÇÃO
    // - Média 7.0 ou superior: APROVADO
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2) / 2;
            if(media < 4.9)
            {
                Console.WriteLine("REPROVADO");
            }
            else if((media > 5) && (media < 6.9))
            {
                Console.WriteLine("RECUPERAÇÃO");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
            Console.ReadLine();
        }
    }
}
