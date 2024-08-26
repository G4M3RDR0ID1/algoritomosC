int n = int.Parse(Console.ReadLine());

string[] s = Console.ReadLine().Split(' ');

double[] numeros = new double[n]; 

for (int i = 0; i < n; i++) 
{
    numeros[i] = double.Parse(s[i]);
}

double maior = 0;
int posicao  = 0;

for (int i = 0; i < n; i++) 
{
    if (maior < numeros[i]) 
    { 
        maior = numeros[i];
        posicao = i;
    }
}

Console.WriteLine(maior.ToString("f1"));
Console.WriteLine(posicao);