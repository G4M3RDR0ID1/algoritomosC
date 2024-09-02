using Ex01MembrosEstaticos;
using System;

class URI
{

    static void Main(string[] args)
    {

        Console.WriteLine("Qual é a cotaçao do dolar: ");
        double cotacao = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantos dólares voce vai comprar? ");
        double dolares = double.Parse(Console.ReadLine());

        double resultado = ConversorDeMoeda.CalculoDeDolares(cotacao, dolares);

        Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("f2"));


    }

}