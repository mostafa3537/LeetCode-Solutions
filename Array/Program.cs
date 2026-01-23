using System.Linq;

namespace Problems;

internal class Program
{
    public static bool ValidPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                return IsPalindrome(s, left+1, right) || IsPalindrome(s, left, right - 1);
            }
        }

        return true;
    }

    private static bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    static void Main(string[] args)
    {
        var s = "eedede";

        var result = ValidPalindrome(s);

        Console.WriteLine(result);
    }
}
