using System;

class URI
{

    static void Main(string[] args)
    {

        double[] vet = new double[10];
        
        double x = double.Parse(Console.ReadLine());


        for (int i = 0; i < 10; i++) 
        {
            vet[i] = x;
            x = x / 2;
            Console.WriteLine("N[" + i + "] = " + vet[i].ToString("F4"));
        }

    }

}