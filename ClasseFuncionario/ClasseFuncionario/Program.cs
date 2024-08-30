using ClasseFuncionario;

Funcionario dados = new Funcionario();

Console.Write("Nome: ");
dados.Nome = Console.ReadLine();
Console.Write("Salario bruto: ");
dados.Salario = double.Parse(Console.ReadLine());
Console.Write("Imposto: ");
dados.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine("Funcionario : " + dados);

Console.Write("Digite a porcentagem para aumentar o salario: ");
double porcentagem = double.Parse(Console.ReadLine());
dados.AumentarSalario(porcentagem);

Console.WriteLine("Dados atualizados: " + dados);