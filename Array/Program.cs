namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static int MySqrt(int x)
    {
        var result = 0;

        var max = int.MaxValue;


        for (long i = 0; i < max; i++)
        {
            if (i * i > x)
            {
                return (int)i - 1;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        var target = 2147395600;

        var res = MySqrt(target);

        Console.WriteLine(res);
    }
}
