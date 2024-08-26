using System;

class URI
{

    static void Main(string[] args)
    {

        int tempo = int.Parse(Console.ReadLine());
        int kmH = int.Parse(Console.ReadLine());
        double litrosGastos = (double) (kmH * tempo) / 12;
        Console.WriteLine(litrosGastos.ToString("F3"));

    }

}