using System;

class URI
{

    static void Main(string[] args)
    {
        string[] equacao = Console.ReadLine().Split(' ');

        double A = double.Parse(equacao[0]);
        double B = double.Parse(equacao[1]);
        double C = double.Parse(equacao[2]);

        double delta = Math.Pow(B, 2) - 4 * A * C;

        if (delta <= 0) {
            Console.WriteLine("Impossivel calcular");
        } 
        else {
            if (2 * A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                Console.WriteLine("R1 = " + x1.ToString("F5"));
                Console.WriteLine("R2 = " + x2.ToString("F5"));
            }
        }
            
    }
}