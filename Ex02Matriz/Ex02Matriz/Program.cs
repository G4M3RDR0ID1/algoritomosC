using System.Runtime.Serialization;

string[] valores = Console.ReadLine().Split(' ');

int m = int.Parse(valores[0]);
int n  = int.Parse(valores[1]);

int[,] matriz = new int[m, n];

for (int i = 0; i < m; i++) 
{
    string[] s = Console.ReadLine().Split(); 
    for (int j = 0; j < n; j++) 
    {
        matriz[i,j] = int.Parse(s[j]);
    }
}

int[] vet = new int[m];

for (int i = 0;i < m; i++) 
{
    int soma = 0;
    for (int j = 0;j < n; j++) 
    {
        soma = soma + matriz[i,j];
    }
    vet[i] = soma;
}

for (int i = 0; i < m; i++) 
{
    Console.WriteLine(vet[i]);
}