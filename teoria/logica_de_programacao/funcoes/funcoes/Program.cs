using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem();
            Alimento("Croissant", 406, 3.30);
            Alimento("Pizza", 2000, -30);

            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(5, 100, 20);
            int soma3 = Somar(100, 200, 300);

            Console.WriteLine("\n" + soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

            Console.ReadLine();
        }

        static void Mensagem()
        {
            Console.WriteLine("Meu nome é Dennis!");
            Console.WriteLine("E eu estou usando funções");
            Console.WriteLine("Essa é uma delas");
        }

        static void Alimento(string nome, int calorias, double preco) // Função sem retorno, vazia
        {
            double precoAbs = Math.Abs(preco); // Impede que o usuário coloque um número negativo
            Console.WriteLine("\n======== PRODUTO ========");
            Console.WriteLine("Seu alimento é um(a) " + nome);
            Console.WriteLine("Ele tem um total de " + calorias + " calorias");
            Console.WriteLine("E custa um total de R$" + precoAbs + " para produção");
            double ValorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Assim, o valor final é de R$" + ValorFinal);
        }
        
        static int Somar(int a , int b, int c) // Função com retorno. É obrigatório retornar caso o tipo não seja "void"
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
            // Abaixo do retorno, nada é executado.
            Console.WriteLine("Não existo");
        }
    }
}
