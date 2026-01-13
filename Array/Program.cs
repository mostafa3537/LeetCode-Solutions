using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ArrayProblems;

internal class Program
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
    static void Main(string[] args)
    {
        var nums = new int[] { 1, 2, 3 };
        //var target = -294967296;

        var result = MaximumProduct(nums);

        Console.WriteLine(result);
    }
}
