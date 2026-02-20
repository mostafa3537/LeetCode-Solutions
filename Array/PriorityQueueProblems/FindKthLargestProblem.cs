using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.PriorityQueueProblems
{
    internal class FindKthLargestProblem
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            var result = 0;

            var priority = new PriorityQueue<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                priority.Enqueue(nums[i], nums[i]);
            }

            for (int i = 0; i < nums.Length - k + 1; i++)
            {
                result = priority.Dequeue();
            }

            return result;
        }
    }
}
