using System;
using System.Xml;

class URI
{

    static void Main(string[] args)
    {

        double N = double.Parse(Console.ReadLine());   
        Console.WriteLine("NOTAS:");

        int resto = (int) N;

        int nota = 100;
        int quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 100.00");
        resto = resto % nota;

        nota = 50;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 50.00");
        resto = resto % nota;

        nota = 20;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 20.00");
        resto = resto % nota;

        nota = 10;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 10.00");
        resto = resto % nota;

        nota = 5;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 5.00");
        resto = resto % nota;

        nota = 2;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 2.00");
        resto = resto % nota;

        Console.WriteLine("MOEDAS:");

        double restoM = (double) resto;

        double moeda = 1;
        double quocienteMoeda = restoM / moeda;
        Console.WriteLine(quocienteMoeda + " moeda(s) de R$ 1.00");
        restoM = restoM % moeda;

        moeda =  0.50;
        quocienteMoeda = restoM / moeda;
        Console.WriteLine(quocienteMoeda + " moeda(s) de R$ 0.50");
    }

}