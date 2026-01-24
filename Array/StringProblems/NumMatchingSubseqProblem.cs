using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class NumMatchingSubseqProblem
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
    }
}
