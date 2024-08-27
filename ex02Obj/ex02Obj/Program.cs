using ex02Obj;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios F1, F2;
            F1 = new Funcionarios();
            F2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            F1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            F2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            F2.Salario = double.Parse(Console.ReadLine());

            Console.Write("Salario medio = ");

            double SalarioMedio = (F1.Salario + F2.Salario) / 2.00;

            Console.WriteLine(SalarioMedio.ToString("f2"));
        }
    }
}