using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(N);

        int resto = N;

        int nota = 100;
        int quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 100,00");
        resto = resto % nota;

        nota = 50;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 50,00");
        resto = resto % nota;

        nota = 20;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 20,00");
        resto = resto % nota;

        nota = 10;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 10,00");
        resto = resto % nota;

        nota = 5;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 5,00");
        resto = resto % nota;

        nota = 2;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 2,00");
        resto = resto % nota;

        nota = 1;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ 1,00");
    }

}