using System;

class URI
{

    static void Main(string[] args)
    {
        int[] vet = new int[10];

        for (int i = 0; i < 10; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            if (vet[i] <= 0)
            {
                vet[i] = 1;
            }

            Console.WriteLine("X[" + i + "] = " + vet[i]);
        }

    }

}