﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // && - E/AND
            //      TRUE  && TRUE  -> TRUE
            //      TRUE  && FALSE -> FALSE
            //      FALSE && FALSE -> FALSE

            // || - OU/OR
            //      TRUE  || TRUE  -> TRUE
            //      TRUE  || FALSE -> TRUE
            //      FALSE || FALSE -> FALSE

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine()); // Conversão de texto recebido para número inteiro

            if ((idade >= 0) && (idade <= 11))
            {
                Console.WriteLine("Você é uma criança!");
            }
            else if ((idade >= 12) && (idade <= 18))
            {
                Console.WriteLine("Você é um adolescente!");
            }
            else if ((idade >= 19) && (idade <= 60))
            {
                Console.WriteLine("Você é um adulto!");
            }
            else
            {
                Console.WriteLine("Você é um idoso!");
            }
            Console.ReadLine();
        }
    }
}
