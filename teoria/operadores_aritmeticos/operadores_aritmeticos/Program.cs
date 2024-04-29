using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 20 + 20 - 80;
            int numeroMulti = 10 * 90;

            // int numeroDiv = 5 / 2;
            float numeroDiv = 5.0f / 2;

            /*
                Se o resultado não for da tipagem inicial, o resultado sairá na tipagem inicial
                int 6/2 => 3 (int) OK
                int 5/2 => 2.5 (float), se tornará 2, a casa decimal será eliminada
            */

            int calculo = 20 + 20 * 2;
            int calculo2 = (20 + 20) * 2;

            /*
                Além disso, as operações seguem a ordem PEMDAS 
                (Potenciação -> exponenciação -> multiplicação -> divisão -> adição -> subtração)
                Da esquerda para a direita e com parênteses, chaves e colchetes que podem alterar a prioridade
            */

            Console.WriteLine(numero);
            Console.WriteLine(numeroMulti);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(calculo);
            Console.WriteLine(calculo2);

            Console.ReadLine();
        }
    }
}
