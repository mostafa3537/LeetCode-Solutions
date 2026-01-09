using System.Collections.Generic;
using System.Linq;

namespace ArrayProblems;

internal class Program
{
    public static int[] TwoSum(int[] numbers, int target)
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


    static void Main(string[] args)
    {
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 9;

        var result = TwoSum(nums, target);

        Console.WriteLine(result);
    }
}

