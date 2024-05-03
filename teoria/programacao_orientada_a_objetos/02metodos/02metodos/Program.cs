using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.apresentar(); // Abaixo, há 2 overloads, ou seja, métodos com ações diferentes que podem se sobrescrever
            obj.apresentar("Denni"); // Se passar apenas o nome, executa esse.
            obj.apresentar("Denni", 19); // Se passar nome e idade, executa esse.
            Console.ReadLine();
        }
    }
}
