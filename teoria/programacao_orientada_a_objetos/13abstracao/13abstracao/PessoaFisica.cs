using System;
class PessoaFisica : Padrao // Para não dar erro, use o método obrigatório
{ 
    // Método obrigatório
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para Pessoa Física R$" + (valor * 0.1));
    }
}
