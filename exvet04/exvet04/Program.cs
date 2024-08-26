int n = int.Parse(Console.ReadLine());

string[] strings = Console.ReadLine().Split(' ');

double[] s = new double[n];

for (int i = 0; i < n; i++) 
{
    s[i] = double.Parse(strings[i]);
}

double media = 0;

for  (int i = 0;i < n; i++)
{
    media = media + s[i];
}

media = media / n;

Console.WriteLine(media);

for (int i = 0; i < n; i++) 
{ 
    if (s[i] < media) 
    {
        Console.WriteLine(s[i]);
    }
}