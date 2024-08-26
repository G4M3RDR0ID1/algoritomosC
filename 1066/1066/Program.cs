using System;

class URI
{

    static void Main(string[] args)
    {

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());

        int pares = 0;
        int positivos = 0;
        int negativos = 0;
        int impares = 0;

        if (n1 % 2 == 0)
        {
            pares = pares + 1;
        }
        else
        {
            impares = impares + 1;
        }
        if (n1 > 0) 
        {
            positivos = positivos + 1;
        }
        else if (n1 < 0)
        {
            negativos = negativos + 1;
        }
        if (n2 % 2 == 0)
        {
            pares = pares + 1;
        }
        else
        {
            impares = impares + 1;
        }
        if (n2 > 0)
        {
            positivos = positivos + 1;
        }
        else if (n2 < 0)
        {
            negativos = negativos + 1;
        }
        if (n3 % 2 == 0)
        {
            pares = pares + 1;
        }
        else
        {
            impares = impares + 1;
        }
        if (n3 > 0)
        {
            positivos = positivos + 1;
        }
        else if (n3 < 0)
        {
            negativos = negativos + 1;

        }
        if (n4 % 2 == 0)
        {
            pares = pares + 1;
        }
        else
        {
            impares = impares + 1;
        }
        if (n4 > 0)
        {
            positivos = positivos + 1;
        }
        else if (n4 < 0)
        {
            negativos = negativos + 1;

        }
        if (n5 % 2 == 0)
        {
            pares = pares + 1;
        }
        else
        {
            impares = impares + 1;
        }
        if (n5 > 0)
        {
            positivos = positivos + 1;
        }
        else if (n5 < 0)
        {
            negativos = negativos + 1;

        }

        Console.WriteLine(pares + " valor(es) par(es)");
        Console.WriteLine(impares + " valor(es) impar(es)");
        Console.WriteLine(positivos + " valor(es) positivo(s)");
        Console.WriteLine(negativos + " valor(es) negativo(s)");

    }
}