using System; 

class URI
{

    static void Main(string[] args)
    {

        double salario = double.Parse(Console.ReadLine());

        double imposto;

        if (salario <= 2000.00)     {
            Console.WriteLine("Isento");
        }
        else if (salario <= 3000.00)       {
            imposto =  (salario - 2000) * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }
        else if (salario <= 4500.00){
            imposto = 80 + (salario - 3000) * 0.18;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }
        else{
            imposto = 350 + (salario - 4500) * 0.28;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }
    }
}