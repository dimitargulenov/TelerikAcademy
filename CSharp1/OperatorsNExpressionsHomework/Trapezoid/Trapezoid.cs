//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Globalization;
using System.Threading;

class Trapezoid
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Accepts "." if you have Regional settings set to Bulgaria, throws funny results when "," is used

        Console.WriteLine("Enter the trapezoid's side A:");
        float sideA = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the trapezoid's side B:");
        float sideB = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the trapezoid's height:");
        float height = float.Parse(Console.ReadLine());

        float area = (((sideA + sideB) / 2) * height);

        Console.WriteLine("The trapezoid's area is {0}.", area);
    }
}
