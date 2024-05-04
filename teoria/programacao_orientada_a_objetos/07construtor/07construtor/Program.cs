using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(); // Sem passar o nome, executa o primeiro construtor
            Pessoa p = new Pessoa("Dennis"); // Ao passar o nome, executa o segundo construtor.
        }
    }
}
