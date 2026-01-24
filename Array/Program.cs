using System.Linq;

namespace Problems;

internal class Program
{
    public static int NumMatchingSubseq(string s, string[] words)
    {
        var result = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (IsSubsequence(words[i], s))
            {
                result++;
            }
        }
        return result;
    }

    private static bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length)
        {
            return false;
        }

        var sPointer = 0;
        var tPointer = 0;

        while (sPointer < s.Length && tPointer < t.Length)
        {

            if (s[sPointer] == t[tPointer])
            {
                sPointer++;
                tPointer++;
            }
            else
            {
                tPointer++;

            }
        }

        if (sPointer != s.Length)
        {
            return false;

        }
        return true;

    }
    static void Main(string[] args)
    {
        var words = new string[] { "a", "bb", "acd", "ace" };
        var s = "abcde";

        var result = NumMatchingSubseq(s, words);

        Console.WriteLine(result);
    }
}
