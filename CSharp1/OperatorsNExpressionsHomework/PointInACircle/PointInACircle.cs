//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Accepts "." if you have Regional settings set to Bulgaria, throws funny results when "," is used

        double r = 2;

        Console.WriteLine("Enter the 'x' coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the 'y' coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(r, 2);

        Console.WriteLine("The point is{0}in the circle.", isInCircle ? " " : "n't ");
    }
}