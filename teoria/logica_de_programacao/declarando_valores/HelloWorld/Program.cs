using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Int - Armazena números inteiros negativos e positivos
            // Float - Armazena números decimais. Coloque f no final
            // Bool - Dados booleanos (V/F)
            // Char - Armazena character, 'a'
            // String - Armazena texto, "tudo em aspas duplas"

            int meuAniversario = 2004;
            string cor_favorita = "Verde-água";
            float velocidadeF1 = 294.48f;
            bool euEnvelheco = true;
            const float pi = 3.1456f; // Constantes nunca mudam

            Console.WriteLine(meuAniversario);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(euEnvelheco);
            Console.WriteLine(pi);

            // Variáveis podem ser alteradas durante o programa
            velocidadeF1 = 348.295f;
            cor_favorita = "Azul";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(cor_favorita);
            Console.ReadLine();
        }
    }
}