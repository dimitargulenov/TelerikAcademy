//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? numOne = null;
        double? numTwo = null;

        Console.WriteLine("{0}, {1}", numOne, numTwo);

        numOne += 38;
        numTwo += 99.38;

        Console.WriteLine("{0}, {1}", numOne, numTwo);

        //Nice commas and nothing else :)
    }
}
