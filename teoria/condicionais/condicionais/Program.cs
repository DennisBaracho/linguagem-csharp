using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            > - Maior que
            < - Menor que
            >= - Maior Igual
            <= - Menor Igual
            == - Igualdade
            != - Diferente de
            De acordo com o valor booleano das condições, o código se executará de formas diferentes:
            Ex.: Se minha idade é maior ou igual a 18 anos (true), tiro a carteira. Se não (false), não tiro.
            */

            bool maior = 10 > 2;
            bool menor = 2 < 100;
            bool maiorIgual = 10 >= 10;
            bool menorIgual = 1 <= 2;
            bool igual = 4 == 4;
            bool diferente = 3 != 4;

            Console.WriteLine(maior);
            Console.WriteLine(menor);
            Console.WriteLine(maiorIgual);
            Console.WriteLine(menorIgual);
            Console.WriteLine(igual);
            Console.WriteLine(diferente);

            // Estrutura condicional básica

            int idade;
            Console.WriteLine("Quantos anos você tem?");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você pode tirar a carteira!");
            }
            else if (idade <= 0)
            {
                Console.WriteLine("Reinicie e digite um número válido (idade > 0).");
            }
            else
            {
                Console.WriteLine("Você não pode tirar a carteira.");
            }
            Console.ReadLine();
        }
    }
}
