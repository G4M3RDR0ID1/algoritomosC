using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (n >= 0 && n <= 25)
        {
            System.Console.WriteLine("Intervalo [0,25]");
        }
        else if (n > 25 && n <= 50)
        {
            System.Console.WriteLine("Intervalo (25,50]");
        }
        else if (n > 50 && n <= 75)
        {
            System.Console.WriteLine("Intervalo (50,75]");
        }
        else if (n > 75 && n <= 100)
        {
            System.Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            System.Console.WriteLine("Fora de intervalo");
        }

    }
}