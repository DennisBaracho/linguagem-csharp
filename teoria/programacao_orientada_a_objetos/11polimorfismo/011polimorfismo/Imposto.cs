using System;
class Imposto
{
    // Métodos
    public virtual void ValeAlimentacao(double salario) // Virtual permite que o método seja sobrescrito em outras partes do programa
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$" + (salario * 0.1));
    }

    public void ValeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale transporte R$" + (salario * 0.06));
    }
}
