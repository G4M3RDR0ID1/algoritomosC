string[] valores = Console.ReadLine().Split(' ');

int m = int.Parse(valores[0]);
int n = int.Parse(valores[1]);

int[,] mat = new int[m, n];

for (int i = 0; i < m; i++) 
{
    string[] s = Console.ReadLine().Split(' ');
    
    for (int j = 0; j < n; j++) 
    {
        mat[i,j] = int.Parse(s[j]);
    }
}

int x = int.Parse(Console.ReadLine());

for (int i = 0;i < m; i++) 
{
    for (int j = 0;j < n; j++) 
    {
        if (mat[i,j] == x) 
        {           
            Console.WriteLine("Position " + i + "," + j + ":");

            if (j > 0)
            {
                Console.WriteLine("Left: " + mat[i, j - 1]);
            }

            if (j + 1 < n)
            {
                Console.WriteLine("Right: " + mat[i, j + 1]);
            }

            if (i > 0)
            {
                Console.WriteLine("Up: " + mat[i - 1, j]);
            }

            if (i + 1 < m)
            {
                Console.WriteLine("Down: " + mat[i + 1, j]);
            }
        }
    }
}