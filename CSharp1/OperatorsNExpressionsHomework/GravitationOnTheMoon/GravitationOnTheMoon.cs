//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Globalization;
using System.Threading;

class GravitationOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Accepts "." if you have Regional settings set to Bulgaria, throws funny results when "," is used

        Console.WriteLine("Enter your weight (I wont tell anyone :) ):");

        float weight = float.Parse(Console.ReadLine());
        float weightMoon = (weight * 17 / 100);

        Console.WriteLine("Your moon weight would be:\n{0} tons \n\n\nI'm kidding, of course it's kg, don't get upset :)", weightMoon);
    }
}
