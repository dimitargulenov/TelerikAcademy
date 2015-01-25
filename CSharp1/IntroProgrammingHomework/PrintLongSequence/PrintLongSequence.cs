//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence
{
    static void Main()
    {
        //This is nested loop
        for (int numOne = 2; numOne < 1001; numOne++)
        {
            Console.WriteLine(" {0}", numOne);

            for (int numTwo = ++numOne; numTwo <= numOne; numTwo++)
            {
                 Console.WriteLine("-{0}", numTwo);
            }
        }
    }
}     