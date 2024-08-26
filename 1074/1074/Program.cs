using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) 
        {
            int x = int.Parse(Console.ReadLine());  

            if (x % 2 == 0 && x > 0)
            {
                Console.WriteLine("EVEN POSITIVE");
            }
            else if (x % 2 == 0 && x < 0)
            {
                Console.WriteLine("EVEN NEGATIVE");
            }
            else if (x % 2 != 0 && x > 0)
            {
                Console.WriteLine("ODD POSITIVE");
            }
            else if (x % 2 != 0 && x < 0)
            {
                Console.WriteLine("ODD NEGATIVE");
            }
            else
            {
                Console.WriteLine("NULL");
            }
        }

    }

}