using System;

class URI
{

    static void Main(string[] args)
    {

        int s = int.Parse(Console.ReadLine());

       while (s != 2002) 
       {
            Console.WriteLine("Senha Invalida");
            s = int.Parse(Console.ReadLine());
       }
       if (s == 2002)
        {
            Console.WriteLine("Acesso Permitido");
        }
    }

}