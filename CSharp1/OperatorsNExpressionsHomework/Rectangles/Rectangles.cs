//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Globalization;
using System.Threading;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Accepts "." if you have Regional settings set to Bulgaria, throws funny results when "," is used

        Console.WriteLine("Enter the regtangular's side A:");
        float sideA = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the regtangular's side B:");
        float sideB = float.Parse(Console.ReadLine());

        float perimeter = 2 * sideA + 2 * sideB;
        float area = sideA * sideB;

        Console.WriteLine("The regtangular's perimater is {0} and its area is {1}.", perimeter, area);
    }
}
