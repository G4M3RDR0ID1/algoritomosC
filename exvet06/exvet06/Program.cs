namespace uri1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idd = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] usuarios = Console.ReadLine().Split(' ');
                nome[i] = usuarios[0];
                idd[i] = int.Parse(usuarios[01]);
            }

            int maior = 0;
            string nomeDoMaior = nome[0];

            for (int i = 0; i < n; i++)
            {
                if (maior < idd[i])
                {
                    maior = idd[i];
                    nomeDoMaior = nome[i];
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomeDoMaior);
        }
    }
}