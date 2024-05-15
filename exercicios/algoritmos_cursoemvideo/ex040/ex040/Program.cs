using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex040
{
    // Exercício 40
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: Crie um aplicativo que mostre na tela a seguinte contagem:
    // 0 3 6 9 12 15 18 Acabou!
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while(contador <= 18)
            {
                Console.Write($"{contador} ");
                contador += 3;
                if(contador > 18)
                {
                    Console.Write("Acabou!");
                }
            }
            Console.ReadLine();
        }
    }
}
