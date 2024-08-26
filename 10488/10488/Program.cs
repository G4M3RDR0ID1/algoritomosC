using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double percentual, novosalario, reajuste;
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario <= 400.00)
        {
            percentual = 15;
        }
        else if (salario <= 800.00)
        {
            percentual = 12;
        }
        else if (salario <= 1200.00)
        {
            percentual = 10;
        }
        else if (salario <= 2000.00)
        {
            percentual = 7;
        }
        else {
            percentual = 4;
        }

        reajuste = (percentual / 100) * salario;
        novosalario = salario + reajuste;
        
        Console.WriteLine("Novo salario: " + novosalario.ToString("F2"));
        Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"));
        Console.WriteLine("Em percentual: " + percentual.ToString("F0") + " %");

    }

}