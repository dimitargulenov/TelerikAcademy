//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

//Submit the source code of your Visual Studio project as part of your homework submission.

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort numOne = 52130;
        short numTwo = -115;
        int numThree = 4825932;
        byte numFour = 97;
        short numFive = -10000;

        Console.WriteLine(" {0}\n{1}\n {2}\n {3}\n{4}", numOne, numTwo, numThree, numFour, numFive);
    }
}
