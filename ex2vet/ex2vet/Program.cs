int n = int.Parse(Console.ReadLine());
double[] numeros = new double[n];
string[] x = Console.ReadLine().Split(" ");


for  (int i = 0; i < n; i++) 
{
    numeros[i] = double.Parse(x[i]);
}

double soma = 0;
double media= 0;

for (int i = 0; i < n; i++) 
{
    Console.Write(numeros[i].ToString("f1") + " ");
    soma = soma + numeros[i];
    if (i == n - 1) 
    {
        media = soma / n;
        Console.WriteLine();
        Console.WriteLine(soma.ToString("f1"));
        Console.WriteLine(media.ToString("f1"));
    }
}




