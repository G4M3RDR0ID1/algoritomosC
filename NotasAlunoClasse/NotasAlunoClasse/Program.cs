using NotasAlunoClasse;

Aluno dados = new Aluno();

Console.Write("Nome do aluno: ");
dados.Nome = Console.ReadLine();
Console.WriteLine("Digite as tres notas do aluno: ");
dados.N1 = double.Parse(Console.ReadLine());
dados.N2 = double.Parse(Console.ReadLine());
dados.N3 = double.Parse(Console.ReadLine());

Console.WriteLine("Nota Final: " + dados.NotaFinal().ToString("f2"));

if (dados.Aprovado()) 
{
    Console.WriteLine("APROVADO");
}
else 
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM " + dados.NotaRestante().ToString("f2"));
}





