namespace Problems;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static int LengthOfLastWord(string s)
    {
        var words = new List<string>();

        s.Split(' ')
            .Where(x => !string.IsNullOrEmpty(x))
            .ToList().ForEach(x => words.Add(x));

        return words[^1].Length;
    }


    static void Main(string[] args)
    {
        var speed = "   fly me   to   the moon  ";

        var res = LengthOfLastWord(speed);

        Console.WriteLine(res);
    }
}
