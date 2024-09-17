using Listaex01;

Employee funcionario = new Employee();
List<Employee> lista = new List<Employee>();
Console.Write("How many employees will be registered?");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++) 
{
    Console.WriteLine("Emplyoee #" + i);
    Console.Write("Id:");
    funcionario.Id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    funcionario.Name = Console.ReadLine();
    Console.Write("Salary");
    double salario = double.Parse(Console.ReadLine());
    funcionario.Salario(salario);
    Console.WriteLine();
    lista.Add(funcionario);
}

Console.Write("Enter the employee id that will have salary increase : ");
int idd = int.Parse(Console.ReadLine());

foreach 