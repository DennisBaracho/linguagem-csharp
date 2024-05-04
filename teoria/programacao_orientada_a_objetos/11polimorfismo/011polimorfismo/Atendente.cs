using System;
class Atendente : Imposto
{
    // Método
    public override void ValeAlimentacao(double salario) // Override permite que o método seja sobrescrito
    {
        Console.WriteLine("Desconto atendente do vale alimentação R$" + (salario * 0.12));
    }
}

