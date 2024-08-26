int n = int.Parse(Console.ReadLine());

double[] altura = new double[n];
char[] sexo = new char[n];

for (int i = 0; i < n; i++) 
{
    string[] valores = Console.ReadLine().Split(' ');
    altura[i] = double.Parse(valores[0]);
    sexo[i] = char.Parse(valores[1]);
}

double menor = altura[0];
double maior = altura[0];

for (int i = 0;i < n; i++) 
{
    if (altura[i] < menor) 
    {
        menor = altura[i];
    }

    if (maior < altura[i]) 
    {
        maior = altura[i];  
    }
}

Console.WriteLine("Menor altura = " + menor);
Console.WriteLine("Maior altura = " + maior);

double alturaFtotal = 0;
double mediaAlturaFeminina = 0;
int quantidadeDeH = 0;
int quantidadeDeM = 0;

for (int i = 0; i < n; i++) 
{
    if (sexo[i] == 'f') 
    {
        alturaFtotal = alturaFtotal + altura[i];
        quantidadeDeM++;
    }
    else 
    {
        quantidadeDeH++;
    }
}

mediaAlturaFeminina = alturaFtotal / quantidadeDeM;

Console.WriteLine("Media das alturas das mulheres = " + mediaAlturaFeminina.ToString("F2"));
Console.WriteLine("Numero de homens = " + quantidadeDeH);