using System.Collections.Generic;
using System.Linq;

namespace ArrayProblems;

internal class Program
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

    static void Main(string[] args)
    {
        var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        ;
        var result = MaxSubArray(nums);

        Console.WriteLine(result);
    }
}

