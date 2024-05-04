using System;
using System.Runtime.Remoting.Messaging;
class Pessoa
{
    // Atributo privado nome
    private string nome;
    // Get e Set: Pegar e enviar o valor, respectivamente. Usado no encapsulamento
    public string Nome // Nome exatamente como o atributo, porém com letra inicial maiúscula. 
    {
        get { return nome; } // Obter o valor nome
        set { nome = value; } // Envia o valor nome
    } 
}
