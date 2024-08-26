using System;

class URI
{

    static void Main(string[] args)
    {
        int alcool = 0, gasolina = 0, diesel = 0;

        int n = 0;

        while (n != 4) 
        {
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                alcool = alcool + 1;
            }
            else if (n == 2) 
            {
                gasolina = gasolina + 1;
            }
            else if (n == 3)
            {
                diesel = diesel + 1;
            }
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }

}