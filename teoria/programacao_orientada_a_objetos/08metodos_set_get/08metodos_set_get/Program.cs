using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08metodos_set_get
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            // É o get quem faz o nome ser exibido, sem ele não é possível ter o acesso
            // Já sem o set, a atribuição nunca acontece, apenas a leitura
            p.Nome = "Ralf"; 
            Console.WriteLine(p.Nome); 
            Console.ReadLine();
        }
    }
}
