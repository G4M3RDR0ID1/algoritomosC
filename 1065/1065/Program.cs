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

        if (n1 % 2 == 0) 
        {
            pares = pares + 1;
        }
        if (n2 % 2 == 0)
        {
            pares = pares + 1;
        }
        if (n3 % 2 == 0)
        {
            pares = pares + 1;
        }
        if (n4 % 2 == 0)
        {
            pares = pares + 1;
        }
        if (n5 % 2 == 0)
        {
            pares = pares + 1;
        }

        Console.WriteLine(pares + " valores pares");
    }

}