using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class IsIsomorphicProblem
    {
        public bool IsIsomorphic(string s, string t)
        {
            var sdictionay = new Dictionary<char, int>();
            var tdictionay = new Dictionary<char, int>();
            var sList = new List<int>();
            var tList = new List<int>();

            var start = 0;
            var tstart = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (sdictionay.TryGetValue(s[i], out int val))
                {
                    sList.Add(val);

                }
                else
                {
                    sdictionay.Add(s[i], start);
                    sList.Add(start);
                    start++;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (tdictionay.TryGetValue(t[i], out int val))
                {
                    tList.Add(val);

                }
                else
                {
                    tdictionay.Add(t[i], tstart);
                    tList.Add(tstart);
                    tstart++;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (sList[i] != tList[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
