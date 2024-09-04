using System;

class URI
{

    static void Main(string[] args)
    {

        double[,] mat = new double[12, 12];

        int linha = int.Parse(Console.ReadLine());

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

        for (int i = 0;i < 12; i++) 
        {
            if (operacao == 'S') 
            {
                soma += mat[linha,i];
            }
            if (operacao == 'M') 
            {
                media += mat[linha,i];
            }
        }

        media = media / 12.0;

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