using System;

class URI
{

    static void Main(string[] args)
    {

        string[] vet = Console.ReadLine().Split(' ');
        int A = int.Parse(vet[0]);
        int B = int.Parse(vet[1]);
        int C = int.Parse(vet[2]);

        if (A < B && B < C)
        {
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Console.WriteLine();

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
        else if (A < B && B > C && C > A)
        {
            Console.WriteLine(A);
            Console.WriteLine(C);
            Console.WriteLine(B);

            Console.WriteLine();

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
        else if (B < A && A < C)
        {
            Console.WriteLine(B);
            Console.WriteLine(A);
            Console.WriteLine(C);

            Console.WriteLine();

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
        else if (B < A && A > C && B < C)
        {
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(A);

            Console.WriteLine();

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
        else if (C < A && A < B)
        {
            Console.WriteLine(C);
            Console.WriteLine(A);
            Console.WriteLine(B);

            Console.WriteLine();

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
        else
        {
            Console.WriteLine(C);
            Console.WriteLine(B);
            Console.WriteLine(A);

            Console.WriteLine();

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }

}