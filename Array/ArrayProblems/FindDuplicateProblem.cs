using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArrayProblems
{
    internal class FindDuplicateProblem
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
    }
}
