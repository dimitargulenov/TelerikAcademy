//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

    class PrintSequence
    {
        static void Main()
        {
            //This is nested loop
            for (int numOne = 2; numOne < 11; numOne++)
            {
                Console.WriteLine(" {0}", numOne);

                for (int numTwo = ++numOne; numTwo <= numOne; numTwo++)
                {
                    Console.WriteLine("-{0}", numTwo);
                }
            }
        }
    }
