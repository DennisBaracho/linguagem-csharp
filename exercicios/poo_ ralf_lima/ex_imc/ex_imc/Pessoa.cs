using System;

class Pessoa
{
    // Atributos
    public double peso;
    public double altura;
    // Métodos
    public double CalcIMC()
    {
        // Cálculo do IMC
        double imc = peso / (altura * altura);
        return imc;
    }

    public string Avaliacao(double imc)
    {
        // Avaliando a situação
        if(imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else if(imc < 25)
        {
            return "Peso normal";
        }
        else if(imc < 30)
        {
            return "Acima do Peso";
        }
        else if(imc < 35)
        {
            return "Obesidade I";
        }
        else if (imc < 40)
        {
            return "Obesidade II";
        }
        else
        {
            return "Obesidade III";
        }
    }
    public void Mensagem()
    {
        // Obter o Cálculo
        double obterImc = CalcIMC();
        // Obter a Situação
        string obterAvaliacao = Avaliacao(obterImc);

        Console.WriteLine("O seu IMC é "+Math.Round(obterImc, 2)+", sua avaliação é de: "+obterAvaliacao);
    }
}