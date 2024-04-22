using System;
using static System.Console;

class Test
{
    static void Main()
    {
        Console.WriteLine("값을 입력해주세요. ==> ");

        /*OutVariable
        
        var xx = Console.ReadLine();
        if (int.TryParse(xx, out int value))
        {
            Console.WriteLine(value);
        }

        */

        /*CharTest*/

        Console.WriteLine("영문 대문자 또는 소문자 하나를 입력하세요.");
        char c = Convert.ToChar(ReadLine());

        if (c >= 'A' && c <= 'Z')
        {
            Console.WriteLine($"{c}는 대문자입니다.");
        }
        else
        {
            Console.WriteLine($"{c}는 소문자입니다.");
        }

    }
}
