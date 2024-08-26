int n = int.Parse(Console.ReadLine());

string[] nome = new string[n];
double[] notas1 = new double[n];
double [] notas2 = new double[n]; 

for (int i = 0; i < n; i++) 
{
    string[] strings = Console.ReadLine().Split(' ');
    nome[i] = strings[0];
    notas1[i] = double.Parse(strings[1]);
    notas2[i] = double.Parse(strings[2]);
}

double media = 0;

Console.WriteLine("Alunos aprovados: ");

for  (int i = 0;i < n; i++) 
{
    media = (notas1[i] + notas2[i]) / 2; 

    if (media >= 6.0) 
    {
        Console.WriteLine(nome[i]);
    }

}