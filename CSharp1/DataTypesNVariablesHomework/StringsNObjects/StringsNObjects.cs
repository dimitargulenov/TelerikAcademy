//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class StringsNObjects
{
    static void Main()
    {
        string textOne = "Hello";
        string textTwo = "World";
        object textFull = string.Concat(textOne + " " + textTwo);
        string textFinal = (string)textFull;

        Console.WriteLine(textFinal);
    }
}
