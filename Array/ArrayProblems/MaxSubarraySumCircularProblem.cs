using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class MaxSubarraySumCircularProblem
    {
        public static int MaxSubarraySumCircular(int[] nums)
        {
            // result = max bet (maxSum , sum - minSum)

            var result = 0;

            var max = MaxSum(nums);
            var sum = Sum(nums);
            var min = MinSum(nums);

            result = Math.Max(MaxSum(nums), Sum(nums) - MinSum(nums));



            return result;
        }

        private static int MaxSum(int[] nums)
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
        private static int Sum(int[] nums)
        {
            var sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }

            return sum;
        }
        private static int MinSum(int[] nums)
        {
            var result = nums[0];
            var sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum = Math.Min(sum + nums[i], nums[i]);

                result = Math.Min(result, sum);
            }

            return result;
        }
    }
}
