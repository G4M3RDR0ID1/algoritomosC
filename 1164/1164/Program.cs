using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int numero = int.Parse(Console.ReadLine());
            int SomaDeNumerosPerfeitos = 0;

            for (int j = 1; j < numero; j++)
            {
                if (numero % j == 0)
                {
                    SomaDeNumerosPerfeitos = SomaDeNumerosPerfeitos + j;
                }
            }

            if (SomaDeNumerosPerfeitos == numero)
            {
                Console.WriteLine(numero + " eh perfeito");
            }
            else
            {
                Console.WriteLine(numero + " nao eh perfeito");
            }

        }

    }

}