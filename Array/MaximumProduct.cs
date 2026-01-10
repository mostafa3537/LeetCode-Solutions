using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class MaximumProductProblem
    {
        public static int MaximumProduct(int[] nums)
        {
            if (nums.Length < 3)
            {
                return 0;
            }


            Array.Sort(nums);

            var max = nums[0] * nums[1] * nums[nums.Length - 1];

            var min = nums[nums.Length - 3] * nums[nums.Length - 2] * nums[nums.Length - 1];

            return Math.Max(max, min);

        }
    }
}
