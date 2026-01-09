using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ArrayProblems;

internal class Program
{
    public static int LongestMountain(int[] arr)
    {
        var result = 0;
        var max = 0;

        // loop over []
        // check if th current i in peak
        // left and right side is desending
        // store max
        // result = Math.Max(max, currentMax)

        if (arr.Length < 3)
        {
            return 0;
        }

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                var left = i - 1;
                var right = i + 1;

                if (left >= 1)
                {
                    while (arr[left] > arr[left - 1] && left < i && left >= 1)
                    {
                        left--;
                        if (left == 0)
                        {
                            break;
                        }
                    }
                }

                if (right < arr.Length - 1)
                {
                    while (arr[right] > arr[right + 1] && right > i && right < arr.Length)
                    {
                        right++;
                        if (right == arr.Length - 1)
                        {
                            break;
                        }
                    }
                }

                max = Math.Max(max, right - left + 1);
                result = max;
            }
        }

        return result;
    }


    static void Main(string[] args)
    {
        var nums = new int[] { 40, 51, 29, 19, 50, 25 };
        //var target = 9;

        var result = LongestMountain(nums);

        Console.WriteLine(result);
    }
}

