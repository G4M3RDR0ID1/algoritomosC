namespace uri1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat;
            mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            int negativo = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        negativo++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativo);
        }
    }
}