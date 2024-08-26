using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int dentro = 0, fora = 0; 

        for (int i = 0; i < x; i++) 
        {

            int n = int.Parse(Console.ReadLine());

            if (n >= 10 && n <= 20)
            {
                dentro = dentro + 1;
            }
            else 
            {
                fora = fora + 1;
            }
        }

        Console.WriteLine(dentro + " in");
        Console.WriteLine(fora + " out");
    }

}