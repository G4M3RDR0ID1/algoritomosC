﻿using ex01Obj;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1, pessoa2;
            pessoa1 = new Pessoas();
            pessoa2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.Write("Pessoa mais velha: ");

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine(pessoa1.Nome);
            }
            else 
            {
                Console.WriteLine(pessoa2.Nome);
            }
        }
    }
}