using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.HashTablesProblems
{
    internal class MajorityElementProblem
    {
        public static int MajorityElement(int[] nums)
        {
            var result = 0;

            var limit = nums.Length / 2;


            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out int val))
                {
                    dict[nums[i]] = val + 1;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
            }

            dict.Keys.ToList().ForEach(key =>
            {
                if (dict[key] > limit)
                {
                    result = key;
                }
            });

            return result;
        }
    }
}
