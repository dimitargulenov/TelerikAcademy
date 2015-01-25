//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class IsThirdDigit7
{
    static void Main()
    {
        byte numOne = 7;

        Console.WriteLine("Enter a number to check if the third digit (right-to-left) is {0}:", 
            numOne);

        int input = int.Parse(Console.ReadLine());

        if ((input / 100) % 10 == numOne)
        {
            Console.WriteLine("It is {0}.",
            numOne);
        }
        else
        {
            Console.WriteLine("It is not {0}.",
            numOne);
        }
    }
}
