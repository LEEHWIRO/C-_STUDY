﻿using System;
using static System.Console;

class OutVariable
{
    static void Main()
    {
        Console.Write("값을 입력해주세요. ==> ");
        
        var xx = Console.ReadLine();
        if (int.TryParse(xx, out int value))
        {
            Console.WriteLine(value);
        }

    }
}
