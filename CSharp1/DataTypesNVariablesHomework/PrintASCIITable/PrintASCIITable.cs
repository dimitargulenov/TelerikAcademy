using System;
using System.Collections.Generic;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        for (int symbol = 0; symbol <= 255; symbol++)
        {
            System.Console.WriteLine("{0,3} = {1}", symbol, (char)symbol);
        }
    }
}