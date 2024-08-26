using System;

class URI
{

    static void Main(string[] args)
    {

        string[] vet = Console.ReadLine().Split(' ');
        int horainicial = int.Parse(vet[0]);
        int minutoinicial = int.Parse(vet[1]);
        int horafinal = int.Parse(vet[2]);
        int minutofinal = int.Parse(vet[3]);
        int tempo, minuto;

        if (horainicial < horafinal && minutoinicial < minutofinal)
        {
            tempo = horafinal - horainicial;
            minuto = minutofinal - minutoinicial;
        }
        else if (horainicial > horafinal && minutoinicial > minutofinal)
        {
            tempo = 23 - horainicial + horafinal;
            minuto = 60 + minutofinal - minutoinicial;
        }
        else if (horainicial > horafinal && minutoinicial < minutofinal || horainicial == horafinal && minutoinicial == minutofinal)
        {
            tempo = 24 - horainicial + horafinal;
            minuto = minutofinal - minutoinicial;
        }
        else
        {
            tempo = horafinal - horainicial - 1;
            minuto = 60 + minutofinal - minutoinicial;
        }
        Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S) E " + minuto + " MINUTO(S)");
    }

}