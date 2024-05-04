using System;
class Calculo : Texto, IPadrao
{
    public void somar(int n1, int n2)
    {
        Console.WriteLine("A soma é " + (n1 + n2));
    }

    public void subtrair(int n1, int n2)
    {
        Console.WriteLine(nome+", a subtração é "+(n1-n2));
    }
}
