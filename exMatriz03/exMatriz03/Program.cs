using System.Runtime.Serialization;

int n = int.Parse(Console.ReadLine());

int[,] mat = new int [n, n];

for (int i = 0; i < n; i++) 
{
    string[] s = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++) 
    {
        mat[i,j] = int.Parse(s[j]);
    }
}


for (int i = 0;i < n; i++) 
{
    int maior = mat[i,0];
    for (int j = 1;j < n; j++) 
    {
        if (maior < mat[i,j]) 
        {
            maior = mat[i,j];
        }
    }
    Console.WriteLine(maior);
}