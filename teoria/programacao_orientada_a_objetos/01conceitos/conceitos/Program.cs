using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Dennis";
            obj.idade = 19;
            obj.Mensagem();
        }
    }
}
