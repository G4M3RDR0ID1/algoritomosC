using System;

class URI
{

    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());

        while (X != 0) 
        {
            if (X % 2 == 0)
            {
                X = (X) + (X + 2) + (X + 4) + (X + 6) + (X + 8);
            }
            else 
            {
                X = (X + 1) + (X + 3) + (X + 5) + (X + 7) + (X + 9);
            }
            Console.WriteLine(X);
            X = int.Parse(Console.ReadLine());
        }
    }

}