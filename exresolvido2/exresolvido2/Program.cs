using System;

class URI
{

    static void Main(string[] args)
    {

        int idd = int.Parse(Console.ReadLine());
        int conta = 0;
        double soma = 0.00;
        double resultado;

        if (idd >= 0) {
           
            while (idd >= 0)
            {
                soma = idd + soma;
                conta = conta + 1;
                idd = int.Parse(Console.ReadLine());

            }

            resultado = soma / conta;
            Console.WriteLine(resultado.ToString("F2"));
        }
        else
        {
            Console.WriteLine("impossivel calcular");
        }
    }

}