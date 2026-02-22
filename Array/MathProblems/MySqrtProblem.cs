using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.MathProblems
{
    internal class MySqrtProblem
    {
        public static int MySqrt(int x)
        {
            var result = 0;

            var max = int.MaxValue;


            for (long i = 0; i < max; i++)
            {
                if (i * i > x)
                {
                    return (int)i - 1;
                }
            }

            return result;
        }
    }
}
