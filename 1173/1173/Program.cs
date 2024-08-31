using System;

class URI
{

    static void Main(string[] args)
    {

        int[] vet = new int[10];
        int n = int.Parse(Console.ReadLine());
        vet[0] = n;
        
        for (int i = 1; i < 10; i++)
        {
            vet[i] = n * 2;
            n = n * 2;
        }

        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine("N[" + i + "] = " + vet[i]);
        }

    }

}