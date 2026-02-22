using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArrayProblems
{
    internal class SearchInsertProblem
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
    }
}
