using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class MaxSubArrayProblem
    {
        public static int MaxSubArray(int[] nums)
        {
            var result = nums[0];
            var sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(sum + nums[i], nums[i]);

                result = Math.Max(result, sum);
            }

            return result;
        }
    }
}
