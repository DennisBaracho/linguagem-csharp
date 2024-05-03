using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_escolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome = "Dênis";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();
            Console.ReadLine();
        }
    }
}
