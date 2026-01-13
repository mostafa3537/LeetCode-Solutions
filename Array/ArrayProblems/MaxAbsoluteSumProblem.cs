using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArrayProblems
{
    internal class MaxAbsoluteSumProblem
    {
        public int MaxAbsoluteSum(int[] nums)
        {
            var result = nums[0];
            var sum = nums[0];

            var result2 = nums[0];
            var sum2 = nums[0];

            var result3 = nums[0];

            if (nums.Length == 1)
            {
                return Math.Abs(result3);
            }

            for (int i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(sum + nums[i], nums[i]);

                result = Math.Max(result, sum);

                sum2 = Math.Min(sum2 + nums[i], nums[i]);

                result2 = Math.Min(result2, sum2);

                result3 = Math.Max(result, Math.Abs(result2));
            }

            return result3;
        }
    }
}
