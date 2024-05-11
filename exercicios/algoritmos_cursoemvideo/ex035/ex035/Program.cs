using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ex035
{
    // Exercício 35
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: 35) Uma empresa de aluguel de carros precisa cobrar pelos seus serviços. O
    // aluguel de um carro custa R$90 por dia para carro popular e R$150 por dia para
    // carro de luxo.Além disso, o cliente paga por Km percorrido. Faça um programa
    // que leia o tipo de carro alugado (popular ou luxo), quantos dias de aluguel e
    // quantos Km foram percorridos.No final mostre o preço a ser pago de acordo com a
    // tabela a seguir:
    // - Carros populares(aluguel de R$90 por dia)
    // - Até 100Km percorridos: R$0,20 por Km
    // - Acima de 100Km percorridos: R$0,10 por Km
    // - Carros de luxo(aluguel de R$150 por dia)
    // - Até 200Km percorridos: R$0,30 por Km
    // - Acima de 200Km percorridos: R$0,25 por Km
    internal class Program
    {
        enum Tipos { popular = 1, luxo }
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tipo do carro alugado? \n1. Popular \n2. Luxo");
            int index = int.Parse(Console.ReadLine());
            Console.Write("\nQuantos dias de aluguel? ");
            int diasAluguel = int.Parse(Console.ReadLine());
            Console.Write("Quantos Km foram percorridos? ");
            int kmPercorridos = int.Parse(Console.ReadLine());
            Tipos tipoSelecionado = (Tipos)index;
            double preco = 0;
            switch (tipoSelecionado)
            {
                case Tipos.popular:
                    if(kmPercorridos < 100)
                    {
                        preco = (90 * diasAluguel) + (0.20 * kmPercorridos);
                    }
                    else
                    {
                        preco = (90 * diasAluguel) + (0.10 * kmPercorridos);
                    }
                    break;
                case Tipos.luxo:
                    if(kmPercorridos < 200)
                    {
                        preco = (150 * diasAluguel) + (0.30 * kmPercorridos);
                    }
                    else
                    {
                        preco = (150 * diasAluguel) + (0.25 * kmPercorridos);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nPreço a ser pago: "+preco.ToString("C"));
            Console.ReadLine();
        }
    }
}
