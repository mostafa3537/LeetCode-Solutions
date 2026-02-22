namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static int StrStr(string haystack, string needle)
    {
        var result = -1;

        if (haystack.Length < needle.Length)
        {
            return result;
        }

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            var subStr = haystack.Substring(i, needle.Length);
            if (subStr == needle)
            {
                result = i;
                break;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        var haystack = "sadbutsad"; var needle = "sad";

        var res = StrStr(haystack , needle);

        Console.WriteLine(res);
    }
}
