using Pensionato;

Estudantes[] quartos = new Estudantes[10];

Console.Write("Quantos quartos serão alugados? ");
int quartosAlugados = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= quartosAlugados; i++) 
{
    Console.WriteLine("Aluguel #" + i + ":");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    Console.WriteLine();

    quartos[quarto] = new Estudantes(nome, email);
}

Console.WriteLine("Quartos ocupados: ");

for (int i = 0; i < 10; i++) 
{
    if (quartos[i] != null) 
    {
        Console.WriteLine(i + ": " + quartos[i]);
    }
}
