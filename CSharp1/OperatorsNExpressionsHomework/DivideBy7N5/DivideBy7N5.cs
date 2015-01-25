//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7N5
{
    static void Main()
    {
        byte numOne = 7;
        byte numTwo = 5;

        Console.WriteLine("Enter a number to check if it is divisible by {0} and {1}:", 
            numOne, numTwo);

        int input = int.Parse(Console.ReadLine());

        bool output = (input % numOne == 0) && (input % numTwo == 0);
        {
            if (output == true)
            {
                Console.WriteLine("It is divisible by {0} and {1}.",
                    numOne, numTwo);
            }
            else
            {
                Console.WriteLine("It is not divisible by {0} and {1}.",
                    numOne, numTwo);
            }
        }
    }
}
