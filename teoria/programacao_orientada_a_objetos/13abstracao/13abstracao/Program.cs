using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.TaxaEmprestimo(1000);
            pf.CalculoPoupanca(1000, 200);
            Console.WriteLine();
            PessoaJuridica pj = new PessoaJuridica();
            pj.TaxaEmprestimo(1000);
            Console.ReadLine();
        }
    }
}
