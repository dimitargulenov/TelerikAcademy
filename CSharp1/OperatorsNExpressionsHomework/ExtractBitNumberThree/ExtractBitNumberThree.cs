//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class ExtractBitNumberThree
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int input = (int)uint.Parse(Console.ReadLine()); // They ask for uint, and the left-shift operator (<<) doesn't play nice with uint*, and this is what I came with.  *Or it could be me?

        int position = 3;
        int mask = 1 << position;
        int inputAndMask = input & mask;
        int bit = inputAndMask >> position;

        Console.WriteLine("The value of bit {0} is {1}.", position, bit);
    }
}
