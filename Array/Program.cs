namespace Problems;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static bool IsPowerOfTwo(int n)
    {
        if (n == 0)
        {
            return false;
        }

        if (n == 1)
        {
            return true;
        }

        var xx = Mth(n);

        if (xx == 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    public static int Mth(int n)
    {
        if (n == 2) { return 1; }
        if (n == 1) { return 0; }

        if (n % 2 != 0)
        {
            return 0;
        }

        return Mth(n / 2);
    }

    static void Main(string[] args)
    {
        var speed = 2000;

        var res = IsPowerOfTwo(speed);

        Console.WriteLine(res);
    }
}
