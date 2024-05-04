using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            // Quanto maior o encapsulamento, mais segurança. Nesse caso, não se pode acessar as notas por estarem privadas.
            a.Mensagem();
        }
    }
}
