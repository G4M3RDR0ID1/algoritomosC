using System;

class URI
{

    static void Main(string[] args)
    {

        double soma = 0;
        
        for (int i = 1; i <= 100; i++) 
        {
            double s = 1.0;
            double formula = s / i;
            soma = soma + formula;
        }
        Console.WriteLine(soma.ToString("f2"));
    }

}