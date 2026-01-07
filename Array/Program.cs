using System.Collections.Generic;
using System.Linq;

namespace ArrayProblems;

internal class Program
{
    public static int LengthOfLongestSubstring(string s)
    {
        var result = 0;
        var left = 0;
        var set = new HashSet<char>();

        for (int right = 0; right < s.Length; right++)
        {
            //dic<key: s[right], value: right>


            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);

                left++;
            }

            set.Add(s[right]);

            int maxLenght = right - left + 1;

            result = Math.Max(result, maxLenght);
        }
        return result;
    }

    static void Main(string[] args)
    {
        var s = "jbpnbwwd"
;
        var result = LengthOfLongestSubstring(s);

        Console.WriteLine(result);
    }
}

