//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Globalization;
using System.Threading;

class PointInsideCircleNOutsideRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Accepts "." if you have Regional settings set to Bulgaria, throws funny results when "," is used

        double circleX = 1;
        double circleY = 1;
        double circleRadius = 1.5;
        double rectTop = 1;
        double rectLeft = -1;
        double rectWidth = 6;
        double rectHeight = 2;

        Console.WriteLine("Enter the 'x' coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the 'y' coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Pow(x - circleX, 2) + Math.Pow(y - circleY, 2)) <=
        Math.Pow(circleRadius, 2);

        bool isOutRectangle = (x < rectLeft) || (x > rectLeft + rectWidth) ||
        (y > rectTop) || (y < rectTop - rectHeight);

        Console.WriteLine("It is{0}inside the circle and outside of the rectangle.", (isInCircle && isOutRectangle) ? " " : "n't ");
    }
}
