using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems;

internal class MaximumDifferenceProblem
{
    public static int MaximumDifference(int[] nums)
    {
        var minimumSoFar = nums[0];
        var maxDifference = -1;

        for (int i = 1; i < nums.Length; i++)
        {
            var currentNumber = nums[i];

            if (currentNumber <= minimumSoFar)
            {
                minimumSoFar = currentNumber;
            }
            else
            {
                maxDifference = Math.Max(maxDifference, currentNumber - minimumSoFar);
            }

        }

        return maxDifference;
    }
}
