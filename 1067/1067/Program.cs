﻿using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());

        
        for (int i = 0; i <= x; i++) 
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

    }

}