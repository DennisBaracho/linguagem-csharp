using System;

class Pessoa
{
    // Atributo
    private string nome = "Tatiana";

    // Construtor
    public Pessoa(string nome)
    {
        // Usa o valor presente no Program.cs
        Console.WriteLine(nome);
        // Liga o atributo da classe ao SEU método. Usa ESSE valor.
        Console.WriteLine(this.nome);
    }
}
