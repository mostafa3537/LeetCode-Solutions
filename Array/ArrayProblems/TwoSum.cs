using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArrayProblems;

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

    public static int[] TwoSumV2(int[] numbers, int target)
    {
        var result = new int[2];

        //left pointer and right pointer
        // while left < right
        //  sum = numbers[left] + numbers[right] sum == target then return add them to result

        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                result[0] = left;
                result[1] = right;
            }

            if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }


        return result;
    }
}
