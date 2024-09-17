﻿using Listaex01;
using System.Security.Principal;

List<Employee> lista = new List<Employee>();

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++) 
{
    Console.WriteLine("Emplyoee #" + i);
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salario = double.Parse(Console.ReadLine());
    lista.Add(new Employee(id, name, salario));
    Console.WriteLine();

}

Console.Write("Enter the employee id that will have salary increase : ");
int idd = int.Parse(Console.ReadLine());

Employee s1 = lista.Find(x => x.Id == idd);

if (s1 != null) 
{
    Console.Write("Enter the percentage: ");
    double porcentagem = double.Parse(Console.ReadLine());
    s1.increaseSalary(porcentagem);
}
else 
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees: ");

foreach (Employee obj in lista) 
{
    Console.WriteLine(obj);
}