int N = int.Parse(Console.ReadLine());

string[] Sa = Console.ReadLine().Split(' ');
string[] Sb = Console.ReadLine().Split(' ');

int[] a = new int[N];
int[] b = new int[N];

for (int i = 0; i < N; i++) 
{
    a[i] = int.Parse(Sa[i]);
    b[i] = int.Parse(Sb[i]);
}

int[] c = new int[N];

for (int i = 0;i < N; i++)
{
    c[i] = a[i] + b[i];
    Console.Write(c[i] + " ");
}
Console.WriteLine();