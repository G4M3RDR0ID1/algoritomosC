using System;

class URI
{

    static void Main(string[] args)
    {

        double[,] mat = new double[12, 12];

        char operacao = char.Parse(Console.ReadLine());

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                mat[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double soma = 0;
        double media = 0;
        int divisor = 0;

        int k = 0;

        for (int i = 5; i > 0; i--)
        {
            for (int j = 7 + k; j <= 11 ; j++)
            {

                soma += mat[i, j];
                divisor++;

            }
            k++;
        }

        k = 0;

        for (int i = 6; i < 11; i++)
        {
            for (int j = 7 + k; j <= 11; j++)
            {


                soma += mat[i, j];
                divisor++;

            }

            k++;
        }



        media = soma / divisor;

        if (operacao == 'S')
        {
            Console.WriteLine(soma.ToString("f1"));
        }
        if (operacao == 'M')
        {
            Console.WriteLine(media.ToString("f1"));
        }

    }

}