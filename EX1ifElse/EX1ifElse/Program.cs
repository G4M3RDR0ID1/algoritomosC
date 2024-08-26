using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double soma = nota1 + nota2;

        Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));

        if (soma < 60)
        {
            Console.WriteLine("REPROVADO");
        }
    }

}