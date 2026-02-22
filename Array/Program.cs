namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static int SearchInsert(int[] nums, int target)
    {
        var length = nums.Length;

        var left = length / 2;

        var alreadyVisitedPos = new HashSet<int>();
        var alreadyVisitedNeg = new HashSet<int>();

        while (left < length)
        {
            if (target == nums[left])
            {
                return left;
            }           
            
            if (left == 0)
            {
                if (target > nums[left])
                {
                    return 1;
                }
                return left;
            }

            if (alreadyVisitedPos.Contains(left))
            {
                return left + 1;
            }

            if (alreadyVisitedNeg.Contains(left))
            {
                return left;
            }

            if (target > nums[left])
            {
                alreadyVisitedPos.Add(left);
                left++;
            }
            else
            {
                alreadyVisitedNeg.Add(left);
                left--;
            }

        }

        return length;
    }

    static void Main(string[] args)
    {
        var haystack = new int[] { 1, 3, 5, 6 };
        var target = 2;

        var res = SearchInsert(haystack, target);

        Console.WriteLine(res);
    }
}
