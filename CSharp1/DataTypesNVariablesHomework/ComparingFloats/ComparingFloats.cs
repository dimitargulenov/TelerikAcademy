//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double numOne = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double numTwo = Convert.ToDouble(Console.ReadLine());

        bool equal = Math.Abs(numOne - numTwo) < 0.000001;
        Console.WriteLine("The numbers are{0}equal.", equal ? " " : "n't ");
    }
}
