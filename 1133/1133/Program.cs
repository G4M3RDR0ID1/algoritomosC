using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int min, max;

        min = x; max = y;

        if (x > y)
        {
            max = x; min = y;
        }

        for (int i = min + 1; i < max; i++) 
        { 
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }

}