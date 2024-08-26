using System;

class URI
{

    static void Main(string[] args)
    {

        string[] vet = Console.ReadLine().Split(' ');
        int codigo = int.Parse(vet[0]);
        int quantidade = int.Parse(vet[01]);

        if (codigo == 1)
        {
            double total = 4.00 * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
        else if (codigo == 2)
        {
            double total = 4.50 * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
        else if (codigo == 3)
        {
            double total = 5.00 * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
        else if (codigo == 4)
        {
            double total = 2.00 * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
        else if (codigo == 5) {
            double total = 1.50 * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
    }
}