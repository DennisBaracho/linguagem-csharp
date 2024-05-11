using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex034
{
    // Exercício 34
    // Lista de exercícios do Curso em Vídeo de Algoritmos em VisualG do professor Gustavo Guanabara.
    // Autor da resolução: Dennis Baracho.
    // Função: O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no
    // peso de uma pessoa.De acordo com o valor do IMC, podemos classificar o
    // indivíduo dentro de certas faixas.
    // - abaixo de 18.5: Abaixo do peso
    //  - entre 18.5 e 25: Peso ideal
    // - entre 25 e 30: Sobrepeso
    // - entre 30 e 40: Obesidade
    // - acima de 40: Obesidade mórbida
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu peso? ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura? ");
            double altura = double.Parse(Console.ReadLine()); ;
            double imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC é de " + Math.Round(imc,2));
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade");
            }
            else
            {
                Console.WriteLine("Obesidade mórbida");
            }
            Console.ReadLine();
        }
    }
    }
