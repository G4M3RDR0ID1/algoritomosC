using System;

class URI
{

    static void Main(string[] args)
    {

        int cha = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(' ');
        int[] votos = new int[5];
        int acertos = 0;
        
        for (int i = 0; i < 5; i++)
        {
            votos[i] = int.Parse(valores[i]);

            if (cha == votos[i])
            {
                acertos++;
            }
        }

        Console.WriteLine(acertos);
    }

}