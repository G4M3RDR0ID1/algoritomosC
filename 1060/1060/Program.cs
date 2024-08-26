using System;

class URI
{

    static void Main(string[] args)
    {

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());


        int cont = 0;
        int divi = 0;

        if (a > 0.0)
        {
            cont = cont + 1;
            divi = divi + 1;
        }
        else
        {
            a = 0;
        }
        if (b > 0.0)
        {
            cont = cont + 1;
            divi = divi + 1;
        }
        else
        {
            b = 0;
        }
        if (c > 0.0)
        {
            cont = cont + 1;
            divi = divi + 1;
        }
        else
        {
            c = 0;
        }
        if (d > 0.0)
        {
            cont = cont + 1;
            divi = divi + 1;
        }
        else
        {
            d = 0;
        }
        if (e > 0.0)
        {
            cont = cont + 1;
            divi = divi + 1;
        }
        else
        {
            e = 0;
        }
        if (f > 0.0)
        {
            cont = cont + 1;
            divi = divi + 1;
        }
        else
        {
            f = 0;
        }
        
        double soma = (a + b + c + d + e + f) / divi;
        
        Console.WriteLine(cont + " valores positivos");
        Console.WriteLine(soma.ToString("F1"));

    }
}