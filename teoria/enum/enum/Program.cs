using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
         // O enum cria um novo tipo de dado para um conjunto limitado de valores.
         // Muito utilizados juntamente aos switches para criar menus.
        enum Cor
        {
            Vermelho, Amarelo, Azul, // Não precisa estar entre string. Funciona parecido com o array em numeração.
            Preto = 44, Branco // É possível trocar a enumeração.
        }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            // Com o enum declarado, é possível criar variáveis usando o seu conjunto.
            Cor corFavorita = Cor.Vermelho;
            Cor corFavoritaDaCarla = Cor.Azul;

            Console.WriteLine((int)corFavorita); // Converte um enum(cor) em um número, cast (converter um tipo para o outro).
            Console.WriteLine(corFavoritaDaCarla);
            Console.WriteLine((Cor)2); // Converte número para um enum.
            
            // Criando um menu com enum e switch
            Console.WriteLine("\nSelecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index; // Cast

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("DELETADO!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editar é muito bom!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }

            Console.WriteLine(opcaoSelecionada);
            Console.ReadLine();
        }
        
    }
}
