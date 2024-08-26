using System;

class URI
{

    static void Main(string[] args)
    {

        string[] vet = Console.ReadLine().Split(' ');
        int H_inicio = int.Parse(vet[0]);
        int H_final = int.Parse(vet[1]);

        int tempo;

        if (H_inicio < H_final)
        {
            tempo = H_final - H_inicio;
        }
        else
        {
            tempo = 24 - H_inicio + H_final;
        }
        Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
    }

}