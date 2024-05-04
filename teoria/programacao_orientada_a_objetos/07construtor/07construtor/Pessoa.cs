using System;

class Pessoa
{
    // Construtor: executado assim que se instancia um objeto.
    // Pode-se ter vários construtores desde que eles tenham características diferentes.
    public Pessoa()
    {
        Console.WriteLine("Construtor executado.");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá " + nome);
    }
}
