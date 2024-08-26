using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int cont = 0, soma = 0;
        double resultado;

        while (n > 0) 
        { 
            cont = cont + 1;
            soma = soma + n;
            n = int.Parse(Console.ReadLine());
        }
        resultado = (double)soma / cont;
        Console.WriteLine(resultado.ToString("F2"));
    }

}