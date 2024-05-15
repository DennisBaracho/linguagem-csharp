using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ex036
{
    // Exercício 36
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Um programa de vida saudável quer dar pontos atividades físicas que podem 
    // ser trocados por dinheiro.O sistema funciona assim:
    // - Cada hora de atividade física no mês vale pontos
    // - até 10h de atividade no mês: ganha 2 pontos por hora
    // - de 10h até 20h de atividade no mês: ganha 5 pontos por hora
    // - acima de 20h de atividade no mês: ganha 10 pontos por hora
    // - A cada ponto ganho, o cliente fatura R$0,05 (5 centavos)
    // Faça um programa que leia quantas horas de atividade uma pessoa teve por mês,
    // calcule e mostre quantos pontos ela teve e quanto dinheiro ela conseguiu ganhar.
    internal class Program
    {
        static void Main(string[] args)
        {
            double pontos;
            Console.Write("Quantas horas você esteve ativo esse mês? ");
            double horas = Double.Parse(Console.ReadLine());
            if(horas < 10)
            {
                pontos = 2 * horas;
            } else if ((horas >= 10) && (horas <= 20)) 
            {
                pontos = 5 * horas;
            } else
            {
                pontos = 10 * horas;
            }
            double dinheiro = pontos * 0.05;
            Console.WriteLine($"Você marcou {pontos} pontos e ganhou {dinheiro.ToString("C")}.");
            Console.ReadLine();
        }
    }
}
