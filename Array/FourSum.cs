using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

internal class FourSumProblem
{
    public static IList<IList<int>> FourSum(int[] nums, int target)
    {
        var result = new List<IList<int>>();

        if (nums.Length < 4)
        {
            return result;
        }

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;

                var left = j + 1;
                var right = nums.Length - 1;


                while (left < right && left != j && right != i)
                {
                    long sum = (long)nums[j] + nums[left] + nums[right] + nums[i];

                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[j], nums[left], nums[right], nums[i] });

                        while (left < right && nums[left] == nums[left + 1])
                            left++;

                        // skip duplicate right
                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;

                    }


                    else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

        }

        return result;

    }
}
