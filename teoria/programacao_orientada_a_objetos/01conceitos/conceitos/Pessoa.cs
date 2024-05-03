using System;

// Classe: molde para a criação de elementos
class Pessoa
{
    // Atributos: características que uma pessoa pode ter
    public string nome;
    public int idade;
    // Métodos: funções de um objeto
    public void Mensagem()
    {
        Console.WriteLine("Olá " + nome + " você tem " + idade + " anos");
        Console.ReadLine();
    }
}

