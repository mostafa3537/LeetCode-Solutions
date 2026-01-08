using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class LengthOfLongestSubstringProblem
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
    }
}
