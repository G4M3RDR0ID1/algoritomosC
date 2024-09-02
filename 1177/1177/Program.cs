using System;

class URI
{

    static void Main(string[] args)
    {

        int[] N = new int[1000];

        int T = int.Parse(Console.ReadLine());
        int sequencia = 0;

        for (int i = 0; i < 1000; i++)
        {
            N[i] = sequencia;
            sequencia++;
            if (sequencia == T)
            {
                sequencia = 0;
            }

            Console.WriteLine("N[" + i + "] = " + N[i]);
        }

    }

}