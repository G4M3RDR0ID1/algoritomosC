int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n,n];


for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++) 
    {
        mat[i, j] = int.Parse(s[j]);
    }
}

int negativo = 0;

for (int i = 0;i < n; i++) 
{
    for(int j = 0;j < n; j++) 
    {
        if (i == j) 
        {
            Console.Write(mat[i, j] + " ");           
        }

        if (mat[i, j] < 0) 
        {
            negativo++;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Negativos: " + negativo);