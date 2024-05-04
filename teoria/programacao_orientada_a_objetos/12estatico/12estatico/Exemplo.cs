using System;
 class Exemplo
{
    // Atributo estático
    public static string nome = "Dennis"; // static: Vou ter acesso ao atributo nome sem precisar instanciar o objeto

    // Método estático
    public static void Soma(int n1, int n2) // static: Vou ter acesso ao método Soma sem precisar instanciar o objeto
    {
        Console.WriteLine(n1 + n2);
    }
    
}
    