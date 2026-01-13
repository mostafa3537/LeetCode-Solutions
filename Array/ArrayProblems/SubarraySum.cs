using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class SubarraySumProblem
    {
        public static int SubarraySum(int[] nums, int k)
        {
            var result = 0;
            var prefixSumDictionary = new Dictionary<int, int>();
            var prefixSum = 0;

            prefixSumDictionary.Add(0, 1); // To handle the case when prefixSum itself is equal to k
            for (int i = 0; i < nums.Length; i++)
            {
                prefixSum += nums[i];

                if (prefixSumDictionary.TryGetValue(prefixSum - k, out int count))
                {
                    result = result + count;
                }

                if (prefixSumDictionary.ContainsKey(prefixSum))
                {
                    prefixSumDictionary[prefixSum]++;
                }
                else
                {
                    prefixSumDictionary.Add(prefixSum, 1);
                }
            }

            return result;
        }
    }
}
