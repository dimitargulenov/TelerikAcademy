//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter an integer to check if it's even or odd:");

        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("This number is {0}.", num % 2 == 0 ? "even" : "odd");
    }
}
