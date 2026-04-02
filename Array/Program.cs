namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static bool FindTheDifference(string pattern, string s)
    {
        var result = false;

        var dic = new Dictionary<char, string>();




        for (int i = 0; i < pattern.Length; i++)
        {
            dic[i] = pattern[i];
        }
        
        return result;
    }


    static void Main(string[] args)
    {
        var pattern = "abba";
        var t = "dog cat cat dog";

        var res = FindTheDifference(pattern, t);
        Console.WriteLine(res);
    }
}
