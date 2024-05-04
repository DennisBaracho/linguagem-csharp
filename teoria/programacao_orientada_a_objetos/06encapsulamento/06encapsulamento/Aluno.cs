using System;

class Aluno
{
    // Atributos
    private double nota1, nota2;

    // Média 
    private double Media()
    {
        return (nota1 + nota2) / 2;
    }

    // Mensagem
    public void Mensagem()
    {
        Console.WriteLine("Informe a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("A média é "+Media());
        Console.ReadLine();
    }
}