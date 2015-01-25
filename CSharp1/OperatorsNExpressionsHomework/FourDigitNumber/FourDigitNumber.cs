//    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//        Prints on the console the number in reversed order: dcba (in our example 1102).
//        Puts the last digit in the first position: dabc (in our example 1201).
//        Exchanges the second and the third digits: acbd (in our example 2101).

//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a 4 digit number to do some tricks with it:");
        int input = int.Parse(Console.ReadLine());

        int a = (input / 1000) % 10;
        int b = (input / 100) % 10;
        int c = (input / 10) % 10;
        int d = input % 10;

        Console.WriteLine("The sum of {0}{1}{2}{3} is {4}.", a, b, c, d, (a + b + c + d));
        Console.WriteLine("The reversed order of {0}{1}{2}{3} is {3}{2}{1}{0}.", a, b, c, d);
        Console.WriteLine("Last comes first - {0}{1}{2}{3}.", d, a, b, c);
        Console.WriteLine("Game in the center - {0}{1}{2}{3}.", a, c, b, d);
    }
}
