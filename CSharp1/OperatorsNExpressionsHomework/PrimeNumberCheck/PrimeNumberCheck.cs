//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        TryAgain:
        Console.WriteLine("Write a positive number to check if it's a prime:");
        int input = int.Parse(Console.ReadLine());
        int range = 100;

        if ((input > 1) && (range > input))
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("{0} is prime.", input);
            }
            else
            {
                Console.WriteLine("{0} is not prime.", input);
            }               
        }
        else
        {
            Console.WriteLine("\nInvalid range.\nIt should be between 2 and {0}.\n", range - 3);

            goto TryAgain; // Yeah, I'm using goto, I'm really really bad bad :D If you tell me how not to, you are welcome.
        }        
    }
}
