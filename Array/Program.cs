using System.Collections.Generic;
using System.Linq;

namespace ArrayProblems;

internal class Program
{
    public static bool IsPalindrome(string s)
    {
        var result = true;


        // remove any space from string

        // 2 poiter left =0 right = string.length

        s = s.ToLower().Replace(" ", ""); ;

        string newString = new string(s.Where(char.IsLetterOrDigit).ToArray());

        var left = 0;
        var right = newString.Length - 1;

        while (left < right)
        {
            if (newString[left] != newString[right])
            {
                return false;
            }
            left++;

            right--;
        }

        return result;
    }


    static void Main(string[] args)
    {
        var s = "A man, a plan, a canal: Panama";

        var result = IsPalindrome(s);

        Console.WriteLine(result);
    }
}

