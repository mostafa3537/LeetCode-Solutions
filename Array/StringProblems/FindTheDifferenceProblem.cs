using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class FindTheDifferenceProblem
    {
        public static char FindTheDifference(string s, string t)
        {
            var result = char.MinValue;

            var dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.TryGetValue(s[i], out int val))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic[s[i]] = 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dic.TryGetValue(t[i], out int val))
                {
                    if (val == 0)
                    {
                        return t[i];
                    }
                    dic[t[i]]--;
                }
                else
                {
                    return t[i];
                }
            }
            return result;
        }
    }
}
