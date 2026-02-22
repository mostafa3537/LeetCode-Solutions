using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class StrStrProblem
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
    }
}
