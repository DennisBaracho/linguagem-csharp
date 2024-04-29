using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capturando_entrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            Console.WriteLine("Escreva seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);
            Console.ReadLine();
        }
    }
}
