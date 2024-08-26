using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        int rato = 0;
        int sapo = 0;
        int coelho = 0;

        for (int i = 0; i < N; i++) 
        {
            string[] vet = Console.ReadLine().Split(' ');
            int numeroDeCobaias = int.Parse(vet[0]);
            char tipoDeCobaias = char.Parse(vet[1]);

            if (tipoDeCobaias == 'R')
            {
                rato = rato + numeroDeCobaias;
            }
            if (tipoDeCobaias == 'S')
            {
                sapo = sapo + numeroDeCobaias;
            }
            if (tipoDeCobaias == 'C')
            {
                coelho = coelho + numeroDeCobaias;
            }
        }

        int total = rato + sapo + coelho;
        double pcoelho = (double)coelho / total * 100;
        double prato = (double)rato / total * 100;
        double psapo = (double)sapo / total * 100;        
        
        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelho);
        Console.WriteLine("Total de ratos: " + rato);
        Console.WriteLine("Total de sapos: " + sapo);
        Console.WriteLine("Percentual de coelhos: " + pcoelho.ToString("f2") + " %");
        Console.WriteLine("Percentual de ratos: " + prato.ToString("f2") + " %");
        Console.WriteLine("Percentual de sapos: " + psapo.ToString("f2") + " %");
    }

}