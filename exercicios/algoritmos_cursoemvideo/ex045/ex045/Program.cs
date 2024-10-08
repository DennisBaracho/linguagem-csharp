using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ex045
{
    internal class Program
    {
        // Exercício 45
        // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
        // Autor da resolução: Dennis Baracho.
        // Função: O programa acima vai ter um problema quando digitarmos o primeiro valor 
        // maior que o último.Resolva esse problema com um código que funcione em qualquer situação. 
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro Valor: ");
            int valor_inicial = int.Parse(Console.ReadLine());
            Console.Write("Digite o ultimo Valor: ");
            int valor_final = int.Parse(Console.ReadLine());
            Console.Write("Digite o incremento: ");
            int i = int.Parse(Console.ReadLine());
            int valor_atual = valor_inicial;
            if ((valor_final < valor_inicial))
            {
                i = -i;
                Console.WriteLine("O valor final é menor que o inicial, a contagem será feita com um incremento negativo.");
                while(valor_atual > valor_final)
                {
                    Console.Write(valor_atual + " ");
                    valor_atual += i;
                    if(valor_atual == valor_final)
                    {
                        Console.Write(valor_final + " ");
                    }
                }
                Console.Write("Acabou!");
            }
            else if((valor_inicial < valor_final))
            {
                i = +i;
                Console.WriteLine("O valor inicial é menor que o final, a contagem será feita com um incremento positivo.");
                while (valor_atual < valor_final)
                {
                    Console.Write(valor_atual + " ");
                    valor_atual += i;
                    if (valor_atual == valor_final)
                    {
                        Console.Write(valor_final + " ");
                    }
                }
                Console.Write("Acabou!");
            }
            else
            {
                Console.Write("Os valores devem ser diferentes, reinicie o programa.");
            }
            Console.ReadLine();
        }
    }
}
