using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class LengthOfLastWordProblem
    {
        public static int LengthOfLastWord(string s)
        {
            var words = new List<string>();

            s.Split(' ')
                .Where(x => !string.IsNullOrEmpty(x))
                .ToList().ForEach(x => words.Add(x));

            return words[^1].Length;
        }
    }
}
