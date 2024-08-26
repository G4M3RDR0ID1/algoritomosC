int n = int.Parse(Console.ReadLine());

string[] s = Console.ReadLine().Split(' ');

int[] numeros = new int[n];

for (int i = 0; i < n; i++) 
{
    numeros[i] = int.Parse(s[i]);
}

int pares = 0;
int quantidadeDePares = 0;

for (int i = 0;i < n; i++) 
{
    if (numeros[i] % 2 == 0) 
    {
        quantidadeDePares = quantidadeDePares + 1;
        pares = numeros[i];
        Console.Write(pares + " ");
    }
    if (i == n -1) 
    {
        Console.WriteLine();
    }
}
Console.WriteLine(quantidadeDePares);