using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int .Parse(Console.ReadLine());

        int n1, n2, n3, n4, n5, n6;

        if (x % 2 != 0)
        {
            n1 = x;
        }
        else { 
            n1 = x + 1;
        }

        n2 = n1 + 2;
        n3 = n2 + 2;
        n4 = n3 + 2;   
        n5 = n4 + 2;
        n6 = n5 + 2;

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
    }

}