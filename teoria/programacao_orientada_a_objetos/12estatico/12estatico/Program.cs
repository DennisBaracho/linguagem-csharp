using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _12estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ao abrir o menu de métodos/atributos, o Soma e nome já estão disponíveis
            // Usando static ao declarar, é possível ter o acesso a eles sem instanciar o objeto

            // Método estático
            Exemplo.Soma(3, 7); 

            // Atributo estático
            Console.WriteLine("Olá " + Exemplo.nome);

            Console.ReadLine();
        }
    }
}
