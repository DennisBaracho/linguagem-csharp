using System;
abstract class Padrao
{
    // Quando se cria uma classe abstrata, cria-se um padrão para seu projeto
    // Obrigatório: Pode ser público ou protegido, deve conter o termo "abstract" em sua declaração
    public abstract void TaxaEmprestimo(double valor); // Termina em ; e não duas chaves

    // Opcional: Pode usar se quiser, se não quiser tudo bem
    public void CalculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$"+(valor*taxa));
    }
    
}
