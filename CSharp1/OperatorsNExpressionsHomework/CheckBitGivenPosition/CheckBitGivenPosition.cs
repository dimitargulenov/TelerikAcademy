//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("Which bit position would you want to check if the value is 1:");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int inputAndMask = input & mask;
        int bit = inputAndMask >> position;
        bool isOne = bit == 1;

        Console.WriteLine(isOne);
    }
}
