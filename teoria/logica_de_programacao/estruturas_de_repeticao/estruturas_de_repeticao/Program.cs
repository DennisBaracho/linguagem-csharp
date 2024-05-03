using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturas_de_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHILE 
            int contador = 0;
            while (contador <= 10) // Enquanto a condição for verdadeira, faça
            {
                Console.WriteLine(contador + " Carneiro(s)");
                // contador = contador + 1;
                // contador += 1;
                contador++;
            }

            Console.WriteLine("");

            // DO WHILE 
            int contador2 = 0;
            do
            {
                Console.WriteLine("Do while!");
            } while (contador2 > 20); // Por mais que a condição seja falsa, ele executará ao menos uma vez o código

            Console.WriteLine("");

            // FOR EACH
            string[] palavras = { "Programação", "C#", "Estudo", "Array" };
            foreach(string palavra in palavras) // Para cada palavra no Array de palavras, repita o bloco de código
            {
                Console.WriteLine("FOREACH RODANDO");
                Console.WriteLine(palavra); // Percorre o Array
            }

            Console.WriteLine("");

            // FOR
            string[] nomes = { "João", "José", "Serafina", "Cláudia" }; 
            // for (variável; condição para execução; incremento/decremento)
            for (int contador3 = 0; contador3 < nomes.Length; contador3++) // Percorrendo de forma crescente
            {
                Console.WriteLine(contador3);
                Console.WriteLine(nomes[contador3]);
            }

            Console.WriteLine("");

            for (int contador4 = nomes.Length-1; contador4 >= 0; contador4--) // Percorrendo de forma decrescente (não tem no FOR EACH)
            {
                Console.WriteLine(contador4);
                Console.WriteLine(nomes[contador4]);
            }

            Console.WriteLine("FIM DO PROGRAMA!");
            Console.ReadLine();

        }
    }
}