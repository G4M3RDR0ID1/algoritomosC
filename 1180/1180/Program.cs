using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        string[] vet = Console.ReadLine().Split(' ');

        int[] x = new int[n];

        for (int i = 0; i < n; i++)
        {
            x[i] = int.Parse(vet[i]);
        }

        int menor = x[0];
        int menorposicao = 0;

        for (int i = 0; i < n; i++) 
        {

            if (x[i] < menor) 
            {
                menor = x[i];
                menorposicao = i;
            }
        }

        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Posicao: " + menorposicao);

    }

}