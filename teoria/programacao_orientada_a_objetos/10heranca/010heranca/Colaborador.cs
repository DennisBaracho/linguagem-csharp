using System;
class Colaborador : Pessoa // Criando a herança, agora Colaborador tem acesso a métodos e atributos public e protected de Pessoa.
                           // Não existe herança múltipla em C#, Java ou PHP, portanto só pode ter a herança de Pessoa.
{
    // Atributos 
    private double salario;
    private string cargo;

    // Construtor
    public Colaborador(string nome, int idade, double salario, string cargo)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;
        this.cargo = cargo;

        MensagemPessoa();
        MensagemColaborador();
    }

    // Método
    private void MensagemColaborador()
    {
        Console.WriteLine("Salario: " + salario);
        Console.WriteLine("Cargo: " + cargo);
    }
}
