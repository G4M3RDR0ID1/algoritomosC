using System;

class URI
{

    static void Main(string[] args)
    {
        double media;
        double n1 = double.Parse(Console.ReadLine());

        while (n1 < 0.0 || n1 > 10.0)
        {
            Console.WriteLine("nota invalida");
            n1 = double.Parse(Console.ReadLine());

        }
        
        double n2 = double.Parse(Console.ReadLine());

        while (n2 < 0.0 || n2 > 10.0)
        {
            Console.WriteLine("nota invalida");
            n2 = double.Parse(Console.ReadLine());

        }

        media = (n1 + n2) / 2;

        Console.WriteLine("media = " + media.ToString("F2"));
    }

}