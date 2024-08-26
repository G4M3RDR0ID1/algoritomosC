int n = int.Parse(Console.ReadLine());

string[] strings = Console.ReadLine().Split(' ');

int[] valores = new int[n]; 

for  (int i = 0; i < n; i++) 
{
    valores[i] = int.Parse(strings[i]);
    
}

double media = 0;
int divisor = 0;

for (int i = 0;i < n; i++) 
{
    if (valores[i] % 2 == 0)
    {
        media = media + valores[i];
        divisor++;
    }
}

if (media == 0)
{
    Console.WriteLine("Nao habia nenhum numero par");
}
else
{
    media = media / divisor;

    Console.WriteLine(media.ToString("f1"));
}

