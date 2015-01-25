//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("Which bit position would you want to replace:");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a bit value (0 or 1):");
        int bitValue = int.Parse(Console.ReadLine());

        if (bitValue == 1)
        {
            int mask = 1 << position;
            int result = input | mask;

            Console.WriteLine("{0} = {1}", Convert.ToString(result, 2).PadLeft(16, '0'), result);
        }
        else if (bitValue == 0)
        {
            int mask = ~(1 << position);
            int result = input & mask;

            Console.WriteLine("{0} = {1}", Convert.ToString(result, 2).PadLeft(16, '0'), result);
        }
    }
}
