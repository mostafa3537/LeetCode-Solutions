using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array;

internal class TwoSumProblem
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var res = new int[] { };

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (dict.ContainsKey(complement))
            {
                res = new int[] { dict[complement], i };
                break;
            }
            dict[nums[i]] = i;

        }

        return res;
    }
}
