using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

internal class LongestOnesProblem
{
    public static int LongestOnes(int[] nums, int k)
    {
        var result = 0;
        var left = 0;

        var zeros = 0;
        for (int right = 0; right < nums.Length; right++)
        {

            if (nums[right] == 0)
            {
                zeros++;
            }

            //while condition not meet increase left
            while (zeros > k)
            {
                if (nums[left] == 0)
                {
                    zeros--;
                }
                left++;

            }
            int maxLenght = right - left + 1;

            result = Math.Max(result, maxLenght);

        }
        return result;
    }
}
