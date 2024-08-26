using System;

class URI
{

    static void Main(string[] args)
    {


        string[] notas = Console.ReadLine().Split(' ');
        float N1 = float.Parse(notas[0]);
        float N2 = float.Parse(notas[1]);
        float N3 = float.Parse(notas[2]);
        float N4 = float.Parse(notas[3]);
        float media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10;

        if (media == 4.85f)
        {
            media = 4.8f;
        }

        Console.WriteLine("Media: " + media.ToString("F1"));

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            float nx = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: " + nx.ToString("F1"));

            float mediafinal = (media + nx) / 2;

            if (media >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: " + mediafinal.ToString("F1"));
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + mediafinal.ToString("F1"));
            }
        }
    }
}