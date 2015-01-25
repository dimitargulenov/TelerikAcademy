//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInt
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("Which bit position would you want to check:");
        int position = int.Parse(Console.ReadLine()); 

        int mask = 1 << position;
        int inputAndMask = input & mask;
        int bit = inputAndMask >> position;

        Console.WriteLine("The value of integer {0} bit# {1} is {2}.", input, position, bit);
    }
}