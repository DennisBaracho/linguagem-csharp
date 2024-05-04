using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Os objetos G e A puxam o(s) método(s) sobrescrito(s), já o E fica com o método padrão.
            // Instanciar Estagiário
            Imposto objetoE = new Estagiario();
            objetoE.ValeAlimentacao(1000);
            objetoE.ValeTransporte(1000);
            Console.WriteLine("-------------------");
            // Instanciar Gerente
            Imposto objetoG = new Gerente();
            objetoG.ValeAlimentacao(5000);
            objetoG.ValeTransporte(5000);
            Console.WriteLine("-------------------");
            // Instanciar Atendente
            Imposto objetoA = new Atendente();
            objetoA.ValeAlimentacao(3000);
            objetoA.ValeTransporte(3000);
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }
    }
}
