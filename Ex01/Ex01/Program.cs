using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int n1 = int.Parse(Console.ReadLine());            
            Console.WriteLine("Entre com o preço de um produto: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (Mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string cor = vet[0];
            int idd = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(cor);
            Console.WriteLine(idd);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}