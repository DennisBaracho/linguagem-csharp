using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculo c = new Calculo();
            c.somar(10, 15);
            c.subtrair(50, 18);
            Console.ReadLine();
        }
    }
}
