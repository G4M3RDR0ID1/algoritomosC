using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        string[] N = Console.ReadLine().Split(' ');
        int A = int.Parse(N[0]);
        int B = int.Parse(N[1]);
        int C = int.Parse(N[2]);

        if (A > B || B > C)
        {
            Console.WriteLine(A + " eh o maior");
        }
        else if (B > C)
        {
            Console.WriteLine(B + " eh o maior");
        }
        else
        {
            Console.WriteLine(C + " eh o maior");
        }

    }
}