using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe Pessoa
            Pessoa a = new Pessoa();
            a.altura = 1.60;
            a.peso = 90.0;
            a.Mensagem();
            Console.ReadLine();
        }
    }
}
