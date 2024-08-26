using System; 

class URI
{

    static void Main(string[] args)
    {
        
        string[] vet = Console.ReadLine().Split(' ');
        float A = float.Parse(vet[0]);
        float B = float.Parse(vet[1]);
        float C = float.Parse(vet[2]);
        float perimetro = A + B + C;
        float area = ((A + B) * C) / 2;

        if (A + B > C && B + C > A && A + C > B)
        {
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
        }
        else
        {
            Console.WriteLine("Area = " + area.ToString("F1"));
        }
    }

}