namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static int FindDuplicate(int[] nums)
    {
        var intersection = GetIntersection(nums);

        var head = 0;

        while (head != intersection)
        {
            head = nums[head];
            intersection = nums[intersection];
        }

        return head;
    }

    private static int GetIntersection(int[] nums)
    {
        var slow = 0;
        var fast = 0;

        while (true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];

            if (slow == fast)
            {
                return slow;
            }
        }
    }


    static void Main(string[] args)
    {
        var head = new int[] { 3, 1, 3, 4, 2 };

        var res = FindDuplicate(head);

        Console.WriteLine(res);
    }
}
