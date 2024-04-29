using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cor = "Preto";
            // Poupa linhas de código em comparação a if, else if e else
            // Forma mais limpa de fazer condicionais
            // Realiza apenas condições de igualdade
            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
                case "Rosa":
                    Console.WriteLine("Sua cor favorita é rosa");
                    break;
                default: //Funciona como o else, quando não há resposta programada
                    Console.WriteLine("Sua cor favorita... Não sei!"); 
                    break;
            }

            Console.ReadLine();
        }
    }
}
