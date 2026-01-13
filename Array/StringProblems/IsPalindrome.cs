using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class IsPalindromeProblem
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
    }
}
