using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ex031
{
    // Exercício 31
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)
    internal class Program
    {
        enum Jogadas { Pedra = 1, Papel, Tesoura }
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos jogar pedra, papel e tesoura!");
            // Jogada da Máquina
            Random Resposta = new Random();
            int maquinaResposta = Resposta.Next(1, 4);

            // Jogada do Jogador
            Console.WriteLine("Selecione sua jogada: \n1. Pedra \n2. Papel \n3. Tesoura");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("\nJo... Ken... Po!");
            Jogadas jogadaSelecionada = (Jogadas)index;
            switch (jogadaSelecionada)
            {
                case Jogadas.Pedra:
                    Console.WriteLine("\nVocê joga " + jogadaSelecionada + "!\nMáquina joga " + (Jogadas)maquinaResposta + "!");
                    if ((Jogadas)maquinaResposta == Jogadas.Pedra)
                    {
                        Console.WriteLine("É um empate!");
                    } else if ((Jogadas)maquinaResposta == Jogadas.Papel)
                    {
                        Console.WriteLine("Você perdeu!");
                    }
                    else
                    {
                        Console.WriteLine("Você venceu!");
                    }
                    break;
                case Jogadas.Papel:
                    Console.WriteLine("\nVocê joga " + jogadaSelecionada + "!\nMáquina joga " + (Jogadas)maquinaResposta + "!");
                    if ((Jogadas)maquinaResposta == jogadaSelecionada)
                    {
                        Console.WriteLine("É um empate!");
                    }
                    else if ((Jogadas)maquinaResposta == Jogadas.Tesoura)
                    {
                        Console.WriteLine("Você perdeu!");
                    }
                    else
                    {
                        Console.WriteLine("Você venceu!");
                    }
                    break;
                case Jogadas.Tesoura:
                    Console.WriteLine("\nVocê joga "+jogadaSelecionada+"!\nMáquina joga " + (Jogadas)maquinaResposta + "!");
                    if ((Jogadas)maquinaResposta == jogadaSelecionada)
                    {
                        Console.WriteLine("É um empate!");
                    }
                    else if ((Jogadas)maquinaResposta == Jogadas.Pedra)
                    {
                        Console.WriteLine("Você perdeu!");
                    }
                    else
                    {
                        Console.WriteLine("Você venceu!");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
